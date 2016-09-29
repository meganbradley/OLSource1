---
title: "Microsoft.FSharp.Quotations Namespace (F#)"
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
  - "Microsoft.FSharp.Quotations"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Microsoft.FSharp.Quotations namespace [F#]"
ms.assetid: e9ce8a3a-e00c-4190-bad5-cce52ee089b2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft.FSharp.Quotations Namespace (F#)
This namespace contains functionality for working with code programmatically.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
namespace Microsoft.FSharp.Quotations  
```  
  
## Remarks  
 For more information and examples, see [Code Quotations (F#)](../VS_csharp/code-quotations--fsharp-.md).  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [DerivedPatterns](../VS_csharp/quotations.derivedpatterns-module--fsharp-.md)|Contains a set of derived F# active patterns to analyze F# expression objects|  
|module [ExprShape](../VS_csharp/quotations.exprshape-module--fsharp-.md)|Active patterns for traversing, visiting, rebuilding and transforming expressions in a generic way|  
|module [Patterns](../VS_csharp/quotations.patterns-module--fsharp-.md)|Contains a set of primitive F# active patterns to analyze F# expression objects|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)|Quoted expressions annotated with <xref:System.Type*> values.|  
|type [Expr<'T>](../VS_csharp/quotations.expr--t--class--fsharp-.md)|Type-carrying quoted expressions. Expressions are generated either by quotations in source text or programmatically|  
|type [Var](../VS_csharp/quotations.var-class--fsharp-.md)|Information at the binding site of a variable|  
  
## See Also  
 [F# Library Reference](../VS_csharp/fsharp-core-library-reference.md)