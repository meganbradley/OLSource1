---
title: "CompilerServices.TypeProviderConfig Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderConfig class [F#]"
ms.assetid: 1cda7b9a-3d07-475d-9315-d65e1c97eb44
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderConfig Class (F#)
Provides additional customization options for a type provider implementation. If the class that implements [ITypeProvider](../vs140/compilerservices.itypeprovider-interface--fsharp-.md) has a constructor that accepts `TypeProviderConfig`, it will be constructed with an instance of `TypeProviderConfig`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type TypeProviderConfig =  
 class  
  new TypeProviderConfig : string * string * string [] * string -> TypeProviderConfig  
  member this.ReferencedAssemblies : string []  
  member this.ResolutionFolder : string  
  member this.RuntimeAssembly : string  
  member this.TemporaryFolder : string  
 end  
```  
  
## Remarks  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/compilerservices.typeproviderconfig-constructor--fsharp-.md)|Creates a new instance of `TypeProviderConfig`.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|IsInvalidationSupported : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|Indicates whether the type provider host responds to invalidation events for type provider instances.|  
|IsHostedExecution : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|Indicates whether the type provider instance is used in an environment which executes provided code such as F# Interactive.|  
|[ReferencedAssemblies](../vs140/typeproviderconfig.referencedassemblies-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md) []|Gets the set of referenced assemblies for the provider.|  
|[ResolutionFolder](../vs140/typeproviderconfig.resolutionfolder-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md)|Gets the full path to use to resolve relative paths in any file name arguments given to the provider.|  
|[RuntimeAssembly](../vs140/typeproviderconfig.runtimeassembly-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md)|Gets the full path to actual referenced assembly that caused this type provider to load and instantiate.|  
|[TemporaryFolder](../vs140/typeproviderconfig.temporaryfolder-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md)|Gets the full path to use for temporary files for this instance of the provider.|  
|SystemRuntimeAssemblyVersion : \<xref:System.Version*>|Version of the referenced system runtime assembly.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)