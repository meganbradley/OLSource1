---
title: "Operators.( |&gt; )&lt;&#39;T1,&#39;U&gt; Function (F#)"
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
  - "Operators.( |> )<'T1,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_PipeRight``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.op_PipeRight operator [F#]"
  - "Operators.( |> ) operator [F#]"
  - "op_PipeRight operator [F#]"
  - "|> operator [F#]"
ms.assetid: 698b9e4a-a6d7-4ab1-8809-b2fdba783070
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( |&gt; )&lt;&#39;T1,&#39;U&gt; Function (F#)
Apply a function to a value, the value being on the left, the function on the right.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |> ) : 'T1 -> ('T1 -> 'U) -> 'U  
  
// Usage:  
arg |> func  
```  
  
#### Parameters  
 `arg`  
 Type: `'T1`  
  
 The argument.  
  
 `func`  
 Type: `'T1 -> 'U`  
  
 The function.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Example  
 The following example demonstrates the use of the forward pipe operator.  
  
 [!code[FsOperators#1](../VS_csharp/codesnippet/FSharp/operators.--------t1--u--function--fsharp-_1.fs)]  
  
 **"abc" &#124;> append1 gives "abc.append1"**  
**result2: "abc.append1.append2"**  
**300 200 100**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../VS_csharp/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)