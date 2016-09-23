---
title: "Expr.TypeTest Method (F#)"
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
  - FSharpExpr.TypeTest
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.FSharpExpr.TypeTest
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Expr.TypeTest method [F#]
  - TypeTest method [F#]
ms.assetid: 200bf817-e6e4-4fb0-9502-1c49a4163ef2
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expr.TypeTest Method (F#)
Creates an expression that represents a type test.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member TypeTest : Expr * Type -> Expr  
  
// Usage:  
Expr.TypeTest (source, target)  
```  
  
#### Parameters  
 `source`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The expression to test.  
  
 `target`  
 Type: <xref:System.Type?qualifyHint=False>  
  
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