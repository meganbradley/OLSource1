---
title: "DerivedPatterns.PropertySetterWithReflectedDefinition Active Pattern (F#)"
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
  - "DerivedPatterns.( |PropertySetterWithReflectedDefinition|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule.PropertySetterWithReflectedDefinitionPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PropertySetterWithReflectedDefinition active pattern [F#]"
ms.assetid: ebe4b18d-57b0-45b9-8e2d-3dfc5a3c6f19
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DerivedPatterns.PropertySetterWithReflectedDefinition Active Pattern (F#)
Recognizes property `set` accessors that have an associated `ReflectedDefinition`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |PropertySetterWithReflectedDefinition|_| ) : (propertyInfo:PropertyInfo) -> Expr option  
```  
  
#### Parameters  
 `propertyInfo`  
 Type: <xref:System.Reflection.PropertyInfo*>  
  
 The description of the property.  
  
## Return Value  
 The expression of the method definition if it is found; otherwise, `None`.  
  
## Remarks  
 This function is named `PropertySetterWithReflectedDefinitionPattern` in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.DerivedPatterns Module (F#)](../vs140/quotations.derivedpatterns-module--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)