---
title: "Expr.Coerce Method (F#)"
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
  - "FSharpExpr.Coerce"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Coerce"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.Coerce method [F#]"
  - "Coerce method [F#]"
ms.assetid: 8ae78055-7c73-4bec-b8db-62d5cbf361a5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Coerce Method (F#)
Builds an expression that represents the coercion of an expression to a type  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Coerce : Expr * Type -> Expr  
  
// Usage:  
Expr.Coerce (source, target)  
```  
  
#### Parameters  
 `source`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The expression to coerce.  
  
 `target`  
 Type: <xref:System.Type*>  
  
 The target type.  
  
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