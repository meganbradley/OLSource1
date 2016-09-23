---
title: "Printf.printfn&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Printf.printfn<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.PrintfModule.PrintFormatLine``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - printfn function [F#]
  - PrintFormatLine function [F#]
  - Printf.printfn function [F#]
  - Printf.PrintFormatLine function [F#]
ms.assetid: ec1e8178-0caa-453c-9bdd-e48519401e0d
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Printf.printfn&lt;&#39;T&gt; Function (F#)
Prints formatted output to `stdout`, adding a newline.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
printfn : TextWriterFormat<'T> -> 'T  
  
// Usage:  
printfn format  
```  
  
#### Parameters  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input formatter.  
  
## Return Value  
 The return type and arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatLine` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)