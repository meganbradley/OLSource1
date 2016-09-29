---
title: "ITypeProvider.ApplyStaticArguments Method (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.ITypeProvider.ApplyStaticArguments"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ITypeProvider.ApplyStaticArguments method [F#]"
  - "ApplyStaticArguments method [F#]"
ms.assetid: 05f98c71-5c9a-4002-aec2-b4ef2b1f6801
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITypeProvider.ApplyStaticArguments Method (F#)
Apply static arguments to a provided type that accepts static arguments.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.ApplyStaticArguments : Type * string [] * obj [] -> Type  
  
// Usage:  
iTypeProvider.ApplyStaticArguments (typeWithoutArguments, typeNameWithArguments, staticArguments)  
```  
  
#### Parameters  
 `typeWithoutArguments`  
 Type: <xref:System.Type*>  
  
 A type to which you want to apply static arguments.  
  
 `typeNameWithArguments`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md) []  
  
 The mangled name of the type after including static parameters. The mangled name is derived from the base type name by adding a backtick (`) and a number that indicates the number of static arguments.  
  
 `staticArguments`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The static parameters, indexed by name.  
  
## Return Value  
 The resulting type with static arguments applied.  
  
## Remarks  
 The provider must return a type with the given mangled name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.ITypeProvider Interface (F#)](../vs140/compilerservices.itypeprovider-interface--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)