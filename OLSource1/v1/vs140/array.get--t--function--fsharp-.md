---
title: "Array.get&lt;&#39;T&gt; Function (F#)"
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
  - "Array.get<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Get``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.get function [F#]"
  - "GetAtIndex function [F#]"
  - "Array.GetAtIndex function [F#]"
  - "get function [F#]"
ms.assetid: dd93e85d-7e80-4d76-8de0-b6d45bcf07bc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.get&lt;&#39;T&gt; Function (F#)
Gets an element from an array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.get : 'T [] -> int -> 'T  
  
// Usage:  
Array.get array index  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The input index.  
  
## Return Value  
 The value of the array at the given index.  
  
## Remarks  
 This function is named `Get` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates creating, setting and getting array values.  
  
 [!code[FsArrays#9](../vs140/codesnippet/FSharp/array.get--t--function--fsharp-_1.fs)]  
  
 **0 1 2 3 4 5 6 7 8 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)