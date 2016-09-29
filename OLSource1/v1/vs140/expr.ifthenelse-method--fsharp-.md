---
title: "Expr.IfThenElse Method (F#)"
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
  - "FSharpExpr.IfThenElse"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.IfThenElse"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IfThenElse method [F#]"
  - "Expr.IfThenElse method [F#]"
ms.assetid: cdb7253d-a451-435c-8acf-21ff9ad4ccb6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.IfThenElse Method (F#)
Creates `if...then...else` expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member IfThenElse : Expr * Expr * Expr -> Expr  
  
// Usage:  
Expr.IfThenElse (guard, thenExpr, elseExpr)  
```  
  
#### Parameters  
 `guard`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The condition expression.  
  
 `thenExpr`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The `then` subexpression.  
  
 `elseExpr`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The `else` subexpression.  
  
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