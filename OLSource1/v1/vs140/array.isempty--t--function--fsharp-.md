---
title: "Array.isEmpty&lt;&#39;T&gt; Function (F#)"
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
  - "Array.isEmpty<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.IsEmpty``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.isEmpty function [F#]"
  - "isEmpty function [F#]"
ms.assetid: c2bd48e9-8aba-4bea-ad84-17352886d3a8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.isEmpty&lt;&#39;T&gt; Function (F#)
Tests whether an array is empty.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.isEmpty : 'T [] -> bool  
  
// Usage:  
Array.isEmpty array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 `true` if the array is empty. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `IsEmpty` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Array.isEmpty`.  
  
 [!code[FsArrays#48](../vs140/codesnippet/FSharp/array.isempty--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **This array contains the following elements:**  
**"test1" "test2"**   
**There are no elements in this array.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)