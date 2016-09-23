---
title: "Seq.readonly&lt;&#39;T&gt; Function (F#)"
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
  - Seq.readonly<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.ReadOnly``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Seq.readonly function [F#]
  - readonly function [F#]
ms.assetid: 88059cb4-3bb0-4126-9448-fbcd48fe13a7
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.readonly&lt;&#39;T&gt; Function (F#)
Creates a new sequence object that delegates to the given sequence object. This ensures the original sequence cannot be rediscovered and mutated by a type cast. For example, if given an array the returned sequence will return the elements of the array, but you cannot cast the returned sequence object to an array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.readonly : seq<'T> -> seq<'T>  
  
// Usage:  
Seq.readonly source  
```  
  
#### Parameters  
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
 This function is named `ReadOnly` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code uses `Seq.readonly` to create an immutable view of a mutable array.  
  
 [!code[FsSequences#24](../vs140/codesnippet/FSharp/seq.readonly--t--function--fsharp-_1.fs)]
  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)