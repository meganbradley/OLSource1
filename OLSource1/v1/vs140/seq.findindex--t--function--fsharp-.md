---
title: "Seq.findIndex&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.findIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.FindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "findIndex function [F#]"
  - "Seq.findIndex function [F#]"
ms.assetid: 96dfe86b-df15-4d92-8316-7cd6055e09f3
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.findIndex&lt;&#39;T&gt; Function (F#)
Returns the index of the first element for which the given function returns `true`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.findIndex : ('T -> bool) -> seq<'T> -> int  
  
// Usage:  
Seq.findIndex predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test whether the index of a particular element should be returned.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null|  
|<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if no element returns true when evaluated by the predicate|  
  
## Return Value  
 The index of the first element for which the given function returns `true`.  
  
## Remarks  
 This function is named `FindIndex` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `Seq.findIndex`.  
  
 [!code[FsSequences#37](../vs140/codesnippet/FSharp/seq.findindex--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The first element that is both a square and a cube is 64 and its index is 62.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)