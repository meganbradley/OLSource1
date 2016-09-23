---
title: "LeafExpressionConverter.SubstHelper&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter.SubstHelper``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - SubstHelper function [F#]
  - LeafExpressionConverter.SubstHelper function [F#]
ms.assetid: 7d59f997-d947-42cf-b57a-c51dfecc67a6
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# LeafExpressionConverter.SubstHelper&lt;&#39;T&gt; Function (F#)
A runtime helper used to evaluate nested quotation literals.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
SubstHelper : Expr * Var [] * obj [] -> Expr<'T>  
  
// Usage:  
SubstHelper (quotation, vars, objects)  
```  
  
#### Parameters  
 `quotation`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input quotation.  
  
 `vars`  
 Type: [Var](../vs140/quotations.var-class--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 An array of variables.  
  
 `objects`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 An array of object instances to substitute for the variables.  
  
## Return Value  
 The resulting code quotation expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [RuntimeHelpers.LeafExpressionConverter Module (F#)](../vs140/runtimehelpers.leafexpressionconverter-module--fsharp-.md)   
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)