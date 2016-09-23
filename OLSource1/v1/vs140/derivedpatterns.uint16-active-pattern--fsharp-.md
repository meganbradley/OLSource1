---
title: "DerivedPatterns.UInt16 Active Pattern (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - DerivedPatterns.( |UInt16|_| )
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.DerivedPatternsModule.UInt16Pattern
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - UInt16 active pattern [F#]
ms.assetid: 94d513b9-2491-460e-92e0-a456d876c787
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DerivedPatterns.UInt16 Active Pattern (F#)
Recognizes constant unsigned 16-bit integer expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |UInt16|_| ) : (input:Expr) -> uint16 option  
```  
  
#### Parameters  
 `input`  
 Type: [Expr](../vs140/quotations.expr-class--fsharp-.md)  
  
 The input expression to match against.  
  
## Return Value  
 The result of a successful match is the `uint16` value.  
  
## Remarks  
 This function is named `UInt16Pattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../vs140/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)