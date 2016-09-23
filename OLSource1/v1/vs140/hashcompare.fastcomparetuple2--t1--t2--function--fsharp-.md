---
title: "HashCompare.FastCompareTuple2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastCompareTuple2``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FastCompareTuple2 function [F#]
ms.assetid: 45783d16-7fef-4128-b03b-6f3034a9e079
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HashCompare.FastCompareTuple2&lt;&#39;T1,&#39;T2&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastCompareTuple2 : IComparer -> 'T1 * 'T2 -> 'T1 * 'T2 -> int  
  
// Usage:  
FastCompareTuple2 comparer tuple1 tuple2  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IComparer?qualifyHint=False>  
  
 The comparer object.  
  
 `tuple1`  
 Type: `'T1 * 'T2`  
  
 The first tuple of two elements.  
  
 `tuple2`  
 Type: `'T1 * 'T2`  
  
 The second tuple of two elements.  
  
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
 [LanguagePrimitives.HashCompare Module (F#)](../vs140/languageprimitives.hashcompare-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)