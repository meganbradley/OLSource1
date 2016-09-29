---
title: "Seq.where&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.SeqModule.Where``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "where function [F#]"
ms.assetid: e6b5bf50-4716-423c-98fe-f77d03bb6f7f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.where&lt;&#39;T&gt; Function (F#)
Returns a new collection containing only the elements of the collection for which the given predicate returns `true`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:where : ('T -> bool) -> seq<'T> -> seq<'T>// Usage:Seq.where predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: 'T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test whether each item in the input sequence should be included in the output.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<'T>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The returned sequence may be passed between threads safely. However, individual <xref:System.Collections.Generic.IEnumerator`1*> values generated from the returned sequence should not be accessed concurrently. Remember that sequence is subject to lazy evaluation, which means that effects are delayed until it is enumerated. This function is a synonym for [Seq.filter](../vs140/seq.filter--t--function--fsharp-.md).  
  
 This function is named `Where` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
 .0  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)   
 [Seq.filter<'T> Function (F#)](../vs140/seq.filter--t--function--fsharp-.md)