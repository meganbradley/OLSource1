---
title: "Seq.groupBy&lt;&#39;T,&#39;Key&gt; Function (F#)"
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
  - Seq.groupBy<'T,'Key>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.GroupBy``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - groupBy function [F#]
  - Seq.groupBy function [F#]
ms.assetid: d46a04df-1a42-40cc-a368-058c9c5806fd
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.groupBy&lt;&#39;T,&#39;Key&gt; Function (F#)
Applies a key-generating function to each element of a sequence and yields a sequence of unique keys and a sequence of all elements that have each key.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.groupBy : ('T -> 'Key) -> seq<'T> -> seq<'Key * seq<'T>> (requires equality)  
  
// Usage:  
Seq.groupBy projection source  
```  
  
#### Parameters  
 `projection`  
 Type: `'T -> 'Key`  
  
 A function that transforms an element of the sequence into a comparable key.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Return Value  
 A sequence of tuples where each tuple contains the unique key and a sequence of all the elements that match the key.  
  
## Remarks  
 This function returns a sequence that traverses the whole initial sequence as soon as that sequence is iterated. As a result this function should not be used with large or infinite sequences. The function makes no assumption on the ordering of the original sequence.  
  
 This function is named `GroupBy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.groupBy` to group the odd and even numbers in a sequence into two separate sequences.  
  
 [!code[FsSequences#21](../vs140/codesnippet/FSharp/seq.groupby--t--key--function--fsharp-_1.fs)]
  
  
 **(1, seq [1; 3; 5; 7; ...]) (0, seq [2; 4; 6; 8; ...])**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)