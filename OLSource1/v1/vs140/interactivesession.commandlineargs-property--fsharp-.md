---
title: "InteractiveSession.CommandLineArgs Property (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "Microsoft.FSharp.Compiler.Interactive.InteractiveSession.CommandLineArgs"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CommandLineArgs property [F#]"
  - "InteractiveSession.CommandLineArgs property [F#]"
ms.assetid: a20e0de2-2969-4223-af6b-0fdeb614e448
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InteractiveSession.CommandLineArgs Property (F#)
The command line arguments after ignoring the arguments relevant to the interactive environment and replacing the first argument with the name of the last script file, if any.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive  
  
 **Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.CommandLineArgs :  string []  
member this.CommandLineArgs : string [] with set :  string []  
  
// Usage:  
interactiveSession.CommandLineArgs  
interactiveSession.CommandLineArgs <- commandLineArgs  
```  
  
#### Parameters  
 commandLineArgs  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)[](../vs140/core.string-type-abbreviation--fsharp-.md "Core.string Type Abbreviation (F#)")[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The array of command line arguments.  
  
## Return Value  
  
## Remarks  
 For example, the command line `fsi.exe test1.fs test2.fs -- hello goodbye` will give arguments `test2.fs`, `hello`, `goodbye`. This value will normally be different to those returned by <xref:System.Environment.GetCommandLineArgs*>.  
  
## Platforms  
 Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2  
  
## Version Information  
 **F# Runtime**  
  
 Supported in: 2.0, 4  
  
 **Silverlight**  
  
 Supported in: 3  
  
## See Also  
 [Interactive.InteractiveSession Class (F#)](../vs140/interactive.interactivesession-class--fsharp-.md)   
 [Microsoft.FSharp.Compiler.Interactive Namespace (F#)](../vs140/microsoft.fsharp.compiler.interactive-namespace--fsharp-.md)