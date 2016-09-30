---
title: "DerivedPatterns.PropertyGetterWithReflectedDefinition Active Pattern (F#)"
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
  - "DerivedPatterns.( |PropertyGetterWithReflectedDefinition|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.PropertyGetterWithReflectedDefinitionPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PropertyGetterWithReflectedDefinition active pattern [F#]"
ms.assetid: e8c25ce7-d2fc-44ae-b540-c22963316d9e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.PropertyGetterWithReflectedDefinition Active Pattern (F#)
Recognizes property get accessors or values in modules that have an associated `ReflectedDefinition`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |PropertyGetterWithReflectedDefinition|_| ) : (propertyInfo:PropertyInfo) -> Expr option  
```  
  
#### Parameters  
 `propertyInfo`  
 Type: \<xref:System.Reflection.PropertyInfo*>  
  
 The description of the property.  
  
## Return Value  
 The expression of the method definition if it is found; otherwise, `None`.  
  
## Remarks  
 This function is named `PropertyGetterWithReflectedDefinitionPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../vs140/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)