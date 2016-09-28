---
title: "Expr.Let Method (F#)"
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
  - "FSharpExpr.Let"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Let"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Let method [F#]"
  - "Expr.Let method [F#]"
ms.assetid: 0da309db-1146-49ae-ac11-9285a1473d0a
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Let Method (F#)
Builds expressions associated with `let` constructs.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Let : Var * Expr * Expr -> Expr  
  
// Usage:  
Expr.Let (letVariable, letExpr, body)  
```  
  
#### Parameters  
 `letVariable`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)  
  
 The variable in the let expression.  
  
 `letExpr`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The expression bound to the variable.  
  
 `body`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The sub-expression where the binding is in scope.  
  
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