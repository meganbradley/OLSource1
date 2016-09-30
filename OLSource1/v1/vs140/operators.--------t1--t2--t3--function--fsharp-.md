---
title: "Operators.( &gt;&gt; )&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)"
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
  - "Operators.( >> )<'T1,'T2,'T3>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_ComposeRight``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.op_ComposeRight operator [F#]"
  - "op_ComposeRight operator [F#]"
  - "Operators.( >> ) operator [F#]"
  - ">> operator [F#]"
ms.assetid: b604e1f2-7d61-4ff0-aa0d-0b691b17bd0b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( &gt;&gt; )&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)
Composes two functions, the function on the left being applied first  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The first function to apply.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The second function to apply.  
  
## Return Value  
 The composition of the input functions.  
  
## Remarks  
  
## Example  
 The following example demonstrates the use of the composition operator (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 [!code[FsOperators#7](../vs140/codesnippet/FSharp/operators.--------t1--t2--t3--function--fsharp-_1.fs)]  
  
 **abc.append1.append2**  
**abc.append1.append2.append3**  
**myfile.txt**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)