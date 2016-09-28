---
title: "CompilerServices.TypeProviderTypeAttributes Enumeration (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderTypeAttributes"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderAttributes enum [F#]"
ms.assetid: 6146d5b8-4d26-4ef9-a9a1-8a285636dfd6
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderTypeAttributes Enumeration (F#)
Indicates the relationship between a compiled entity in a .NET Framework binary and an element in F# source code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type TypeProviderAttributes =  
 | IsErased = 0  
 | SuppressRelocate = 1  
  
```  
  
## Remarks  
 The following table shows the possible values and their meaning.  
  
|Value|Description|  
|-----------|-----------------|  
|IsErased|Indicates that the type is represented by another type in compiled assemblies and never appears directly.|  
|SuppressRelocate|Instructs the compiler not to put generated types as nested types under the user-supplied type abbreviation.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)