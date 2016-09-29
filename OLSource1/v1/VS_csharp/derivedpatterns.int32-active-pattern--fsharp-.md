---
title: "DerivedPatterns.Int32 Active Pattern (F#)"
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
  - "DerivedPatterns.( |Int32|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.Int32Pattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Int32 active pattern [F#]"
ms.assetid: a59bfbeb-5213-422f-a00d-6aa5453c12bb
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.Int32 Active Pattern (F#)
Recognizes constant `int32` expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |Int32|_| ) : (input:Expr) -> int32 option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The result of a successful match is the `int32` value.  
  
## Remarks  
 This function is named `Int32Pattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../VS_csharp/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)