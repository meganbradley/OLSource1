---
title: "Expr.NewObject Method (F#)"
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
  - "FSharpExpr.NewObject"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.NewObject"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewObject method [F#]"
  - "Expr.NewObject method [F#]"
ms.assetid: c900f8bc-aaaa-41dd-9715-6755c3ae776b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.NewObject Method (F#)
Creates an expression that represents the invocation of an object constructor.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member NewObject : ConstructorInfo * Expr list -> Expr  
  
// Usage:  
Expr.NewObject (constructorInfo, arguments)  
```  
  
#### Parameters  
 `constructorInfo`  
 Type: <xref:System.Reflection.ConstructorInfo*>  
  
 The description of the constructor.  
  
 `arguments`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The list of arguments to the constructor.  
  
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