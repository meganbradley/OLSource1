---
title: "Printf.printf&lt;&#39;T&gt; Function (F#)"
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
  - "Printf.printf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule.PrintFormat``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PrintFormat function [F#]"
  - "printf function [F#]"
  - "Printf.printf function [F#]"
  - "Printf.PrintFormat function [F#]"
ms.assetid: f21a2219-5d06-4211-82a3-c4538fc47f34
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.printf&lt;&#39;T&gt; Function (F#)
Prints formatted output to `stdout`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
printf : TextWriterFormat<'T> -> 'T  
  
// Usage:  
printf format  
```  
  
#### Parameters  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input formatter.  
  
## Return Value  
 The return type and arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormat` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)