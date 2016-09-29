---
title: "Expr.Call Method (F#)"
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
  - "FSharpExpr.Call"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Call"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.Call method [F#]"
  - "Call method [F#]"
ms.assetid: ca1f1f21-180d-480d-a070-e76d04bd0910
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Call Method (F#)
Creates an expression that represents a call to an instance method associated with an object  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
static member Call : Expr * MethodInfo * Expr list -> Expr  
static member Call : MethodInfo * Expr list -> Expr  
  
// Usage:  
Expr.Call (obj, methodInfo, arguments)  
Expr.Call (methodInfo, arguments)  
```  
  
#### Parameters  
 `obj`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input object.  
  
 `methodInfo`  
 Type: <xref:System.Reflection.MethodInfo*>  
  
 The description of the method to call.  
  
 `arguments`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The list of arguments to the method.  
  
## Return Value  
 The resulting expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../VS_csharp/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)