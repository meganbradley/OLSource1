---
title: "Seq.cache&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.cache<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Cache``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "cache function [F#]"
  - "Seq.cache function [F#]"
ms.assetid: d197f9cc-08bf-4986-9869-246e72ca73f0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.cache&lt;&#39;T&gt; Function (F#)
Returns a sequence that corresponds to a cached version of the input sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.cache : seq<'T> -> seq<'T>  
  
// Usage:  
Seq.cache source  
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
 This result sequence will have the same elements as the input sequence. The result can be enumerated multiple times. The input sequence is enumerated at most once and only as far as is necessary. Caching a sequence is typically useful when repeatedly evaluating items in the original sequence is computationally expensive or if iterating the sequence causes side-effects that the user does not want to be repeated multiple times. Once enumeration of the input sequence has started, its enumerator will be kept active by this object until the enumeration has completed. At that point, the enumerator will be disposed. The enumerator may be disposed and underlying cache storage released by converting the returned sequence object to type \<xref:System.IDisposable*>, and calling the `Dispose` method on this object. The sequence object may then be re-enumerated and a fresh enumerator will be used.  
  
 This function is named `Cache` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates how to use `Seq.cache` to avoid recomputing elements of a sequence.  
  
 [!code[FsSequences#27](../vs140/codesnippet/FSharp/seq.cache--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **9973 is prime.**  
**9967 is prime.**  
**9949 is prime.**  
**9941 is prime.**  
**9931 is prime.**   
## Thread Safety  
 Enumeration of the result sequence is thread-safe in the sense that multiple independent `IEnumerator` values may be used simultaneously from different threads (accesses to the internal lookaside table are thread-safe). Each individual `IEnumerator` is not typically thread-safe and should not be accessed concurrently.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)