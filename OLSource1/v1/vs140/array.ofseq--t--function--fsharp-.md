---
title: "Array.ofSeq&lt;&#39;T&gt; Function (F#)"
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
  - "Array.of_seq<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.OfSeq``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FromSequence function [F#]"
  - "ofSeq function [F#]"
  - "Array.ofSeq function [F#]"
  - "Array.FromSequence function [F#]"
ms.assetid: 6bedf5e0-4b22-46da-b09c-6aa09eff220c
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.ofSeq&lt;&#39;T&gt; Function (F#)
Builds a new array from the given enumerable object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.ofSeq : seq<'T> -> 'T []  
  
// Usage:  
Array.ofSeq source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Return Value  
 The array of elements from the sequence.  
  
## Remarks  
 This function is named `OfSeq` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 Thhhe following code shows how to use `Array.ofSeq`.  
  
 [!code[FsArrays#60](../vs140/codesnippet/FSharp/array.ofseq--t--function--fsharp-_1.fs)]  
  
 **FSI Output**  
  
 **val array1 : int [] = [&#124;1; 2; 3; 4; 5; 6; 7; 8; 9; 10&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)