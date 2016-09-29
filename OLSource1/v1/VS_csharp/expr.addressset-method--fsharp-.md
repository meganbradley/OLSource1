---
title: "Expr.AddressSet Method (F#)"
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
  - "FSharpExpr.AddressSet"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.AddressSet"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AddressSet method [F#]"
  - "Expr.AddressSet method [F#]"
ms.assetid: ab5eb237-cb0a-43fa-b1ab-4bb604be362c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.AddressSet Method (F#)
Creates an expression that represents setting the value held at a particular address.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member AddressSet : Expr * Expr -> Expr  
  
// Usage:  
Expr.AddressSet (target, value)  
```  
  
#### Parameters  
 `target`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The target expression.  
  
 `value`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The value to set at the address.  
  
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