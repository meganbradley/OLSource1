---
title: "Patterns.Let Active Pattern (F#)"
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
  - "Patterns.( |Let|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.LetPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Let active pattern [F#]"
ms.assetid: 6bed1453-5243-45c5-a88f-5534444c6655
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.Let Active Pattern (F#)
Recognizes expressions that represent `let` bindings.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |Let|_| ) : (input:Expr) -> (Var * Expr * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Var * Expr * Expr) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of three elements. The first element is a [Var](../vs140/quotations.var-class--fsharp-.md) object that represents the value that is being defined. The second element represents the body of the `let` expression. The third element represents the expression that follows the `let` binding, or, in the verbose syntax, the expression that follows the `in` keyword.  
  
## Remarks  
 This function is named `LetPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)