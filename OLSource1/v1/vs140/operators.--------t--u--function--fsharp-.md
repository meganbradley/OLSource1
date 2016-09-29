---
title: "Operators.( &lt;| )&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Operators.( &lt;| )<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_PipeLeft``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "<| operator [F#]"
  - "Operators.op_PipeLeft operator [F#]"
  - "op_PipeLeft operator [F#]"
  - "Operators.( <| ) operator [F#]"
ms.assetid: fcbd0345-3d2a-4903-a855-a09a06e4c780
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( &lt;| )&lt;&#39;T,&#39;U&gt; Function (F#)
Applies a function to a value, the value being on the right, the function on the left.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( <| ) : ('T -> 'U) -> 'T -> 'U  
  
// Usage:  
func <| arg1  
```  
  
#### Parameters  
 `func`  
 Type: `'T -> 'U`  
  
 The function.  
  
 `arg1`  
 Type: `'T`  
  
 The argument.  
  
## Return Value  
 The function result.  
  
## Remarks  
 The function is referred to as the *backward* or *reverse pipe operator*.  
  
## Example  
 The following example demonstrates the use of the `<|` operator.  
  
 [!code[FsOperators#4](../vs140/codesnippet/FSharp/operators.--------t--u--function--fsharp-_1.fs)]  
  
 **append1 <&#124; "abc" gives "abc.append1"**  
**result2: "abc.append1.append2"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)