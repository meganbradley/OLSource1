---
title: "CompilerServices.TypeProviderConfig Constructor (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderConfig constructor [F#]"
ms.assetid: a58edc91-0eae-49b8-9331-81115832f7af
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderConfig Constructor (F#)
Constructor for TypeProviderConfig.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new TypeProviderConfig : string * string * string [] * string -> TypeProviderConfig  
  
// Usage:  
new TypeProviderConfig (resolutionFolder, runtimeAssembly, referencedAssemblies, temporaryFolder)  
```  
  
#### Parameters  
 `resolutionFolder`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The folder in which the resolution is occurring. Typically the project folder.  
  
 `runtimeAssembly`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 `referencedAssemblies`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 `temporaryFolder`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
## Return Value  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.TypeProviderConfig Class (F#)](../vs140/compilerservices.typeproviderconfig-class--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)