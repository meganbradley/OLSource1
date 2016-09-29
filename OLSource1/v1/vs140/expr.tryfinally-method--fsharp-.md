---
title: "Expr.TryFinally Method (F#)"
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
  - "FSharpExpr.TryFinally"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.TryFinally"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.TryFinally method [F#]"
  - "TryFinally method [F#]"
ms.assetid: 1acf577d-6143-4211-9ebb-20e48aafba29
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.TryFinally Method (F#)
Builds an expression that represents a `try...finally` construct.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member TryFinally : Expr * Expr -> Expr  
  
// Usage:  
Expr.TryFinally (body, compensation)  
```  
  
#### Parameters  
 `body`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The body of the try expression.  
  
 `compensation`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The final part of the expression to be evaluated.  
  
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