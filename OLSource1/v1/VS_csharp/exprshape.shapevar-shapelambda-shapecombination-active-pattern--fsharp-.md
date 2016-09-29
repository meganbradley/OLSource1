---
title: "ExprShape.ShapeVar|ShapeLambda|ShapeCombination Active Pattern (F#)"
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
  - "ExprShape.( |ShapeVar|ShapeLambda|ShapeCombination| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.ExprShapeModule.ShapePattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ShapeCombination active pattern [F#]"
  - "ShapeVar active pattern [F#]"
  - "ShapeLambda active pattern [F#]"
ms.assetid: e090818c-3353-4f28-96ed-1eb04d71139c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExprShape.ShapeVar|ShapeLambda|ShapeCombination Active Pattern (F#)
An active pattern that performs a complete decomposition viewing the expression tree as a binding structure.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations.ExprShape  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |ShapeVar|ShapeLambda|ShapeCombination| ) : (input:Expr) -> Choice<Var,(Var * Expr),(obj * Expr list)>  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression.  
  
## Return Value  
 The decomposed [Var](../VS_csharp/quotations.var-class--fsharp-.md), [Lambda](../VS_csharp/expr.lambda-method--fsharp-.md), or `ConstApp`.  
  
## Remarks  
 This function is named `ShapePattern` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.ExprShape Module (F#)](../VS_csharp/quotations.exprshape-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)