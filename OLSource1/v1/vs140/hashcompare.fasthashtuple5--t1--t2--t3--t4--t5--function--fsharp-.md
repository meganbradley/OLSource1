---
title: "HashCompare.FastHashTuple5&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastHashTuple5``5"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FastHashTuple5 function [F#]"
ms.assetid: d51768b1-ac08-492d-ba6d-6126fa524f83
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.FastHashTuple5&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastHashTuple5 : IEqualityComparer -> 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> int  
  
// Usage:  
FastHashTuple5 comparer tuple  
```  
  
#### Parameters  
 `comparer`  
 Type: \<xref:System.Collections.IEqualityComparer*>  
  
 A comparer object.  
  
 `tuple`  
 Type: `'T1 * 'T2 * 'T3 * 'T4 * 'T5`  
  
 A tuple of five elements.  
  
## Return Value  
 The computed hash.  
  
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