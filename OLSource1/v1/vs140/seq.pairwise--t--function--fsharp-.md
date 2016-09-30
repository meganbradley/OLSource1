---
title: "Seq.pairwise&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.pairwise<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Pairwise``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "pairwise function [F#]"
  - "Seq.pairwise function [F#]"
ms.assetid: 210dcf26-4e24-4d83-af6d-a8288b2ae4b1
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.pairwise&lt;&#39;T&gt; Function (F#)
Returns a sequence of each element in the input sequence and its predecessor, with the exception of the first element which is only returned as the predecessor of the second element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.pairwise : seq<'T> -> seq<'T * 'T>  
  
// Usage:  
Seq.pairwise source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `Pairwise` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.pairwise`. The initial sequence is a sequence of squares up to 100. The `Seq.pairwise` function generates a sequence of tuples of consecutive squares, `{ (1, 4), (4, 9), (9, 16) ... }`. The second part of the example produces a list of the differences in each pair of squares.  
  
 [!code[FsSequences#18](../vs140/codesnippet/FSharp/seq.pairwise--t--function--fsharp-_1.fs)]  
  
 **(1, 4) (4, 9) (9, 16) (16, 25) (25, 36) (36, 49) (49, 64) (64, 81) (81, 100)**   
**3 5 7 9 11 13 15 17 19**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)