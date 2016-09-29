---
title: "Seq.concat&lt;&#39;Collection,&#39;T&gt; Function (F#)"
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
  - "Seq.concat<'Collection,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Concat``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.concat function [F#]"
  - "concat function [F#]"
ms.assetid: 2eeb69a9-fc2f-4b7d-8dee-101fa2b00712
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.concat&lt;&#39;Collection,&#39;T&gt; Function (F#)
Combines the given enumeration-of-enumerations as a single concatenated enumeration.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.concat : seq<'Collection> -> seq<'T> (requires 'Collection :> seq<'T>)  
  
// Usage:  
Seq.concat sources  
```  
  
#### Parameters  
 `sources`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'Collection>`  
  
 The input enumeration-of-enumerations.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The returned sequence may be passed between threads safely. However, individual `IEnumerator` values generated from the returned sequence should not be accessed concurrently.  
  
 This function is named `Concat` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.concat`.  
  
 [!code[FsSequences#29](../vs140/codesnippet/FSharp/seq.concat--collection--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1 2 3 4 5 6 7 8 9 10 1 2 3 4 5 6 7 8 9**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)