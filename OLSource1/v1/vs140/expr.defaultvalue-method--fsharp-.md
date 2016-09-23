---
title: "Expr.DefaultValue Method (F#)"
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
  - FSharpExpr.DefaultValue
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.FSharpExpr.DefaultValue
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - DefaultValue method [F#]
  - Expr.DefaultValue method [F#]
ms.assetid: 89c68c3c-8b2c-418e-a244-5f80d3543587
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expr.DefaultValue Method (F#)
Creates an expression that represents the invocation of a default object constructor  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member DefaultValue : Type -> Expr  
  
// Usage:  
Expr.DefaultValue (expressionType)  
```  
  
#### Parameters  
 `expressionType`  
 Type: <xref:System.Type?qualifyHint=False>  
  
 The type on which the constructor is invoked.  
  
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