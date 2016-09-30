---
title: "Array.max&lt;&#39;T&gt; Function (F#)"
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
  - "Array.max<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Max``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.max function [F#]"
  - "max function [F#]"
ms.assetid: f03fbda0-fce6-40e2-a85d-79c9d81f710b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.max&lt;&#39;T&gt; Function (F#)
Returns the greatest of all elements of the array, compared by using [Operators.max](../vs140/operators.max--t--function--fsharp-.md) on the function result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.max : 'T [] -> 'T (requires comparison)  
  
// Usage:  
Array.max array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input array is empty.|  
  
## Return Value  
 The maximum element.  
  
## Remarks  
 This function is named `Max` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates how to use Array.max.  
  
 [!code[FsArrays#55](../vs140/codesnippet/FSharp/array.max--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **4**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)