---
title: "Operators.( |||&gt; )&lt;&#39;T1,&#39;T2,&#39;T3,&#39;U&gt; Function (F#)"
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
  - "Operators.( |||> )<'T1,'T2,'T3,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_PipeRight3``4"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.( |||> ) operator [F#]"
  - "Operators.op_PipeRight3 operator [F#]"
  - "|||> operator [F#]"
  - "op_PipeRight3 operator [F#]"
ms.assetid: 0b5a6221-904a-4cf8-9fd4-ad5a4ec3817b
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( |||&gt; )&lt;&#39;T1,&#39;T2,&#39;T3,&#39;U&gt; Function (F#)
Applies a function to three values, the values being a triple on the left, the function on the right.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |||> ) : 'T1 * 'T2 * 'T3 -> ('T1 -> 'T2 -> 'T3 -> 'U) -> 'U  
  
// Usage:  
(arg1, arg2, arg3) |||> func  
```  
  
#### Parameters  
 `arg1`  
 Type: `'T1`  
  
 The first argument.  
  
 `arg2`  
 Type: `'T2`  
  
 The second argument.  
  
 `arg3`  
 Type: `'T3`  
  
 The third argument.  
  
 `func`  
 Type: `'T1 -> 'T2 -> 'T3 -> 'U`  
  
 The function.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Example  
 The following example demonstrates the use of the `|||>` operator.  
  
 [!code[FsOperators#3](../vs140/codesnippet/FSharp/operators.----------t1--t2--t3--u--function--fsharp-_1.fs)]  
  
 **("abc", "def", "ghi") &#124;&#124;&#124;> append4 gives  "abc.def.ghi"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)