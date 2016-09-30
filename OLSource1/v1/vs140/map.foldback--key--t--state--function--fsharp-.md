---
title: "Map.foldBack&lt;&#39;Key,&#39;T,&#39;State&gt; Function (F#)"
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
  - "Map.foldBack<'Key,'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.FoldBack``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map.foldBack function [F#]"
  - "foldBack function [F#]"
ms.assetid: c4b2dece-4d1c-42cd-8782-71f47a64e54f
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.foldBack&lt;&#39;Key,&#39;T,&#39;State&gt; Function (F#)
Folds over the bindings in the map.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to update the state given the input key/value pairs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input map.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The initial state.  
  
## Return Value  
 The final state value.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsMaps#9](../vs140/codesnippet/FSharp/map.foldback--key--t--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Result: 6**  
**Result: three two one**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)