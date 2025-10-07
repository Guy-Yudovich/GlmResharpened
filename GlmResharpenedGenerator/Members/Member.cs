﻿using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members;

internal abstract class Member
{
	/// <summary>
	/// Original type ref
	/// </summary>
	public required AbstractType OriginalType { get; set; }

	/// <summary>
	/// Name of the member
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Comment of the member
	/// </summary>
	public required string Comment { get; set; }

	/// <summary>
	/// Visibility modifier
	/// </summary>
	public string Visibility { get; set; } = "public";

	/// <summary>
	/// True iff member is static
	/// </summary>
	public bool Static { get; set; }

	/// <summary>
	/// Attributes of this member
	/// </summary>
	public string[] Attributes { get; set; } = new string[] { };

	/// <summary>
	/// All lines of this member
	/// </summary>
	public virtual IEnumerable<string> Lines
	{
		get
		{
			foreach (var line in Comment.AsComment())
				yield return line;
			foreach (var attribute in Attributes)
				yield return $"[{attribute}]";
		}
	}

	/// <summary>
	/// Prefix for members (visibility, static)
	/// </summary>
	public virtual string MemberPrefix => Visibility + (Static ? " static" : "");

	/// <summary>
	/// Returns an enumeration of members used for the "glm" class
	/// </summary>
	public virtual IEnumerable<Member> GlmMembers() { yield break; }
}
