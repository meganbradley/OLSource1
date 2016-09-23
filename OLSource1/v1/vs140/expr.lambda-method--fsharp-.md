---
title: "Expr.Lambda Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - FSharpExpr.Lambda
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.FSharpExpr.Lambda
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Lambda method [F#]
  - Expr.Lambda method [F#]
ms.assetid: 783760ed-8dd5-407e-a752-19451d81bb97
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expr.Lambda Method (F#)
Creates an expression that represents the construction of an F# function value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Lambda : Var * Expr -> Expr  
  
// Usage:  
Expr.Lambda (parameter, body)  
```  
  
#### Parameters  
 `parameter`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)  
  
 The parameter to the function.  
  
 `body`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The body of the function.  
  
## Return Value  
 The resulting expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../vs140/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)