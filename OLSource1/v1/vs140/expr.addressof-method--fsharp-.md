---
title: "Expr.AddressOf Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - FSharpExpr.AddressOf
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.FSharpExpr.AddressOf
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - AddressOf method [F#]
  - Expr.AddressOf method [F#]
ms.assetid: f497c445-a54a-49b0-ae38-f55677a87920
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expr.AddressOf Method (F#)
Creates an expression that represents getting the address of a value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member AddressOf : Expr -> Expr  
  
// Usage:  
Expr.AddressOf (target)  
```  
  
#### Parameters  
 `target`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The target expression.  
  
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