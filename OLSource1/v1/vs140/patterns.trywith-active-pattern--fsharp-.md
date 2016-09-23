---
title: "Patterns.TryWith Active Pattern (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Patterns.( |TryWith|_| )
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.PatternsModule.TryWithPattern
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - TryWith active pattern [F#]
ms.assetid: 71c6a72e-d817-4e9e-9fe3-9cbe91ba2f6d
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Patterns.TryWith Active Pattern (F#)
Recognizes expressions that represent a try...with construct for exception filtering and catching.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |TryWith|_| ) : (input:Expr) -> (Expr * Var * Expr * Var * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Expr * Var * Expr * Var * Expr) option`. The option indicates whether a successful match is made. In a pattern matching expression, upon a successful match, the input expression is decomposed into a tuple of five elements. The first element is an expression that represents the body of the `try...with` expression. The second element is the filter value, which is the value that is used to compare against the patterns. The third element is an expression that represents the filtering and assignment of any values set in the pattern matching (for example, by using the `as` keyword). The fourth element is the catch value, which is usually the same as the filter value and is used to determine which branch is taken. The final element is the catch expression, which includes the branching code. The tuple elements correspond to the arguments of the [Expr.TryWith](../vs140/expr.trywith-method--fsharp-.md) method.  
  
## Remarks  
 This function is named `TryWithPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)