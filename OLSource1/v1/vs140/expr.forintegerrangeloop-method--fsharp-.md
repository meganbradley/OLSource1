---
title: "Expr.ForIntegerRangeLoop Method (F#)"
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
  - "FSharpExpr.ForIntegerRangeLoop"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.ForIntegerRangeLoop"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.ForIntegerRangeLoop method [F#]"
  - "ForIntegerRangeLoop method [F#]"
ms.assetid: 0c1c70b9-508d-428f-9187-7273961db724
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.ForIntegerRangeLoop Method (F#)
Creates a `for` expression that represent loops over integer ranges.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ForIntegerRangeLoop : Var * Expr * Expr * Expr -> Expr  
  
// Usage:  
Expr.ForIntegerRangeLoop (loopVariable, start, endExpr, body)  
```  
  
#### Parameters  
 `loopVariable`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)  
  
 The subexpression that declares the loop variable.  
  
 `start`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The subexpression that sets the initial value of the loop variable.  
  
 `endExpr`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The subexpression that declares the final value of the loop variable.  
  
 `body`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The subexpression that represents the body of the loop.  
  
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