---
title: "Map.filter&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.filter<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Filter``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "filter function [F#]"
  - "Map.filter function [F#]"
ms.assetid: 2d678ca0-8ed9-42fa-8235-908c4b8208c3
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.filter&lt;&#39;Key,&#39;T&gt; Function (F#)
Creates a new map containing only the bindings for which the given predicate returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the key/value pairs.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The input map.  
  
## Return Value  
 The filtered map.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [!code[FsMaps#5](../vs140/codesnippet/FSharp/map.filter--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Even numbers and their squares.**  
**(2, 4) (4, 16) (6, 36) (8, 64) (10, 100)**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)