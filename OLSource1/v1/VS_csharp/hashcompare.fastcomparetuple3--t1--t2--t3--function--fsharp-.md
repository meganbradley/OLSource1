---
title: "HashCompare.FastCompareTuple3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastCompareTuple3``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FastCompareTuple3 function [F#]"
ms.assetid: 9b068b6d-7d33-42ed-bc41-19af8c5c66c4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.FastCompareTuple3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastCompareTuple3 : IComparer -> 'T1 * 'T2 * 'T3 -> 'T1 * 'T2 * 'T3 -> int  
  
// Usage:  
FastCompareTuple3 comparer tuple1 tuple2  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IComparer*>  
  
 The comparer object.  
  
 `tuple1`  
 Type: `'T1 * 'T2 * 'T3`  
  
 The first tuple of three elements.  
  
 `tuple2`  
 Type: `'T1 * 'T2 * 'T3`  
  
 The second tuple of three elements.  
  
## Return Value  
 The result of the comparison.  
  
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