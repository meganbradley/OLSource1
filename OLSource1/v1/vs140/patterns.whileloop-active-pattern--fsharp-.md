---
title: "Patterns.WhileLoop Active Pattern (F#)"
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
  - "Patterns.( |WhileLoop|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.WhileLoopPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "WhileLoop active pattern [F#]"
ms.assetid: 0df8dd3c-faab-4873-ab5c-eb5b0159f8b9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.WhileLoop Active Pattern (F#)
Recognizes expressions that represent <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loops.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The option value indicates whether there is a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of expressions. The first element of the tuple is the test expression and the second is the body of the loop.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Patterns Module (F#)](../vs140/quotations.patterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)