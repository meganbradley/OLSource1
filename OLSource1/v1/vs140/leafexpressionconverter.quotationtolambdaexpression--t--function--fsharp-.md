---
title: "LeafExpressionConverter.QuotationToLambdaExpression&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter.QuotationToLambdaExpression``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "QuotationToLambdaExpression function [F#]"
  - "LeafExpressionConverter.QuotationToLambdaExpression function [F#]"
ms.assetid: a0e524a0-1056-424f-b964-a889456e6fcb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LeafExpressionConverter.QuotationToLambdaExpression&lt;&#39;T&gt; Function (F#)
Converts a subset of F# quotations to a LINQ expression, for the subset of LINQ expressions represented by the expression syntax in the C# language.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
QuotationToLambdaExpression : Expr<'T> -> Expression<'T>  
  
// Usage:  
QuotationToLambdaExpression   
```  
  
#### Parameters  
 `expression`  
 Type: [Expr](../vs140/quotations.expr--t--class--fsharp-.md)\<'T>  
  
 A quotation that represents a LINQ expression.  
  
## Return Value  
 An expression tree as a LINQ expression.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [RuntimeHelpers.LeafExpressionConverter Module (F#)](../vs140/runtimehelpers.leafexpressionconverter-module--fsharp-.md)   
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)