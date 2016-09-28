---
title: "LeafExpressionConverter.EvaluateQuotation Function (F#)"
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
  - "Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter.EvaluateQuotation"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LeafExpressionConverter.EvaluateQuotation function [F#]"
  - "EvaluateQuotation function [F#]"
ms.assetid: 78d297ba-5713-4e81-b97c-437d816f336b
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LeafExpressionConverter.EvaluateQuotation Function (F#)
Evaluates a subset of F# quotations by first converting to a LINQ expression, for the subset of LINQ expressions represented by the expression syntax in the C# language.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
EvaluateQuotation : Expr -> obj  
  
// Usage:  
EvaluateQuotation   
```  
  
#### Parameters  
 `quotation`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The quotation to evaluate.  
  
## Return Value  
 The result of the evaluation.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [RuntimeHelpers.LeafExpressionConverter Module (F#)](../vs140/runtimehelpers.leafexpressionconverter-module--fsharp-.md)   
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)