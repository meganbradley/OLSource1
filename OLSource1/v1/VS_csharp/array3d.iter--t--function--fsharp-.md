---
title: "Array3D.iter&lt;&#39;T&gt; Function (F#)"
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
  - "Array3D.iter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array3DModule.Iterate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array3D.iter function [F#]"
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "Array3D.Iterate function [F#]"
ms.assetid: 99b0ab25-8fe7-47a8-a193-6d0dd9b0b630
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array3D.iter&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array3D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array3D.iter : ('T -> unit) -> 'T [,,] -> unit  
  
// Usage:  
Array3D.iter action array  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->`[unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each element of the array.  
  
 `array`  
 Type: `'T`[&#91;,,&#93;](../VS_csharp/core.--t--type--fsharp-3.md)  
  
 The input array.  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array3D Module (F#)](../VS_csharp/collections.array3d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)