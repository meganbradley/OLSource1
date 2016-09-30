---
title: "Operators.( &lt;&lt; )&lt;&#39;T2,&#39;T3,&#39;T1&gt; Function (F#)"
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
  - "Operators.( << )<'T2,'T3,'T1>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_ComposeLeft``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.op_ComposeLeft operator [F#]"
  - "Operators.( << ) operator [F#]"
  - "op_ComposeLeft operator [F#]"
  - "<< operator [F#]"
ms.assetid: c0293938-8230-46c3-a775-0d539854171f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( &lt;&lt; )&lt;&#39;T2,&#39;T3,&#39;T1&gt; Function (F#)
Composes two functions, the function on the right being applied first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The second function to apply.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The first function to apply.  
  
## Return Value  
 The composition of the input functions.  
  
## Remarks  
 This operator is referred to as the *backward* or *reverse composition operator*.  
  
## Example  
 The following example demonstrates the use of the reverse composition operator (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 [!code[FsOperators#8](../vs140/codesnippet/FSharp/operators.--------t2--t3--t1--function--fsharp-_1.fs)]  
  
 **abc.append2.append1**  
**abc.append3.append2.append1**  
**myfile.txt**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)