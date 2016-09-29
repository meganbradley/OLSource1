---
title: "Expr.TupleGet Method (F#)"
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
  - "FSharpExpr.TupleGet"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.TupleGet"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TupleGet method [F#]"
  - "Expr.TupleGet method [F#]"
ms.assetid: ee0704eb-5af3-446f-88f9-f82fafe01d6b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.TupleGet Method (F#)
Creates an expression that represents getting a field of a tuple.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member TupleGet : Expr * int -> Expr  
  
// Usage:  
Expr.TupleGet (tuple, index)  
```  
  
#### Parameters  
 `tuple`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input tuple.  
  
 `index`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The index of the tuple element to get.  
  
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