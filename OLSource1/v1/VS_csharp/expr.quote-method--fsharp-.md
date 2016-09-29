---
title: "Expr.Quote Method (F#)"
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
  - "FSharpExpr.Quote"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Quote"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Quote method [F#]"
  - "Expr.Quote method [F#]"
ms.assetid: 9334aa81-6905-40c0-9308-fc847450c33c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Quote Method (F#)
Creates an expression that represents a nested quotation literal.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Quote : Expr -> Expr  
  
// Usage:  
Expr.Quote (inner)  
```  
  
#### Parameters  
 `inner`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The expression being quoted.  
  
## Return Value  
 The resulting expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../VS_csharp/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)