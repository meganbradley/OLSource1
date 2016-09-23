---
title: "Seq.ofList&lt;&#39;T&gt; Function (F#)"
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
  - Seq.of_list<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.OfList``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Seq.ofList function [F#]
  - Seq.FromList function [F#]
  - ofList function [F#]
  - FromList function [F#]
ms.assetid: f13256ad-a566-4818-824e-1ae70768f95f
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.ofList&lt;&#39;T&gt; Function (F#)
Views the given list as a sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.ofList : 'T list -> seq<'T>  
  
// Usage:  
Seq.ofList source  
```  
  
#### Parameters  
 `source`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `OfList` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.ofList`.  
  
 [!code[FsSequences#61](../vs140/codesnippet/FSharp/seq.oflist--t--function--fsharp-_1.fs)]
  
  
 **F# Interactive Output**  
  
 **val seq1 : seq<string\> = ["0"; "1"; "2"; "3"; "4"; "5"; "6"; "7"; "8"; "9"]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)