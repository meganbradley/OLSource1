---
title: "Array.reduce&lt;&#39;T&gt; Function (F#)"
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
  - "Array.reduce<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Reduce``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "reduce function [F#]"
  - "Array.reduce function [F#]"
ms.assetid: fd62a985-89fe-4f49-a9d4-0c808ac6749d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.reduce&lt;&#39;T&gt; Function (F#)
Applies a function to each element of the array, threading an accumulator argument through the computation. If the input function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then computes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Raises \<xref:System.ArgumentException*> if the array has size zero.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The function to reduce a pair of elements to a single element.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input array is empty.|  
  
## Return Value  
 The final result of the reductions.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 [!code[FsSamples101#1006](../vs140/codesnippet/FSharp/array.reduce--t--function--fsharp-_1.fs)]  
  
 **sentence = A man landed on the moon**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)