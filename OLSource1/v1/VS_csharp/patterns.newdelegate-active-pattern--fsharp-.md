---
title: "Patterns.NewDelegate Active Pattern (F#)"
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
  - "Patterns.( |NewDelegate|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.NewDelegatePattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewDelegate active pattern [F#]"
ms.assetid: 42e69e2f-6a0d-4d0a-832b-a3374f10ea8f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.NewDelegate Active Pattern (F#)
Recognizes expressions that represent the construction of delegate values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |NewDelegate|_| ) : (input:Expr) -> (Type * Var list * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Type * Var list * Expr) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input expression is decomposed, upon a successful match, into a tuple that has three elements. The first element is a <xref:System.Type*> object that represents the delegate type. The second element is a list that represents delegate arguments as [Var](../VS_csharp/quotations.var-class--fsharp-.md) objects. The last element is an expression that represents the invocation of the delegate.  
  
## Remarks  
 This function is named `NewDelegatePattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../VS_csharp/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)