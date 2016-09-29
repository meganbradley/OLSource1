---
title: "Seq.skipWhile&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.skipWhile<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.SkipWhile``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "skipWhile function [F#]"
  - "Seq.skipWhile function [F#]"
ms.assetid: fb729021-2a3c-430f-83c3-0b37526f1a16
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.skipWhile&lt;&#39;T&gt; Function (F#)
Returns a sequence that, when iterated, skips elements of the underlying sequence while the given predicate returns `true`, and then yields the remaining elements of the sequence.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.skipWhile : ('T -> bool) -> seq<'T> -> seq<'T>  
  
// Usage:  
Seq.skipWhile predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that evaluates an element of the sequence to a Boolean value.  
  
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
 This function is named `SkipWhile` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.skipWhile`. The resulting sequences contains only elements that are greater than 10.  
  
 [!code[FsSequences#172](../VS_csharp/codesnippet/FSharp/seq.skipwhile--t--function--fsharp-_1.fs)]  
  
 **16 25 36 49 64 81 100**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../VS_csharp/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)