---
title: "HashCompare.FastCompareTuple5&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Function (F#)"
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
  - Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastCompareTuple5``5
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FastCompareTuple5 function [F#]
ms.assetid: 1d4da33f-234c-45db-b0a0-26efc0a690ac
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HashCompare.FastCompareTuple5&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastCompareTuple5 : IComparer -> 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> int  
  
// Usage:  
FastCompareTuple5 comparer tuple1 tuple2  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IComparer?qualifyHint=False>  
  
 The comparer object.  
  
 `tuple1`  
 Type: `'T1 * 'T2 * 'T3 * 'T4 * 'T5`  
  
 The first tuple of five elements.  
  
 `tuple2`  
 Type: `'T1 * 'T2 * 'T3 * 'T4 * 'T5`  
  
 The second tuple of five elements.  
  
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