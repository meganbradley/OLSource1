---
title: "Operators.( ||&gt; )&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - "Operators.( ||> )<'T1,'T2,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_PipeRight2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.op_PipeRight2 operator [F#]"
  - "op_PipeRight2 operator [F#]"
  - "||> operator [F#]"
  - "Operators.( ||> ) operator [F#]"
ms.assetid: 6018719e-de1a-4d1f-8f91-88a35a4f0e8e
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( ||&gt; )&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
Apply a function to two values, the values being a pair on the left, the function on the right.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ||> ) : 'T1 * 'T2 -> ('T1 -> 'T2 -> 'U) -> 'U  
  
// Usage:  
(arg1, arg2) ||> func  
```  
  
#### Parameters  
 `arg1`  
 Type: `'T1`  
  
 The first argument.  
  
 `arg2`  
 Type: `'T2`  
  
 The second argument.  
  
 `func`  
 Type: `'T1 -> 'T2 -> 'U`  
  
 The function.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Example  
 The following example demonstrates the use of the `||>` operator.  
  
 [!code[FsOperators#2](../vs140/codesnippet/FSharp/operators.---------t1--t2--u--function--fsharp-_1.fs)]  
  
 **("abc", "def") &#124;&#124;> append gives "abc.def"**  
**result2: "ABC.DEF"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)