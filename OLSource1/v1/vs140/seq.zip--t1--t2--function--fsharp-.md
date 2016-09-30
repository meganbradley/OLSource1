---
title: "Seq.zip&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Seq.zip<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Zip``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "zip function [F#]"
  - "Seq.zip function [F#]"
ms.assetid: 0a5df8bf-0d48-44ce-bff4-e8ef1df5bca4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.zip&lt;&#39;T1,&#39;T2&gt; Function (F#)
Combines the two sequences into a sequence of pairs. The two sequences need not have equal lengths: when one sequence is exhausted any remaining elements in the other sequence are ignored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.zip : seq<'T1> -> seq<'T2> -> seq<'T1 * 'T2>  
  
// Usage:  
Seq.zip source1 source2  
```  
  
#### Parameters  
 `source1`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T1>`  
  
 The first input sequence.  
  
 `source2`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T2>`  
  
 The second input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when either of the input sequences is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `Zip` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)