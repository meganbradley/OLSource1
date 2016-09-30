---
title: "Seq.take&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.take<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Take``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.take function [F#]"
  - "take function [F#]"
ms.assetid: 6e75f701-640b-4c4a-9d63-4313fc090596
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.take&lt;&#39;T&gt; Function (F#)
Returns the elements of the sequence up to a specified count.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.take : int -> seq<'T> -> seq<'T>  
  
// Usage:  
Seq.take count source  
```  
  
#### Parameters  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of items to take.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input sequence is empty.|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
|\<xref:System.InvalidOperationException*>|Thrown when count exceeds the number of elements in the sequence.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 [Seq.truncate](../vs140/seq.truncate--t--function--fsharp-.md) returns as many items as the sequence contains instead of throwing an exception.  
  
 This function is named `Take` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.take` and contrasts the behavior with `Seq.truncate`.  
  
 [!code[FsSequences#16](../vs140/codesnippet/FSharp/seq.take--t--function--fsharp-_1.fs)]  
  
 **1 4 9 16 25**   
**1 4 9 16 25 36 49 64 81 100**   
**1 4 9 16 25**   
**1 4 9 16 25 36 49 64 81 100**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)