---
title: "Printf.fprintfn&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Printf.fprintfn<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule.PrintFormatLineToTextWriter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Printf.fprintfn function [F#]"
  - "Printf.PrintFormatLineToTextWriter function [F#]"
  - "PrintFormatLineToTextWriter function [F#]"
  - "fprintfn function [F#]"
ms.assetid: f927a4fa-122c-4547-a87d-6dca9197c4e3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.fprintfn&lt;&#39;T&gt; Function (F#)
Prints to a text writer, adding a newline.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
fprintfn : TextWriter -> TextWriterFormat<'T> -> 'T  
  
// Usage:  
fprintfn textWriter format  
```  
  
#### Parameters  
 `textWriter`  
 Type: <xref:System.IO.TextWriter*>  
  
 The <xref:System.IO.TextWriter*> instance to print to.  
  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input formatter.  
  
## Return Value  
 The return type and arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatLineToTextWriter` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)