---
title: "Expr.Substitute Method (F#)"
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
  - "FSharpExpr.Substitute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Substitute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.Substitute method [F#]"
  - "Substitute method [F#]"
ms.assetid: dc22a870-74f2-4dc2-bc77-260ccd7823d3
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Substitute Method (F#)
Substitutes through the given expression using the given functions to map variables to new values. The functions must give consistent results at each application. Variable renaming may occur on the target expression if variable capture occurs.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Substitute : (Var -> Expr option) -> Expr  
  
// Usage:  
expr.Substitute (substitution)  
```  
  
#### Parameters  
 `substitution`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md) `->` [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The function to map variables into expressions.  
  
## Return Value  
 The expression with the given substitutions.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../vs140/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)