---
title: "Operators.string&lt;^T&gt; Function (F#)"
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
  - "Operators.string<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.ToString``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "string function [F#]"
  - "Operators.ToString function [F#]"
  - "Operators.string function [F#]"
  - "ToString function [F#]"
ms.assetid: fb1e8767-fa72-4bf4-8737-7fea355d55b0
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.string&lt;^T&gt; Function (F#)
Converts the argument to a string using <xref:System.Object.ToString*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
string : ^T -> string  
  
// Usage:  
string value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted string.  
  
## Remarks  
 For standard integer and floating point values the <xref:System.Object.ToString*> conversion uses <xref:System.Globalization.CultureInfo.InvariantCulture*>.  
  
 This function is named `ToString` in compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)