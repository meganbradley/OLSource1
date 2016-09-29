---
title: "List.reduceBack&lt;&#39;T&gt; Function (F#)"
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
  - "List.reduceBack<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.ReduceBack``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.reduceBack function [F#]"
  - "reduceBack function [F#]"
ms.assetid: 52d747d2-dd6f-4ed8-923d-0a6915fea11f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.reduceBack&lt;&#39;T&gt; Function (F#)
Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is `f` and the elements are `i0...iN`, then this function computes `f i0 (...(f iN-1 iN))`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.reduceBack : ('T -> 'T -> 'T) -> 'T list -> 'T  
  
// Usage:  
List.reduceBack reduction list  
```  
  
#### Parameters  
 `reduction`  
 Type: `'T -> 'T -> 'T`  
  
 The function to reduce two list elements to a single element.  
  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the list is empty.|  
  
## Return Value  
 The final reduced value.  
  
## Remarks  
 This function is named `ReduceBack` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)