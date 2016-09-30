---
title: "Array.min&lt;&#39;T&gt; Function (F#)"
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
  - "Array.min<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Min``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.min function [F#]"
  - "min function [F#]"
ms.assetid: d6b3da5f-bac0-4355-9846-4b72d95bc3fd
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.min&lt;&#39;T&gt; Function (F#)
Returns the lowest of all elements of the array, compared by using [Operators.min](../vs140/operators.min--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input array is empty.|  
  
## Return Value  
 The minimum element.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[FsArrays#57](../vs140/codesnippet/FSharp/array.min--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **-4**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)