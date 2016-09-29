---
title: "Expr.UnionCaseTest Method (F#)"
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
  - "FSharpExpr.UnionCaseTest"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.UnionCaseTest"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.UnionCaseTest method [F#]"
  - "UnionCaseTest method [F#]"
ms.assetid: a9d0803c-863c-493b-81ac-964a6b4f230a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.UnionCaseTest Method (F#)
Creates an expression that represents a test of a value is of a particular union case.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member UnionCaseTest : Expr * UnionCaseInfo -> Expr  
  
// Usage:  
Expr.UnionCaseTest (source, unionCase)  
```  
  
#### Parameters  
 `source`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The expression to test.  
  
 `unionCase`  
 Type: [UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md)  
  
 The description of the union case.  
  
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