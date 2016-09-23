---
title: "Seq.forall2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - Seq.forall2<'T1,'T2>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.ForAll2``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Seq.forall2 function [F#]
  - forall2 function [F#]
ms.assetid: 4203c803-a7d7-42a1-a038-31a4590aa20b
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.forall2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Tests whether all the pairs of elements drawn from the two sequences satisfy the given predicate. If one sequence is shorter than the other then the remaining elements of the longer sequence are ignored.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.forall2 : ('T1 -> 'T2 -> bool) -> seq<'T1> -> seq<'T2> -> bool  
  
// Usage:  
Seq.forall2 predicate source1 source2  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T1 -> 'T2 ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test pairs of elements from the input sequences.  
  
 `source1`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T1>`  
  
 The first input sequence.  
  
 `source2`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T2>`  
  
 The second input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException?qualifyHint=False>|Thrown when either of the input sequences is null.|  
  
## Return Value  
 `true` if all element pairs in the sequences satisfy the given predicate. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `ForAll2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.forall2`.  
  
 [!code[FsSequences#40](../vs140/codesnippet/FSharp/seq.forall2--t1--t2--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **true**  
**false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)