---
title: "Seq.takeWhile&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.takeWhile<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.TakeWhile``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "takeWhile function [F#]"
  - "Seq.takeWhile function [F#]"
ms.assetid: 19eea4ce-66e0-4353-b015-72eb03421d92
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.takeWhile&lt;&#39;T&gt; Function (F#)
Returns a sequence that, when iterated, yields elements of the underlying sequence while the given predicate returns `true`, and then returns no further elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.takeWhile : ('T -> bool) -> seq<'T> -> seq<'T>  
  
// Usage:  
Seq.takeWhile predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that evaluates to `false` when no more items should be returned.  
  
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
 This function is named `TakeWhile` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.takeWhile`. The sequence contains squares of integers that are less than 10.  
  
 [!code[FsSequences#170](../VS_csharp/codesnippet/FSharp/seq.takewhile--t--function--fsharp-_1.fs)]  
  
 **1 4 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../VS_csharp/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)