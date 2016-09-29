---
title: "Array.average&lt;^T&gt; Function (F#)"
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
  - "Array.average<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Average``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.average function [F#]"
  - "average function [F#]"
ms.assetid: 7029f2b9-91ea-41cb-be1b-466a5a0db20e
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.average&lt;^T&gt; Function (F#)
Returns the average of the elements in the array.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.average : ^T [] -> ^T (requires ^T with static member (+) and ^T with static member DivideByInt and ^T with static member Zero)  
  
// Usage:  
Array.average array  
```  
  
#### Parameters  
 `array`  
 Type: `^T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when `array` is empty.|  
  
## Return Value  
 The average of the elements in the array.  
  
## Remarks  
 This function cannot be used directly on an array of integers since it requires that the type support an exact division operation, which is indicated by the constraint that the element type must support [DivideByInt](../vs140/languageprimitives.dividebyint-^t--function--fsharp-.md) Floating point types support `DivideByInt`. To compute the average of an array of integers, see the example in [Array.averageBy](../vs140/array.averageby--t-^u--function--fsharp-.md).  
  
 This function is named `Average` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use Array.average.  
  
 [!code[FsArrays#43](../vs140/codesnippet/FSharp/array.average-^t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Average: 5.500000**  
**Average: 5.500000**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)