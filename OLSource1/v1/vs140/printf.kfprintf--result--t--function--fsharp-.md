---
title: "Printf.kfprintf&lt;&#39;Result,&#39;T&gt; Function (F#)"
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
  - Printf.kfprintf<'Result,'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.PrintfModule.PrintFormatToTextWriterThen``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - PrintFormatToTextWriterThen function [F#]
  - Printf.kfprintf function [F#]
  - kfprintf function [F#]
  - Printf.PrintFormatToTextWriterThen function [F#]
ms.assetid: 3aeb13e7-7a4d-4bd3-8265-b9350c7a2610
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Printf.kfprintf&lt;&#39;Result,&#39;T&gt; Function (F#)
Like [fprintf](../vs140/printf.fprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
kfprintf : (unit -> 'Result) -> TextWriter -> TextWriterFormat<'T,'Result> -> 'T  
  
// Usage:  
kfprintf continutation textWriter format  
```  
  
#### Parameters  
 `continutation`  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) `-> 'Result`  
  
 The function called after formatting to generate the format result.  
  
 `textWriter`  
 Type: <xref:System.IO.TextWriter?qualifyHint=False>  
  
 The <xref:System.IO.TextWriter?qualifyHint=False> instance that receives the output.  
  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--result--type-abbreviation--fsharp-.md)`<'T,'Result>`  
  
 The input formatter.  
  
## Return Value  
 The arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatToTextWriterThen` in the compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)