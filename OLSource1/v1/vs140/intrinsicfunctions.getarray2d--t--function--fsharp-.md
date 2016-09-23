---
title: "IntrinsicFunctions.GetArray2D&lt;&#39;T&gt; Function (F#)"
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
  - IntrinsicFunctions.GetArray2D<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.GetArray2D``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - GetArray2D function [F#]
  - IntrinsicFunctions.GetArray2D function [F#]
ms.assetid: b9240f85-84b4-4586-8da6-ac9251528416
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IntrinsicFunctions.GetArray2D&lt;&#39;T&gt; Function (F#)
The standard overloaded associative (2-indexed) lookup operator  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GetArray2D : 'T [,] -> int -> int -> 'T  
  
// Usage:  
GetArray2D source index1 index2  
```  
  
#### Parameters  
 `source`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The source array.  
  
 `index1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The first index.  
  
 `index2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The second index.  
  
## Return Value  
 The value at the specified indices.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicFunctions Module (F#)](../vs140/languageprimitives.intrinsicfunctions-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)