---
title: "Array2D.copy&lt;&#39;T&gt; Function (F#)"
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
  - Array2D.copy<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.Array2DModule.Copy``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Array2D.copy function [F#]
  - copy function [F#]
ms.assetid: 369872d9-90ef-4a18-b389-ceda283e07ae
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array2D.copy&lt;&#39;T&gt; Function (F#)
Creates a new array whose elements are the same as the input array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array2D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.copy : 'T [,] -> 'T [,]  
  
// Usage:  
Array2D.copy array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The input array.  
  
## Return Value  
 A copy of the input array.  
  
## Remarks  
 For non-zero-based arrays the basing on an input array will be propagated to the output array.  
  
 This function is named `Copy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)