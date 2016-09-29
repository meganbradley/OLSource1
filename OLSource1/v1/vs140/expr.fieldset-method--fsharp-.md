---
title: "Expr.FieldSet Method (F#)"
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
  - "FSharpExpr.FieldSet"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.FieldSet"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FieldSet method [F#]"
  - "Expr.FieldSet method [F#]"
ms.assetid: 15457912-7817-4363-afa3-67263d6ad072
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.FieldSet Method (F#)
Creates an expression that represents writing to a field of an object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
static member FieldSet : Expr * FieldInfo * Expr -> Expr  
static member FieldSet : FieldInfo * Expr -> Expr  
  
// Usage:  
Expr.FieldSet (obj, fieldInfo, value)  
Expr.FieldSet (fieldInfo, value)  
```  
  
#### Parameters  
 `obj`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input object.  
  
 `fieldInfo`  
 Type: <xref:System.Reflection.FieldInfo*>  
  
 The description of the field to write to.  
  
 `value`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The value to set to the field.  
  
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