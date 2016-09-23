---
title: "Operators.incr Function (F#)"
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
  - Operators.incr
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.Increment
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Increment function [F#]
  - incr function [F#]
  - Operators.Increment function [F#]
  - Operators.incr function [F#]
ms.assetid: 86692cc2-d36c-4e97-a551-f05e39d80a98
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.incr Function (F#)
Increment a mutable reference cell containing an integer.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
incr : int ref -> unit  
  
// Usage:  
incr cell  
```  
  
#### Parameters  
 `cell`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `ref`  
  
 The reference cell.  
  
## Remarks  
 This function is named `Increment` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)