using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator;

file static class Program
{
	private const string SolutionName = "GlmResharpened";
	private const string GeneratorProjectName = $"{SolutionName}.Generator";
	private const string LibProjectName = $"{SolutionName}.Generated";
	private const string TestProjectName = $"{SolutionName}.Test";
	private static readonly bool DeletePreviousGenerated = false;

	private static readonly ManagedDirectories ManagedDirs = new(SolutionName, LibProjectName, TestProjectName, GeneratorProjectName);

	private static void Main()
	{
		Console.WriteLine($"{GeneratorProjectName} running!");
		Console.WriteLine();
		Console.WriteLine($"Solution: {ManagedDirs.Solution.File}");
		Console.WriteLine($"Generator: {ManagedDirs.Generator.File}");
		Console.WriteLine($"Lib: {ManagedDirs.Lib.File}");
		Console.WriteLine($"Test: {ManagedDirs.Test.File}");
		Console.WriteLine();

		if (DeletePreviousGenerated)
			DeleteGeneratedFiles(ManagedDirs.Lib.Dir, ManagedDirs.Test.Dir);

		var types = AbstractType.InitTypes().Values.ToArray();
		GenerateCodeForTypes(ManagedDirs.Lib.Dir, ManagedDirs.Test.Dir, types);
	}

	private static void DeleteGeneratedFiles(string libProjectDir, string testProjectDir)
	{
		Console.WriteLine("Deleting previously generated files...");

		var libGenDir = new DirectoryInfo(Path.Combine(libProjectDir, "Generated"));
		if (libGenDir.Exists)
			libGenDir.Delete(true);

		var testGenDir = new DirectoryInfo(Path.Combine(testProjectDir, "Generated"));
		if (testGenDir.Exists)
			testGenDir.Delete(true);

		Console.WriteLine();
	}

	private static void GenerateCodeForTypes(string libProjectDir, string testProjectDir, AbstractType[] types)
	{
		Console.WriteLine($"Generating code for {types.Length} types...");
		Console.WriteLine();

		var digits = types.Length.ToString().Length;
		for (var i = 0; i < types.Length; ++i)
		{
			var type = types[i];

			if (i != 0)
				Console.WriteLine();
			Console.WriteLine($"    [{(i + 1).ToString().PadLeft(digits, ' ')}/{types.Length}] Generating {type.Name}...");

			GenerateCodeForType(libProjectDir, testProjectDir, type);
		}

		Console.WriteLine();
		Console.WriteLine("Generation Finished!");
	}

	private static void GenerateCodeForType(string libProjectDir, string testProjectDir, AbstractType type)
	{
		GenerateClassCode(libProjectDir, type);
		GenerateGlmCode(libProjectDir, type);
		GenerateTestCode(testProjectDir, type);
	}

	private static void GenerateClassCode(string libProjectDir, AbstractType type)
	{
		if (!type.HasClassFile)
			return;

		var filename = type.ClassPathOf(Path.Combine(libProjectDir, "Generated"));
		new FileInfo(filename).Directory?.Create();
		if (type.ClassFile.WriteToFileIfChanged(filename))
			Console.WriteLine($"        Generated class");
	}

	private static void GenerateGlmCode(string libProjectDir, AbstractType type)
	{
		if (!type.HasGlmFile)
			return;

		var filename = type.GlmPathOf(Path.Combine(libProjectDir, "Generated"));
		new FileInfo(filename).Directory?.Create();
		if (type.GlmFile.WriteToFileIfChanged(filename))
			Console.WriteLine($"        Generated glm");
	}

	private static void GenerateTestCode(string testProjectDir, AbstractType type)
	{
		if (!type.HasTestFile)
			return;

		var filename = type.TestPathOf(Path.Combine(testProjectDir, "Generated"));
		new FileInfo(filename).Directory?.Create();
		if (type.TestFile.WriteToFileIfChanged(filename))
			Console.WriteLine($"        Generated tests");
	}
}

file readonly record struct ManagedDirectoryInfo(string Name, string Dir, string File)
{
	public static ManagedDirectoryInfo CreateFromDir(string name, string dir, string fileExtension)
		=> new(name, dir, Path.Combine(dir, $"{name}.{fileExtension.TrimStart('.')}"));

	public static ManagedDirectoryInfo CreateFromParent(string name, string parent, string fileExtension)
		=> CreateFromDir(name, Path.Combine(parent, name), fileExtension);
}

file readonly record struct ManagedDirectories(ManagedDirectoryInfo Solution, ManagedDirectoryInfo Generator, ManagedDirectoryInfo Lib, ManagedDirectoryInfo Test)
{
	private const string SolutionFileExtension = "sln";
	private const string ProjectFileExtension = "csproj";

	public ManagedDirectories(string solutionDir, string solutionName, string libProjectName, string testProjectName, string generatorProjectName) : this(
		ManagedDirectoryInfo.CreateFromDir(solutionName, solutionDir, SolutionFileExtension),
		ManagedDirectoryInfo.CreateFromParent(generatorProjectName, solutionDir, ProjectFileExtension),
		ManagedDirectoryInfo.CreateFromParent(libProjectName, solutionDir, ProjectFileExtension),
		ManagedDirectoryInfo.CreateFromParent(testProjectName, solutionDir, ProjectFileExtension)
	)
	{ }

	public ManagedDirectories(string solutionName, string libProjectName, string testProjectName, string generatorProjectName) : this(
		Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.Parent!.FullName,
		solutionName, libProjectName, testProjectName, generatorProjectName
	)
	{ }
}
