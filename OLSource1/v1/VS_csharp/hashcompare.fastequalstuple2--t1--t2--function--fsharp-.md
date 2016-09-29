---
title: "HashCompare.FastEqualsTuple2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastEqualsTuple2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FastEqualsTuple2 function [F#]"
ms.assetid: 8cdc7ce1-67be-47c1-acef-da0ac3d99953
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.FastEqualsTuple2&lt;&#39;T1,&#39;T2&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastEqualsTuple2 : IEqualityComparer -> 'T1 * 'T2 -> 'T1 * 'T2 -> bool  
  
// Usage:  
FastEqualsTuple2 comparer tuple1 tuple2  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IEqualityComparer*>  
  
 The comparer object.  
  
 `tuple1`  
 Type: `'T1 * 'T2`  
  
 The first tuple of two elements.  
  
 `tuple2`  
 Type: `'T1 * 'T2`  
  
 The second tuple of two elements.  
  
## Return Value  
 `true` if the tuples are equal; otherwise, `false`.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.HashCompare Module (F#)](../VS_csharp/languageprimitives.hashcompare-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../VS_csharp/core.languageprimitives-module--fsharp-.md)