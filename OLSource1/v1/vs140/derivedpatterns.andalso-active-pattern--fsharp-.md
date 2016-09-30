---
title: "DerivedPatterns.AndAlso Active Pattern (F#)"
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
  - "DerivedPatterns.( |AndAlso|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.AndAlsoPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AndAlso active pattern [F#]"
ms.assetid: 6bff3ba2-02be-4ba0-8675-4c42844a3cf8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.AndAlso Active Pattern (F#)
Recognizes expressions of the form <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of the two sub-expressions involved in the Boolean AND expression.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../vs140/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)