---
title: "HashCompare.FastEqualsTuple4&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastEqualsTuple4``4"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FastEqualsTuple4 function [F#]"
ms.assetid: c6873746-dfa0-4283-83c9-78a19fbcdeae
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.FastEqualsTuple4&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastEqualsTuple4 : IEqualityComparer -> 'T1 * 'T2 * 'T3 * 'T4 -> 'T1 * 'T2 * 'T3 * 'T4 -> bool  
  
// Usage:  
FastEqualsTuple4 comparer tuple1 tuple2  
```  
  
#### Parameters  
 `comparer`  
 Type: \<xref:System.Collections.IEqualityComparer*>  
  
 The comparer object.  
  
 `tuple1`  
 Type: `'T1 * 'T2 * 'T3 * 'T4`  
  
 The first tuple of four elements.  
  
 `tuple2`  
 Type: `'T1 * 'T2 * 'T3 * 'T4`  
  
 The second tuple of four elements.  
  
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
 [LanguagePrimitives.HashCompare Module (F#)](../vs140/languageprimitives.hashcompare-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)