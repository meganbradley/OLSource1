---
title: "Seq.empty&lt;&#39;T&gt; Type Function (F#)"
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
  - "Seq.empty<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Empty``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.empty type function [F#]"
  - "empty type function [F#]"
ms.assetid: 3c7f1c69-6117-4782-b2da-0e04d6854f59
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.empty&lt;&#39;T&gt; Type Function (F#)
Creates an empty sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.empty<'T> :  seq<'T>  
  
// Usage:  
Seq.empty  
```  
  
## Return Value  
 An empty sequence.  
  
## Remarks  
 This function is named `Empty` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **Seq.empty**.  
  
 [!code[FsSequences#32](../vs140/codesnippet/FSharp/seq.empty--t--type-function--fsharp-_1.fs)]  
  
 **F# Interactive Output**  
  
 **val emptySeq1 : seq\<'a>val emptySeq2 : seq\<string>**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)