---
title: "Map.add&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.add<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Add``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "add function [F#]"
  - "Map.add function [F#]"
ms.assetid: 8cd69deb-e5c2-4e24-b63f-02b807d3e98d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.add&lt;&#39;Key,&#39;T&gt; Function (F#)
Returns a new map with the binding added to the given map.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Map  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input key.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The input map.  
  
## Return Value  
 The resulting map.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsMaps#1](../vs140/codesnippet/FSharp/map.add--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **key: 0 value: zero**  
**key: 1 value: one**  
**key: 2 value: two**  
**key: 3 value: three**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)