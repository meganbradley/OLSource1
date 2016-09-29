---
title: "Expr.NewRecord Method (F#)"
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
  - "FSharpExpr.NewRecord"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.NewRecord"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.NewRecord method [F#]"
  - "NewRecord method [F#]"
ms.assetid: c5721cc2-2f6a-462b-97b9-93f6b135c6b3
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.NewRecord Method (F#)
Builds record-construction expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member NewRecord : Type * Expr list -> Expr  
  
// Usage:  
Expr.NewRecord (recordType, elements)  
```  
  
#### Parameters  
 `recordType`  
 Type: <xref:System.Type*>  
  
 The type of record.  
  
 `elements`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The list of elements of the record.  
  
## Return Value  
 The resulting expression.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../VS_csharp/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)