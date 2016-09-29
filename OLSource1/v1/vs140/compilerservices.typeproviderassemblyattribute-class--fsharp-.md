---
title: "CompilerServices.TypeProviderAssemblyAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderAssemblyAttribute class [F#]"
ms.assetid: 4a6027e2-f894-49d1-bff1-f96e82f0a8f0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderAssemblyAttribute Class (F#)
Places an attribute on a runtime assembly to indicate that a corresponding design-time assembly contains a type provider. The runtime and the designer assembly may be the same.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(1, AllowMultiple = false)>]  
type TypeProviderAssemblyAttribute =  
 class  
  new TypeProviderAssemblyAttribute : string -> TypeProviderAssemblyAttribute  
  new TypeProviderAssemblyAttribute : unit -> TypeProviderAssemblyAttribute  
  member this.AssemblyName : string  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `TypeProviderAssembly`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/compilerservices.typeproviderassemblyattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[AssemblyName](../vs140/typeproviderassemblyattribute.assemblyname-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md)|Specifies the name of the design-time assembly for this type provider.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)