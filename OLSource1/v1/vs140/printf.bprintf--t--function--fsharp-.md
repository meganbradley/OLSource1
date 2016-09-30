---
title: "Printf.bprintf&lt;&#39;T&gt; Function (F#)"
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
  - "Printf.bprintf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule.PrintFormatToStringBuilder``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Printf.PrintFormatToStringBuilder function [F#]"
  - "Printf.bprintf function [F#]"
  - "PrintFormatToStringBuilder function [F#]"
  - "bprintf function [F#]"
ms.assetid: 5448c060-a61d-4f3d-a9ec-e0cc998b4d87
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.bprintf&lt;&#39;T&gt; Function (F#)
Prints to a \<xref:System.Text.StringBuilder*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
bprintf : StringBuilder -> BuilderFormat<'T> -> 'T  
  
// Usage:  
bprintf builder format  
```  
  
#### Parameters  
 `builder`  
 Type: \<xref:System.Text.StringBuilder*>  
  
 The StringBuilder object to print to.  
  
 `format`  
 Type: [BuilderFormat](../vs140/printf.builderformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input formatter.  
  
## Return Value  
 The return type and arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatToStringBuilder` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)