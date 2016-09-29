---
title: "Expr.NewTuple Method (F#)"
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
  - "FSharpExpr.NewTuple"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.NewTuple"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.NewTuple method [F#]"
  - "NewTuple method [F#]"
ms.assetid: 332c33ee-fef4-428c-9afa-934bee58cf8b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.NewTuple Method (F#)
Creates an expression that represents the creation of an F# tuple value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member NewTuple : Expr list -> Expr  
  
// Usage:  
Expr.NewTuple (elements)  
```  
  
#### Parameters  
 `elements`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The list of elements of the tuple.  
  
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