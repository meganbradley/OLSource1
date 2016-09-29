---
title: "Array.length&lt;&#39;T&gt; Function (F#)"
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
  - "Array.length<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Length``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.length function [F#]"
  - "length function [F#]"
ms.assetid: 0d775b6a-4a8f-4bd1-83e5-843b3251725f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.length&lt;&#39;T&gt; Function (F#)
Returns the length of an array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.length : 'T [] -> int  
  
// Usage:  
Array.length array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The length of the array.  
  
## Remarks  
 You can also use property <xref:System.Array.Length*>.  
  
 This function is named `Length` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates how to use `Array.length`.  
  
 [!code[FsArrays#50](../vs140/codesnippet/FSharp/array.length--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Length: 100**  
**Length: 0**  
**Length: 50**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)