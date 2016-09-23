---
title: "Checked.nativeint&lt;^T&gt; Function (F#)"
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
  - Checked.nativeint<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.Checked.ToIntPtr``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Checked.nativeint function [F#]
  - nativeint function [F#]
  - Checked.ToIntPtr function [F#]
  - ToIntPtr function [F#]
ms.assetid: 876c5aa7-683f-4912-a799-161732109c4f
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Checked.nativeint&lt;^T&gt; Function (F#)
Converts the argument to `nativeint`. This is a direct, checked conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
nativeint : ^T -> nativeint (requires ^T with static member op_Explicit)  
  
// Usage:  
nativeint value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted `nativeint`.  
  
## Remarks  
 This function is named `ToIntPtr` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Checked Module (F#)](../vs140/operators.checked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)