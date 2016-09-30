---
title: "Patterns.UnionCaseTest Active Pattern (F#)"
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
  - "Patterns.( |UnionCaseTest|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.UnionCaseTestPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "UnionCaseTest active pattern [F#]"
ms.assetid: fb65b0a3-68d0-4223-be01-fe68ff2a8d57
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.UnionCaseTest Active Pattern (F#)
Recognizes expressions that represent an operation that tests whether a value is of a particular union case.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed into a tuple of two elements. The first element is the expression that represents the target of the test and the second element is the [UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md) object that represents the union case.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)