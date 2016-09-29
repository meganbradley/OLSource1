---
title: "RuntimeHelpers.LeafExpressionConverter Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.LeafExpressionConverter"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LeafExpressionConverter module [F#]"
ms.assetid: 4c452e96-3036-4f0e-9008-72abe94c4ad6
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.LeafExpressionConverter Module (F#)
Contains functions that help implement F# query expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module LeafExpressionConverter    EvaluateQuotation : Expr -> obj    ImplicitExpressionConversionHelper : 'T -> Expression<'T>    MemberInitializationHelper : 'T -> 'T    QuotationToExpression : Expr -> Expression    QuotationToLambdaExpression : Expr<'T> -> Expression<'T>    SubstHelper : Expr * Var [] * obj [] -> Expr<'T>  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[EvaluateQuotation](../VS_csharp/leafexpressionconverter.evaluatequotation-function--fsharp-.md): [Expr](../VS_csharp/quotations.expr-class--fsharp-.md) -> [obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md)|Evaluates a subset of F# quotations by first converting to a LINQ expression, for the subset of LINQ expressions represented by the expression syntax in the C# language.|  
|[ImplicitExpressionConversionHelper](../VS_csharp/leafexpressionconverter.implicitexpressionconversionhelper--t--function--fsharp-.md): 'T -> <xref:System.Linq.Expressions.Expression`1*><'T>|When used in a quotation, this function indicates that a specific conversion should be performed when converting the quotation to a LINQ expression. This function should not be called directly.|  
|[MemberInitializationHelper](../VS_csharp/leafexpressionconverter.memberinitializationhelper--t--function--fsharp-.md): 'T -> 'T|When used in a quotation, this function indicates that a specific conversion should be performed when converting the quotation to a LINQ expression. This function should not be called directly.|  
|[QuotationToExpression](../VS_csharp/leafexpressionconverter.quotationtoexpression-function--fsharp-.md): [Expr](../VS_csharp/quotations.expr-class--fsharp-.md) -> <xref:System.Linq.Expressions.Expression`1*>|Converts a subset of F# quotations to a LINQ expression, for the subset of LINQ expressions represented by the expression syntax in the C# language.|  
|[QuotationToLambdaExpression](../VS_csharp/leafexpressionconverter.quotationtolambdaexpression--t--function--fsharp-.md): [Expr](../VS_csharp/quotations.expr--t--class--fsharp-.md)<'T> -> <xref:System.Linq.Expressions.Expression`1*><'T>|Converts a subset of F# quotations to a LINQ expression, for the subset of LINQ expressions represented by the expression syntax in the C# language.|  
|[SubstHelper](../VS_csharp/leafexpressionconverter.substhelper--t--function--fsharp-.md): [Expr](../VS_csharp/quotations.expr-class--fsharp-.md) * [Var](../VS_csharp/quotations.var-class--fsharp-.md) [] \* [obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md) [] -> [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)<'T>|A runtime helper used to evaluate nested quotation literals.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../VS_csharp/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)