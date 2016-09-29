---
title: "Seq.forall&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.forall<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.ForAll``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "forall function [F#]"
  - "Seq.forall function [F#]"
ms.assetid: e1717ebd-a163-42ad-8df5-959fcf1839b1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.forall&lt;&#39;T&gt; Function (F#)
Tests if all elements of the sequence satisfy the given predicate.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.forall : ('T -> bool) -> seq<'T> -> bool  
  
// Usage:  
Seq.forall predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->` [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test an element of the input sequence.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The predicate is applied to the elements of the input sequence. If any application returns `false` then the overall result is `false` and no further elements are tested. Otherwise, returns `true`.  
  
## Remarks  
 This function is named `ForAll` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.forall`.  
  
 [!code[FsSequences#39](../vs140/codesnippet/FSharp/seq.forall--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **false**  
**true**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)