---
title: "Seq.collect&lt;&#39;T,&#39;Collection,&#39;U&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Seq.collect<'T,'Collection,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.Collect``3
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - collect function [F#]
  - Seq.collect function [F#]
ms.assetid: f76fe354-40b5-402e-b44e-eb7cb6f98903
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.collect&lt;&#39;T,&#39;Collection,&#39;U&gt; Function (F#)
Applies the given function to each element of the sequence and concatenates all the results.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.collect : ('T -> 'Collection) -> seq<'T> -> seq<'U> (requires 'Collection :> seq<'U>)  
  
// Usage:  
Seq.collect mapping source  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'Collection`  
  
 A function to transform elements of the input sequence into the sequences that are concatenated.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException?qualifyHint=False>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The sequence is evaluated lazily. Therefore, effects are delayed until it is enumerated.  
  
 This function is named `Collect` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `Seq.collect`.  
  
 [!code[FsSequences#28](../vs140/codesnippet/FSharp/seq.collect--t--collection--u--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **-4 -3 -2 -1 1 2 3 4**   
**-12 -4 -2 0 0 2 4 12**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)