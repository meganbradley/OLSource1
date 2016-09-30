---
title: "Array2D.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Array2D.map<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array2DModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Array2D.map function [F#]"
ms.assetid: 9e0c7271-62af-4eb4-a146-1c6a1bb56294
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array2D.map&lt;&#39;T,&#39;U&gt; Function (F#)
Creates a new array whose elements are the results of applying the given function to each of the elements of the array.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array2D  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 A function that is applied to transform each item of the input array.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The input array.  
  
## Return Value  
 An array whose elements have been transformed by the given mapping.  
  
## Remarks  
 For non-zero-based arrays the basing on an input array will be propagated to the output array.  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)