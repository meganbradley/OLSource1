---
title: "Expr.VarSet Method (F#)"
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
  - "FSharpExpr.VarSet"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.VarSet"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.VarSet method [F#]"
  - "VarSet method [F#]"
ms.assetid: a14e1535-7ad2-41fb-8029-ed1b513091ba
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.VarSet Method (F#)
Creates an expression that represents setting a mutable variable.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member VarSet : Var * Expr -> Expr  
  
// Usage:  
Expr.VarSet (variable, value)  
```  
  
#### Parameters  
 `variable`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)  
  
 The input variable.  
  
 `value`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The value to set.  
  
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