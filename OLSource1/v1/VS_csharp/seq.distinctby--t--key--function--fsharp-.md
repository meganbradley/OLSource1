---
title: "Seq.distinctBy&lt;&#39;T,&#39;Key&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Seq.distinctBy<'T,'Key>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.DistinctBy``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.distinctBy function [F#]"
  - "distinctBy function [F#]"
ms.assetid: 9293293b-9420-49c8-848f-401a9cd49b75
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.distinctBy&lt;&#39;T,&#39;Key&gt; Function (F#)
Returns a sequence that contains no duplicate entries according to the generic hash and equality comparisons on the keys returned by the given key-generating function. If an element occurs multiple times in the sequence then the later occurrences are discarded.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.distinctBy : ('T -> 'Key) -> seq<'T> -> seq<'T> (requires equality)  
  
// Usage:  
Seq.distinctBy projection source  
```  
  
#### Parameters  
 `projection`  
 Type: `'T -> 'Key`  
  
 A function that transforms the sequence items into comparable keys.  
  
 `source`  
 Type: [seq](../VS_csharp/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `DistinctBy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of Seq.distinctBy to keep only the elements in a sequence that have a distinct absolute value. The first element with a given result is retained in the new sequence, so the positive numbers from 1 to 5 are dropped in the sequence from -5 to +10.  
  
 [!code[FsSequences#23](../VS_csharp/codesnippet/FSharp/seq.distinctby--t--key--function--fsharp-_1.fs)]  
  
 **Original sequence:**   
**-5 -4 -3 -2 -1 0 1 2 3 4 5 6 7 8 9 10**   
**Sequence with distinct absolute values:**   
**-5 -4 -3 -2 -1 0 6 7 8 9 10**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../VS_csharp/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)