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
Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then this function computes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The function to reduce two list elements to a single element.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the list is empty.|  
  
## Return Value  
 The final reduced value.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)