---
title: "Seq.ofArray&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.of_array<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.OfArray``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FromArray function [F#]"
  - "ofArray function [F#]"
  - "Seq.FromArray function [F#]"
  - "Seq.ofArray function [F#]"
ms.assetid: 299cd4d9-be72-4511-aac8-089e1ddaac99
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.ofArray&lt;&#39;T&gt; Function (F#)
Views the given array as a sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.ofArray : 'T array -> seq<'T>  
  
// Usage:  
Seq.ofArray source  
```  
  
#### Parameters  
 `source`  
 Type: `'T array`  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `OfArray` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.ofArray`.  
  
 [!code[FsSequences#60](../vs140/codesnippet/FSharp/seq.ofarray--t--function--fsharp-_1.fs)]  
  
 **F# Interactive Output**  
  
 **val seq1 : seq<string\>**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)