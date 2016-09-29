---
title: "Printf.kbprintf&lt;&#39;Result,&#39;T&gt; Function (F#)"
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
  - "Printf.kbprintf<'Result,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule.PrintFormatToStringBuilderThen``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Printf.PrintFormatToStringBuilderThen function [F#]"
  - "kbprintf function [F#]"
  - "Printf.kbprintf function [F#]"
  - "PrintFormatToStringBuilderThen function [F#]"
ms.assetid: c7e58e8a-9038-4922-9624-8fa2f9f590fd
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.kbprintf&lt;&#39;Result,&#39;T&gt; Function (F#)
Like [bprintf](../VS_csharp/printf.bprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../VS_csharp/printf.kprintf--result--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
kbprintf : (unit -> 'Result) -> StringBuilder -> BuilderFormat<'T,'Result> -> 'T  
  
// Usage:  
kbprintf continutation builder format  
```  
  
#### Parameters  
 `continutation`  
 Type: [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md) `-> 'Result`  
  
 The function called after formatting to generate the format result.  
  
 `builder`  
 Type: <xref:System.Text.StringBuilder*>  
  
 The input StringBuilder.  
  
 `format`  
 Type: [BuilderFormat](../VS_csharp/printf.builderformat--t--result--type-abbreviation--fsharp-.md)`<'T,'Result>`  
  
 The input formatter.  
  
## Return Value  
 The arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatToStringBuilderThen` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../VS_csharp/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)