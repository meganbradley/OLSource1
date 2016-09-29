---
title: "ExtraTopLevelOperators.eprintfn&lt;&#39;T&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.eprintfn<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatLineToError``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PrintFormatLineToError function [F#]"
  - "ExtraTopLevelOperators.eprintfn function [F#]"
  - "eprintfn function [F#]"
  - "ExtraTopLevelOperators.PrintFormatLineToError function [F#]"
ms.assetid: d3ba61e2-22b0-4170-a753-6e1a736e91bb
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.eprintfn&lt;&#39;T&gt; Function (F#)
Print to `stderr` using the given format, and add a newline.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
eprintfn : TextWriterFormat<'T> -> 'T  
  
// Usage:  
eprintfn format  
```  
  
#### Parameters  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
## Return Value  
  
## Remarks  
 This function is named `PrintFormatLineToError` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `eprintfn`.  
  
 [!code[FsCoreLib2#3](../vs140/codesnippet/FSharp/extratopleveloperators.eprintfn--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Success!**  
**Error: the input 11 exceeds the maximum value 10.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)