---
title: "Expr.Deserialize Method (F#)"
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
  - "FSharpExpr.Deserialize"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.Deserialize"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Deserialize method [F#]"
  - "Expr.Deserialize method [F#]"
ms.assetid: 0d61cb91-5326-461c-8ffe-51966a66ac2e
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.Deserialize Method (F#)
This function is called automatically when quotation syntax (`<@ @>`) and related typed-expression quotations are used. The bytes are a pickled binary representation of an unlinked form of the quoted expression, and the <xref:System.Type*> argument is any type in the assembly where the quoted expression occurs, i.e. it helps scope the interpretation of the cross-assembly references in the bytes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Deserialize : Type * Type list * Expr list * byte [] -> Expr  
  
// Usage:  
Expr.Deserialize (qualifyingType, spliceTypes, spliceExprs, bytes)  
```  
  
#### Parameters  
 `qualifyingType`  
 Type: <xref:System.Type*>  
  
 A type in the assembly where the quotation occurs.  
  
 `spliceTypes`  
 Type: <xref:System.Type*>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The list of spliced types.  
  
 `spliceExprs`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The list of spliced expressions.  
  
 `bytes`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The serialized form of the quoted expression.  
  
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