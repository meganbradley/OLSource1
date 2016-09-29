---
title: "Patterns.FieldSet Active Pattern (F#)"
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
  - "Patterns.( |FieldSet|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.FieldSetPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FieldSet active pattern [F#]"
ms.assetid: 44ebb5e4-e79d-4ae1-9e17-704b3f33bd32
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.FieldSet Active Pattern (F#)
Recognizes expressions that represent setting a static or instance field.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |FieldSet|_| ) : Expr -> (Expr option * FieldInfo * Expr) option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is `(Expr option * FieldInfo * Expr) option`. The option determines whether the input results in a match. In a pattern matching expression, the input is decomposed into a tuple of three elements. The first is an option that can contain an expression that represents the instance. This element is `None` if the field is static. The second element is a <xref:System.Reflection.FieldInfo*> object, and the third element is an expression that represents the value to set the field to.  
  
## Remarks  
 This function is named `FieldSetPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../VS_csharp/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)