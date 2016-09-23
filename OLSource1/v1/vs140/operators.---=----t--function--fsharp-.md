---
title: "Operators.( := )&lt;&#39;T&gt; Function (F#)"
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
  - Operators.( := )<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.op_ColonEquals``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators.op_ColonEquals operator [F#]
  - op_ColonEquals operator [F#]
  - := operator [F#]
  - Operators.( := ) operator [F#]
ms.assetid: 34a4ab7c-643b-4720-976a-cb56a9db9844
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.( := )&lt;&#39;T&gt; Function (F#)
Assign to a mutable reference cell.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( := ) : 'T ref -> 'T -> unit  
  
// Usage:  
cell := value  
```  
  
#### Parameters  
 `cell`  
 Type: `'T ref`  
  
 The cell to mutate.  
  
 `value`  
 Type: `'T`  
  
 The value to set inside the cell.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)