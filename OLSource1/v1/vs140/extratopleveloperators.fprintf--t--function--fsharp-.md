---
title: "ExtraTopLevelOperators.fprintf&lt;&#39;T&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.fprintf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatToTextWriter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "fprintf function [F#]"
  - "PrintFormatToTextWriter function [F#]"
  - "ExtraTopLevelOperators.fprintf function [F#]"
  - "ExtraTopLevelOperators.PrintFormatToTextWriter function [F#]"
ms.assetid: b6db8c01-2bcc-44ea-8aec-a7c5da114200
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.fprintf&lt;&#39;T&gt; Function (F#)
The fprintf functions prints to a file using the given format.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
fprintf : TextWriter -> TextWriterFormat<'T> -> 'T  
  
// Usage:  
fprintf textWriter format  
```  
  
#### Parameters  
 `textWriter`  
 Type: <xref:System.IO.TextWriter*>  
  
 `format`  
 Type: [TextWriterFormat](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
## Return Value  
  
## Remarks  
 This function is named `PrintFormatToTextWriter` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `fprintf`.  
  
 [!code[FsCoreLib2#7](../vs140/codesnippet/FSharp/extratopleveloperators.fprintf--t--function--fsharp-_1.fs)]  
  
 The resulting file `1to100.txt` contains the following data.  
  
 **1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)