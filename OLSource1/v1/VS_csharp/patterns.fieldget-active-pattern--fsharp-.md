---
title: "Patterns.FieldGet Active Pattern (F#)"
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
  - "Patterns.( |FieldGet|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.FieldGetPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FieldGet active pattern [F#]"
ms.assetid: 99d0c3d6-da53-4ebd-a288-c7be83c00daf
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.FieldGet Active Pattern (F#)
Recognizes expressions that represent getting a static or instance field.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |FieldGet|_| ) : (input:Expr) -> (Expr option * FieldInfo) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Expr option * FieldInfo) option`. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of two elements. The tuple contains an option that contains either an expression that represents the instance for an instance field, or `None` if the field is static. The second element of the tuple is a <xref:System.Reflection.FieldInfo*> object that represents the field.  
  
## Remarks  
 This function is named `FieldGetPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../VS_csharp/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)