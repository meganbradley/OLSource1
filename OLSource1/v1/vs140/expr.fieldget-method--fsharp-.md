---
title: "Expr.FieldGet Method (F#)"
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
  - FSharpExpr.FieldGet
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.FSharpExpr.FieldGet
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Expr.FieldGet method [F#]
  - FieldGet method [F#]
ms.assetid: 9c077cee-3c0e-44c4-bb1c-a6089b53b79b
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expr.FieldGet Method (F#)
Creates an expression that represents the access of a field of an object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
static member FieldGet : Expr * FieldInfo -> Expr  
static member FieldGet : FieldInfo -> Expr  
  
// Usage:  
Expr.FieldGet (obj, fieldInfo)  
Expr.FieldGet (fieldInfo)  
```  
  
#### Parameters  
 `obj`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input object.  
  
 `fieldInfo`  
 Type: <xref:System.Reflection.FieldInfo?qualifyHint=False>  
  
 The description of the field to access.  
  
## Return Value  
 The resulting expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../vs140/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)