---
title: "IntrinsicFunctions.SetArray3D&lt;&#39;T&gt; Function (F#)"
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
  - IntrinsicFunctions.SetArray3D<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.SetArray3D``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IntrinsicFunctions.SetArray3D function [F#]
  - SetArray3D function [F#]
ms.assetid: bc3cc1f1-9a89-4d85-aa42-ab7d1a8b0aed
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IntrinsicFunctions.SetArray3D&lt;&#39;T&gt; Function (F#)
The standard overloaded associative (3-indexed) mutation operator  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
SetArray3D : 'T [,,] -> int -> int -> int -> 'T -> unit  
  
// Usage:  
SetArray3D target index1 index2 index3 value  
```  
  
#### Parameters  
 `target`  
 Type: `'T` [&#91;,,&#93;](../vs140/core.--t--type--fsharp-3.md)  
  
 A three-dimensional array.  
  
 `index1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index along the first dimension.  
  
 `index2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index along the second dimension.  
  
 `index3`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index along the third dimension.  
  
 `value`  
 Type: `'T`  
  
 The new value to set at the specified indices.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicFunctions Module (F#)](../vs140/languageprimitives.intrinsicfunctions-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)