---
title: "Seq.cast&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.cast<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Cast``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "cast function [F#]"
  - "Seq.cast function [F#]"
ms.assetid: 1d087db3-a8b2-41dd-8ddc-227544529334
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.cast&lt;&#39;T&gt; Function (F#)
Wraps a weakly typed <xref:System.Collections*> sequence as a typed sequence.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.cast : IEnumerable -> seq<'T>  
  
// Usage:  
Seq.cast source  
```  
  
#### Parameters  
 `source`  
 Type: <xref:System.Collections.IEnumerable*>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The use of this function usually requires a type annotation. An incorrect type annotation may result in runtime type errors. Individual <xref:System.Collections.Generic.IEnumerator`1*> values generated from the returned sequence should not be accessed concurrently.  
  
 This function is named `Cast` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `Seq.cast` to convert a weakly typed <xref:System.Collections.ArrayList*>, where the element type is just <xref:System.Object*>, into a sequence of `int`.  
  
 [!code[FsSequences#12](../vs140/codesnippet/FSharp/seq.cast--t--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)