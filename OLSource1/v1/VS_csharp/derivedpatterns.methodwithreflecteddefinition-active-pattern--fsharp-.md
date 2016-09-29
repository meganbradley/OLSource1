---
title: "DerivedPatterns.MethodWithReflectedDefinition Active Pattern (F#)"
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
  - "DerivedPatterns.( |MethodWithReflectedDefinition|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.MethodWithReflectedDefinitionPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MethodWithReflectedDefinition active pattern [F#]"
ms.assetid: 943fab79-f0c3-43f3-ae91-7d43659b90b1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.MethodWithReflectedDefinition Active Pattern (F#)
Recognizes methods that have an associated `ReflectedDefinition`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |MethodWithReflectedDefinition|_| ) : (methodBase:MethodBase) -> Expr option  
```  
  
#### Parameters  
 `methodBase`  
 Type: <xref:System.Reflection.MethodBase*>  
  
 The description of the method.  
  
## Return Value  
 The expression of the method definition if it is found; otherwise, `None`.  
  
## Remarks  
 This function is named `MethodWithReflectedDefinitionPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../VS_csharp/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../VS_csharp/microsoft.fsharp.quotations-namespace--fsharp-.md)