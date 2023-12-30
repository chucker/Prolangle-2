﻿using Prolangle.Languages;
using Prolangle.Languages.Framework;

namespace Prolangle.Services;

public class LanguagesProvider
{
	private readonly Lazy<IReadOnlyList<ILanguage>> languages = new(() => LanguageEnumerable.ToList());

	public IReadOnlyList<ILanguage> Languages => languages.Value;

	private static IEnumerable<ILanguage> LanguageEnumerable
	{
		get
		{
			yield return new Cpp();
			yield return new CSharp();
			yield return new Java();
			yield return new Step();
		}
	}
}