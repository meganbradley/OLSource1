---
title: "Expr.TryGetReflectedDefinition Method (F#)"
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
  - "FSharpExpr.TryGetReflectedDefinition"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr.TryGetReflectedDefinition"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr.TryGetReflectedDefinition method [F#]"
  - "TryGetReflectedDefinition method [F#]"
ms.assetid: 62865941-b319-433a-81ff-d841bb40744b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expr.TryGetReflectedDefinition Method (F#)
Tries to find a stored reflection definition for the given method. Stored reflection definitions are added to an F# assembly through the use of the [ReflectedDefinition](../vs140/core.reflecteddefinitionattribute-class--fsharp-.md) attribute.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.Reflection.MethodBase*>  
  
 The description of the method to find.  
  
## Return Value  
 The reflection definition or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if a match could not be found.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Expr Class (F#)](../vs140/quotations.expr-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)