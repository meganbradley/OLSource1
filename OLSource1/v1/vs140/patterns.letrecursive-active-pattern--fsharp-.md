---
title: "Patterns.LetRecursive Active Pattern (F#)"
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
  - "Patterns.( |LetRecursive|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.LetRecursivePattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LetRecursive active pattern [F#]"
ms.assetid: 4c127a46-ac21-4908-8e21-eed5f8d1659c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.LetRecursive Active Pattern (F#)
Recognizes expressions that represent recursive `let` bindings of one or more variables.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |LetRecursive|_| ) : (input:Expr) -> ((Var * Expr) list * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `((Var * Expr) list * Expr) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple that contains two elements. The first element is a list of tuples that has two elements. The first element of the inner tuple is a [Var](../vs140/quotations.var-class--fsharp-.md) object that represents the value being defined. The second element of the inner tuple represents the body of a recursive `let` binding. The second element of the outer tuple is the subexpression in which the binding is in scope.  
  
## Remarks  
 This function is named `LetRecursivePattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)