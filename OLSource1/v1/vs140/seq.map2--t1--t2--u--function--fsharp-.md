---
title: "Seq.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - "Seq.map2<'T1,'T2,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Map2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map2 function [F#]"
  - "Seq.map2 function [F#]"
ms.assetid: dbf63b7f-cb4a-4c00-b2b7-f539205a365e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to the corresponding pairs of elements from the two sequences. If one input sequence is shorter than the other then the remaining elements of the longer sequence are ignored.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.map2 : ('T1 -> 'T2 -> 'U) -> seq<'T1> -> seq<'T2> -> seq<'U>  
  
// Usage:  
Seq.map2 mapping source1 source2  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T1 -> 'T2 -> 'U`  
  
 A function to transform pairs of items from the input sequences.  
  
 `source1`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T1>`  
  
 The first input sequence.  
  
 `source2`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T2>`  
  
 The second input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when either of the input sequences is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `Map2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)