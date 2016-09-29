---
title: "Expr.LetRecursive Method (F#)"
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
  - "FSharpExpr.LetRecursive"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.LetRecursive"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.LetRecursive method [F#]"
  - "LetRecursive method [F#]"
ms.assetid: 0a73193a-3a26-4656-82af-badb5c714eb2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.LetRecursive Method (F#)
Builds recursives expressions associated with `let rec` constructs.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member LetRecursive : Var * Expr list * Expr -> Expr  
  
// Usage:  
Expr.LetRecursive (bindings, body)  
```  
  
#### Parameters  
 `bindings`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md) `*` [Expr](../vs140/quotations.expr-class--fsharp-.md)[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The list of bindings for the let expression.  
  
 `body`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The sub-expression where the bindings are in scope.  
  
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