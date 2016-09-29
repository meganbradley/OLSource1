---
title: "Seq.average&lt;^T&gt; Function (F#)"
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
  - "Seq.average<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Average``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "average function [F#]"
  - "Seq.average function [F#]"
ms.assetid: 609d793b-c70f-4e36-9ab4-d928056d65b8
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.average&lt;^T&gt; Function (F#)
Returns the average of the elements in the sequence.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.average : seq<^T> -> ^T (requires ^T with static member (+) and ^T with static member DivideByInt and ^T with static member Zero)  
  
// Usage:  
Seq.average source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../VS_csharp/collections.seq--t--type-abbreviation--fsharp-.md)`<^T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input sequence has zero elements.|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The average.  
  
## Remarks  
 The elements are averaged using the `+` operator, `DivideByInt` method and `Zero` property associated with the element type.  
  
 This function cannot be used directly on a sequence of integers since it requires that the type support an exact division operation, which is indicated by the constraint that the element type must support [DivideByInt](../VS_csharp/languageprimitives.dividebyint-^t--function--fsharp-.md).  
  
 This function is named `Average` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `Seq.average`, and also compares `Seq.average` with [Seq.averageBy](../VS_csharp/seq.averageby--t-^u--function--fsharp-.md).  
  
 [!code[FsSequences#26](../VS_csharp/codesnippet/FSharp/seq.average-^t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Average: 5.500000**  
**Average: 5.500000**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../VS_csharp/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)