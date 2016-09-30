---
title: "Patterns.VarSet Active Pattern (F#)"
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
  - "Patterns.( |VarSet|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.VarSetPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "VarSet active pattern [F#]"
ms.assetid: 4fb87a56-d508-4a0a-a2b4-43a84d127d7a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.VarSet Active Pattern (F#)
Recognizes expressions that represent setting a mutable variable that is in a local scope.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |VarSet|_| ) : (input:Expr) -> (Var * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Var * Expr) option`. The option indicates whether there is a match. In a pattern matching expression, the input is decomposed into a tuple of two elements. The first element is a [Var](../vs140/quotations.var-class--fsharp-.md) object that represents the mutable variable, and the second element is an expression that represents the right side of the assignment expression.  
  
## Remarks  
 This function is named `VarSetPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)