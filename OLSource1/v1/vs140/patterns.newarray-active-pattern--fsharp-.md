---
title: "Patterns.NewArray Active Pattern (F#)"
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
  - "Patterns.( |NewArray|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.NewArrayPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewArray active pattern [F#]"
ms.assetid: 5427df99-ab59-4210-9333-79ae3cd24105
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.NewArray Active Pattern (F#)
Recognizes expressions that represent the construction of arrays.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |NewArray|_| ) : (input:Expr) -> (Type * Expr list) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Type * Expr list) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed into a type object that represents the element type and a list of expressions that represent elements in an array initialization expression.  
  
## Remarks  
 This function is named `NewArrayPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)