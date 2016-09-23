---
title: "Array2D.iter&lt;&#39;T&gt; Function (F#)"
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
  - Array2D.iter<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.Array2DModule.Iterate``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Array2D.Iterate function [F#]
  - Iterate function [F#]
  - Array2D.iter function [F#]
  - iter function [F#]
ms.assetid: 212385f9-a8f2-4301-ae64-a8f312be12ee
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array2D.iter&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array2D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.iter : ('T -> unit) -> 'T [,] -> unit  
  
// Usage:  
Array2D.iter action array  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to apply to each element of the array.  
  
 `array`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The input array.  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)