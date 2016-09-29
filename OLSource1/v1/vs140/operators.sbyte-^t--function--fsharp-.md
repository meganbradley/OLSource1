---
title: "Operators.sbyte&lt;^T&gt; Function (F#)"
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
  - "Operators.sbyte<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.ToSByte``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ToSByte function [F#]"
  - "Operators.ToSByte function [F#]"
  - "sbyte function [F#]"
  - "Operators.sbyte function [F#]"
ms.assetid: b7ee5eae-c41c-4a8e-9228-cce76811363c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.sbyte&lt;^T&gt; Function (F#)
Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.SByte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
sbyte : ^T -> sbyte (requires ^T with static member op_Explicit)  
  
// Usage:  
sbyte value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted `sbyte`.  
  
## Remarks  
 This function is named `ToSByte` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)