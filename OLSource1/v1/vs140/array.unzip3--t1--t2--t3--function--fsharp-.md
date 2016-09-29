---
title: "Array.unzip3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)"
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
  - "Array.unzip3<'T1,'T2,'T3>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Unzip3``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.unzip3 function [F#]"
  - "unzip3 function [F#]"
ms.assetid: bc3e6db0-f334-444f-8c30-813942880677
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.unzip3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)
Splits an array of triples into three arrays.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.unzip3 : ('T1 * 'T2 * 'T3) [] -> 'T1 [] * 'T2 [] * 'T3 []  
  
// Usage:  
Array.unzip3 array  
```  
  
#### Parameters  
 `array`  
 Type: `('T1 * 'T2 * 'T3)`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The tuple of three arrays.  
  
## Remarks  
 This function is named `Unzip3` in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use Array.unzip3.  
  
 [!code[FsArrays#71](../vs140/codesnippet/FSharp/array.unzip3--t1--t2--t3--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;1; 3&#124;]**  
**[&#124;2; 4&#124;]**  
**[&#124;3; 5&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)