---
title: "FSharpFunc.op_Implicit&lt;&#39;T,&#39;U&gt; Method (F#)"
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
  - "FSharpFunc.op_Implicit<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpFunc`2.op_Implicit"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc.op_Implicit method [F#]"
  - "op_Implicit method [F#]"
ms.assetid: c2051648-4743-4c60-a4d8-056336abf9ba
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpFunc.op_Implicit&lt;&#39;T,&#39;U&gt; Method (F#)
Convert an value of type <xref:System.Converter`2*> to a F# first class function value or vice versa.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
static member op_Implicit : Converter<'T,'U> -> 'T -> 'U  
static member op_Implicit : ('T -> 'U) -> Converter<'T,'U>  
  
// Usage:  
FSharpFunc.op_Implicit (converter)  
FSharpFunc.op_Implicit (func)  
```  
  
#### Parameters  
 `converter`  
 Type: <xref:System.Converter`2*>`<'T,                                                                                       'U>`  
  
 The input <xref:System.Converter`2*> instance.  
  
 `func`  
 Type: `'T -> 'U`  
  
 An input function to be converted to a <xref:System.Converter`2*> instance..  
  
## Return Value  
 The result of the conversion.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.FSharpFunc<'T,'U> Class (F#)](../vs140/core.fsharpfunc--t--u--class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)