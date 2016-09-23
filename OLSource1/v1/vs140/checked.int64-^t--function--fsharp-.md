---
title: "Checked.int64&lt;^T&gt; Function (F#)"
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
  - Checked.int64<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.Checked.ToInt64``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Checked.ToInt64 function [F#]
  - ToInt64 function [F#]
  - int64 function [F#]
  - Checked.int64 function [F#]
ms.assetid: ec10ef63-eb41-4fa6-a65c-0a07beec5656
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Checked.int64&lt;^T&gt; Function (F#)
Converts the argument to `int64`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int64.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
int64 : ^T -> int64 (requires ^T with static member op_Explicit)  
  
// Usage:  
int64 value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted int64  
  
## Remarks  
 This function is named `ToInt64` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Checked Module (F#)](../vs140/operators.checked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)