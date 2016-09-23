---
title: "Operators.decimal&lt;^T&gt; Function (F#)"
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
  - Operators.decimal<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.ToDecimal``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - ToDecimal function [F#]
  - Operators.ToDecimal function [F#]
  - decimal function [F#]
  - Operators.decimal function [F#]
ms.assetid: cfdcb2aa-9a7e-480a-8d8b-2155f9a50f95
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.decimal&lt;^T&gt; Function (F#)
Converts the argument to <xref:System.Decimal?qualifyHint=False> using a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
decimal : ^T -> decimal (requires ^T with static member op_Explicit)  
  
// Usage:  
decimal value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted decimal.  
  
## Remarks  
 This function is named `ToDecimal` in the assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)