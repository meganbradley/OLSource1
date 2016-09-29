---
title: "Expr.Application Method (F#)"
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
  - "FSharpExpr.Application"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Application"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Application method [F#]"
  - "Expr.Application method [F#]"
ms.assetid: 82dfc5dd-0d8f-4f1d-892f-391e8ebfda45
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Application Method (F#)
Creates an expression that represents the application of a first class function value to a single argument.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Application : Expr * Expr -> Expr  
  
// Usage:  
Expr.Application (functionExpr, argument)  
```  
  
#### Parameters  
 `functionExpr`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The function to apply.  
  
 `argument`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The argument to the function.  
  
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