---
title: "Array.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)"
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
  - "Array.foldBack2<'T1,'T2,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.FoldBack2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.foldBack2 function [F#]"
  - "foldBack2 function [F#]"
ms.assetid: aa51b405-df20-4c51-9998-a6530f7db862
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)
Apply a function to pairs of elements drawn from the two collections, right-to-left, threading an accumulator argument through the computation. The two input arrays must have the same lengths, otherwise an <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.foldBack2 : ('T1 -> 'T2 -> 'State -> 'State) -> 'T1 [] -> 'T2 [] -> 'State -> 'State  
  
// Usage:  
Array.foldBack2 folder array1 array2 state  
```  
  
#### Parameters  
 `folder`  
 Type: `'T1 -> 'T2 -> 'State -> 'State`  
  
 The function to update the state given the input elements.  
  
 `array1`  
 Type: `'T1` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Return Value  
 The final state.  
  
## Remarks  
 This function is named `FoldBack2` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Array.foldBack2`.  
  
 [!code[FsArrays#47](../vs140/codesnippet/FSharp/array.foldback2--t1--t2--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Ending balance: $1205.00**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)