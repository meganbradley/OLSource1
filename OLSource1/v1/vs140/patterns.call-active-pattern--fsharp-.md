---
title: "Patterns.Call Active Pattern (F#)"
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
  - "Patterns.( |Call|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.CallPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Call active pattern [F#]"
ms.assetid: 30fe9a55-5a76-452d-9334-3324a6837ae7
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.Call Active Pattern (F#)
Recognizes expressions that represent calls to static and instance methods, and those that represent and functions defined in modules.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |Call|_| ) : (input:Expr) -> (Expr option * MethodInfo * Expr list) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Expr option * MethodInfo * Expr list) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of three elements. The first element is an option for an expression that represents the reference to the object for an instance method call. It has a value only if the call is an instance method. The second element of the tuple is a <xref:System.Reflection.MethodInfo*> object that describes the method. The final element of the tuple is a list that contains the arguments for the method call.  
  
## Remarks  
 This function is named `CallPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)