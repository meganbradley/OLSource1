---
title: "Array.zip&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Array.zip<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Zip``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.zip function [F#]"
  - "zip function [F#]"
ms.assetid: 23e086b8-b266-4db2-8b68-e88e6a8e2187
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.zip&lt;&#39;T1,&#39;T2&gt; Function (F#)
Combines the two arrays into an array of tuples with two elements. The two arrays must have equal lengths, otherwise <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.zip : 'T1 [] -> 'T2 [] -> ('T1 * 'T2) []  
  
// Usage:  
Array.zip array1 array2  
```  
  
#### Parameters  
 `array1`  
 Type: `'T1`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Return Value  
 The array of tupled elements.  
  
## Remarks  
 This function is named `Zip` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Array.zip`.  
  
 [!code[FsArrays#72](../VS_csharp/codesnippet/FSharp/array.zip--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;(1, -1); (2, -2); (3, -3)&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)