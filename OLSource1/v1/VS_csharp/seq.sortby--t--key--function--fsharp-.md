---
title: "Seq.sortBy&lt;&#39;T,&#39;Key&gt; Function (F#)"
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
  - "Seq.sortBy<'T,'Key>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.SortBy``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sortBy function [F#]"
  - "Seq.sortBy function [F#]"
ms.assetid: 4f8b4fb9-bf20-49d9-b4ee-dcc906c8208f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.sortBy&lt;&#39;T,&#39;Key&gt; Function (F#)
Applies a key-generating function to each element of a sequence and yields a sequence ordered by keys. The keys are compared using generic comparison as implemented by [Operators.compare](../VS_csharp/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.sortBy : ('T -> 'Key) -> seq<'T> -> seq<'T> (requires comparison)  
  
// Usage:  
Seq.sortBy projection source  
```  
  
#### Parameters  
 `projection`  
 Type: `'T -> 'Key`  
  
 A function to transform items of the input sequence into comparable keys.  
  
 `source`  
 Type: [seq](../VS_csharp/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is `null`.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function returns a sequence that digests the whole initial sequence as soon as that sequence is iterated. Therefore, this function should not be used with large or infinite sequences. The function makes no assumption on the ordering of the original sequence. This is a stable sort, that is, the original order of equal elements is preserved.  
  
 This function is named `SortBy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../VS_csharp/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)