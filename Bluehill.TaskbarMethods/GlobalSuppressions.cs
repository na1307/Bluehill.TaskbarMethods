// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "These are COM types", Scope = "namespaceanddescendants", Target = "~N:Bluehill.TaskbarMethods")]
[assembly: SuppressMessage("Minor Code Smell", "S3260:Non-derived \"private\" classes and records should be \"sealed\"", Justification = "This is COM type", Scope = "type", Target = "~T:Bluehill.TaskbarMethods.TaskbarMethods.TaskbarList")]
[assembly: SuppressMessage("Minor Code Smell", "S2344:Enumeration type names should not have \"Flags\" or \"Enum\" suffixes", Justification = "This is COM type", Scope = "type", Target = "~T:Bluehill.TaskbarMethods.THUMBBUTTONFLAGS")]
[assembly: SuppressMessage("Critical Code Smell", "S2346:Flags enumerations zero-value members should be named \"None\"", Justification = "This is COM type", Scope = "type", Target = "~T:Bluehill.TaskbarMethods.THUMBBUTTONFLAGS")]
