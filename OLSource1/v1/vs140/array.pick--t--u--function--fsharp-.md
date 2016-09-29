---
title: "Array.pick&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Array.pick<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Pick``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "pick function [F#]"
  - "Array.pick function [F#]"
ms.assetid: 7891efe2-5b35-41be-a5f7-d8af442f196f
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.pick&lt;&#39;T,&#39;U&gt; Function (F#)
Applies the given function to successive elements, returning the first result where function returns `Some`. If the function never returns `Some` then <xref:System.Collections.Generic.KeyNotFoundException*> is raised.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.pick : ('T -> 'U option) -> 'T [] -> 'U  
  
// Usage:  
Array.pick chooser array  
```  
  
#### Parameters  
 `chooser`  
 Type: `'T -> 'U`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The function to generate options from the elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if every result from `chooser` is `None`.|  
  
## Return Value  
 The first result.  
  
## Remarks  
 This function is named `Pick` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use **Array.pick**.  
  
 [!code[FsArrays#62](../vs140/codesnippet/FSharp/array.pick--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **"b"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)