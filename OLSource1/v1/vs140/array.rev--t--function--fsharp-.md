---
title: "Array.rev&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Array.rev<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ArrayModule.Reverse``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Array.Reverse function [F#]
  - Array.rev function [F#]
  - Reverse function [F#]
  - rev function [F#]
ms.assetid: 1bbf822c-763b-4794-af21-97d2e48ef709
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array.rev&lt;&#39;T&gt; Function (F#)
Returns a new array with the elements in reverse order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.rev : 'T [] -> 'T []  
  
// Usage:  
Array.rev array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The reversed array.  
  
## Remarks  
 This function is named `Reverse` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example shows how to reverse the elements in an array by using `Array.rev`.  
  
 [!code[FsArrays#18](../vs140/codesnippet/FSharp/array.rev--t--function--fsharp-_1.fs)]
  
  
 **"Hello world!"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)