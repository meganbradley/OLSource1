---
title: "Operators.atan2&lt;^T1,&#39;T2&gt; Function (F#)"
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
  - Operators.atan2<^T1,'T2>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.Atan2``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators.atan2 function [F#]
  - atan2 function [F#]
ms.assetid: 799c1100-8969-4126-bcb0-ce0153572f18
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.atan2&lt;^T1,&#39;T2&gt; Function (F#)
Inverse tangent of `x/y` where `x` and `y` are specified separately.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
atan2 : ^T1 -> ^T1 -> 'T2 (requires ^T1 with static member Atan2)  
  
// Usage:  
atan2 y x  
```  
  
#### Parameters  
 `y`  
 Type: `^T1`  
  
 The y input value.  
  
 `x`  
 Type: `^T1`  
  
 The x input value.  
  
## Return Value  
 The inverse tangent of the input ratio.  
  
## Remarks  
 This function is named `Atan2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)