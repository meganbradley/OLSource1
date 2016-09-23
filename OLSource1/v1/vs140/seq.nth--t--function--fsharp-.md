---
title: "Seq.nth&lt;&#39;T&gt; Function (F#)"
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
  - Seq.nth<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.Get``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - nth function [F#]
  - GetAtIndex function [F#]
  - Seq.nth function [F#]
  - Seq.GetAtIndex function [F#]
ms.assetid: 6850ce94-7ef6-45a3-ae1e-e07a35477fe0
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.nth&lt;&#39;T&gt; Function (F#)
Computes the *nth* element in the collection.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.nth : int -> seq<'T> -> 'T  
  
// Usage:  
Seq.nth index source  
```  
  
#### Parameters  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index of element to retrieve.  
  
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
 This function is named `Get` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)