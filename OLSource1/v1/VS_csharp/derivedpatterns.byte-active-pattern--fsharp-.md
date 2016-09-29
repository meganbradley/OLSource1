---
title: "DerivedPatterns.Byte Active Pattern (F#)"
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
  - "DerivedPatterns.( |Byte|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.BytePattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Byte active pattern [F#]"
ms.assetid: 6ef0a209-ccac-4f5c-a2c8-ee2f7ea8cd79
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.Byte Active Pattern (F#)
Recognizes constant `byte` expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |Byte|_| ) : (input:Expr) -> byte option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../VS_csharp/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The result of a successful match is the `byte` value.  
  
## Remarks  
 This function is named `BytePattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../VS_csharp/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)