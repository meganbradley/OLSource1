---
title: "CompilerServices.TypeProviderAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderAttribute class [F#]"
ms.assetid: bdf7b036-7490-4ace-b79f-c5f1b1b37947
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderAttribute Class (F#)
Place on a class that implements the [ITypeProvider](../vs140/compilerservices.itypeprovider-interface--fsharp-.md) interface to extend the compiler.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(4, AllowMultiple = false)>]  
type TypeProviderAttribute =  
 class  
  new TypeProviderAttribute : unit -> TypeProviderAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `TypeProvider`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/compilerservices.typeproviderattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)