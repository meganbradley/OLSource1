---
title: "Expr.PropertySet Method (F#)"
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
  - "FSharpExpr.PropertySet"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.PropertySet"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PropertySet method [F#]"
  - "Expr.PropertySet method [F#]"
ms.assetid: 520f728e-6ac1-4d4c-b2f4-726c234b42d7
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.PropertySet Method (F#)
Creates an expression that represents writing to a static property  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
static member PropertySet : PropertyInfo * Expr * ?Expr list -> Expr  
static member PropertySet : Expr * PropertyInfo * Expr * ?Expr list -> Expr  
  
// Usage:  
Expr.PropertySet (property, value)  
Expr.PropertySet (property, value, indexerArgs = indexerArgs)  
Expr.PropertySet (obj, property, value)  
Expr.PropertySet (obj, property, value, indexerArgs = indexerArgs)  
```  
  
#### Parameters  
 `property`  
 Type: \<xref:System.Reflection.PropertyInfo*>  
  
 The description of the property.  
  
 `value`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The value to set.  
  
 `indexerArgs`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 List of indices for the property if it is an indexed property.  
  
 `obj`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The object instance, if applicable.  
  
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