---
title: "Array.scan&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "Array.scan<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Scan``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "scan function [F#]"
  - "Array.scan function [F#]"
ms.assetid: f6893608-9146-450d-9ebb-a0016803fbb0
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.scan&lt;&#39;T,&#39;State&gt; Function (F#)
Like [Array.fold](../vs140/array.fold--t--state--function--fsharp-.md), but returns the intermediate and final results.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.scan : ('State -> 'T -> 'State) -> 'State -> 'T [] -> 'State []  
  
// Usage:  
Array.scan folder state array  
```  
  
#### Parameters  
 `folder`  
 Type: `'State -> 'T -> 'State`  
  
 The function to update the state given the input elements.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The array of state values.  
  
## Remarks  
 This function is named `Scan` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.scan`.  
  
 [!code[FsArrays#35](../vs140/codesnippet/FSharp/array.scan--t--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Initial balance:**  
 **$   1122.73**  
**Transaction   Balance**  
**$   -100.00 $   1122.73**  
**$    450.34 $   1022.73**  
**$    -62.34 $   1473.07**  
**$   -127.00 $   1410.73**  
**$    -13.50 $   1283.73**  
**$    -12.92 $   1270.23**  
**Final balance:**  
 **$   1257.31**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)