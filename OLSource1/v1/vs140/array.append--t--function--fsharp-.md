---
title: "Array.append&lt;&#39;T&gt; Function (F#)"
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
  - "Array.append<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Append``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.append function [F#]"
  - "append function [F#]"
ms.assetid: 08836310-5036-4474-b9a2-2c73e2293911
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.append&lt;&#39;T&gt; Function (F#)
Creates an array that contains the elements of one array followed by the elements of another array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.append : 'T [] -> 'T [] -> 'T []  
  
// Usage:  
Array.append array1 array2  
```  
  
#### Parameters  
 `array1`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Return Value  
 The resulting array.  
  
## Remarks  
 This function is named `Append` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.append`.  
  
 [!code[FsArrays#13](../vs140/codesnippet/FSharp/array.append--t--function--fsharp-_1.fs)]  
  
 **[&#124;1; 2; 3; 4; 5; 6&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)