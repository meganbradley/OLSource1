---
title: "Expr.NewDelegate Method (F#)"
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
  - "FSharpExpr.NewDelegate"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.NewDelegate"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewDelegate method [F#]"
  - "Expr.NewDelegate method [F#]"
ms.assetid: fee21336-730d-4310-ac81-27013e1c5241
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.NewDelegate Method (F#)
Creates an expression that represents the creation of a delegate value for the given type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member NewDelegate : Type * Var list * Expr -> Expr  
  
// Usage:  
Expr.NewDelegate (delegateType, parameters, body)  
```  
  
#### Parameters  
 `delegateType`  
 Type: <xref:System.Type*>  
  
 The type of delegate.  
  
 `parameters`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The parameters for the delegate.  
  
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