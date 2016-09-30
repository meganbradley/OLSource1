---
title: "Map.findKey&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.findKey<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.FindKey``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "findKey function [F#]"
  - "Map.findKey function [F#]"
ms.assetid: 34052cc7-a792-476a-8d66-1764493335e3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.findKey&lt;&#39;Key,&#39;T&gt; Function (F#)
Evaluates the function on each mapping in the collection and returns the key for the first mapping where the function returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If no such element exists, this function raises \<xref:System.Collections.Generic.KeyNotFoundException*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The input map.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if the key does not exist in the map.|  
  
## Return Value  
 The first key for which the predicate evaluates <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsMaps#7](../vs140/codesnippet/FSharp/map.findkey--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **With value "one", found key 1.**  
**With value "two", found key 2.**  
**With value 9, found key 3.**  
**With value 25, found key 5.**  
**Exception of type 'System.Collections.Generic.KeyNotFoundException' was thrown.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)