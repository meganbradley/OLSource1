---
title: "Seq.sum&lt;^T&gt; Function (F#)"
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
  - Seq.sum<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.Sum``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Seq.sum function [F#]
  - sum function [F#]
ms.assetid: 01208515-4880-4358-91f5-af34f66dc77a
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.sum&lt;^T&gt; Function (F#)
Returns the sum of the elements in the sequence.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.sum : seq<^T> -> ^T (requires ^T with static member (+) and ^T with static member Zero)  
  
// Usage:  
Seq.sum source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<^T>`  
  
 The input sequence.  
  
## Return Value  
 The sum of the elements of the sequence.  
  
## Remarks  
 The elements are summed using the `+` operator and `Zero` property associated with the generated type.  
  
 This function is named `Sum` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)