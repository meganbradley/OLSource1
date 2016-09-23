---
title: "Seq.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - Seq.map<'T,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.Map``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - map function [F#]
  - Seq.map function [F#]
ms.assetid: 1db6d9a9-93b3-4997-b2cd-3179e29ffa5e
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.map&lt;&#39;T,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The given function will be applied as elements are demanded using the `MoveNext` method on enumerators retrieved from the object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.map : ('T -> 'U) -> seq<'T> -> seq<'U>  
  
// Usage:  
Seq.map mapping source  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'U`  
  
 A function to transform items from the input sequence.  
  
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
 The returned sequence may be passed between threads safely. However, individual `IEnumerator` values generated from the returned sequence should not be accessed concurrently.  
  
 This function is named `Map` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)