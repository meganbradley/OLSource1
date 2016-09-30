---
title: "Patterns.NewRecord Active Pattern (F#)"
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
  - "Patterns.( |NewRecord|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.PatternsModule.NewRecordPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NewRecord active pattern [F#]"
ms.assetid: 3be68638-6f84-409a-baf7-0697f9aa9084
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Patterns.NewRecord Active Pattern (F#)
Recognizes expressions that represent the construction of record values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The formal return type is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple that has two elements. The first element is a \<xref:System.Type*> object that represents the record type that is being constructed, and the second element is a list of expressions that represent the constructor arguments.  
  
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