---
title: "Expr.NewUnionCase Method (F#)"
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
  - "FSharpExpr.NewUnionCase"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.NewUnionCase"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewUnionCase method [F#]"
  - "Expr.NewUnionCase method [F#]"
ms.assetid: 481c3359-71cd-404d-a2be-53208ffb9d9f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.NewUnionCase Method (F#)
Creates an expression that represents the creation of a union case value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member NewUnionCase : UnionCaseInfo * Expr list -> Expr  
  
// Usage:  
Expr.NewUnionCase (unionCase, arguments)  
```  
  
#### Parameters  
 `unionCase`  
 Type: [UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md)  
  
 The description of the union case.  
  
 `arguments`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The list of arguments for the case.  
  
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