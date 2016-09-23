---
title: "ITypeProvider.GetGeneratedAssemblyContents Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.CompilerServices.ITypeProvider.GetGeneratedAssemblyContents
dev_langs: 
  - FSharp
ms.assetid: 2f9dff1a-6336-4748-bc34-db172c5fcba2
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ITypeProvider.GetGeneratedAssemblyContents Method (F#)
Get the physical contents of the given logical provided assembly.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.GetGeneratedAssemblyContents : System.Reflection.Assembly -> byte[]  
  
// Usage:  
iTypeProvider.GetGeneratedAssemblyContents (assembly)  
```  
  
#### Parameters  
 `assembly`  
 Type: <xref:System.Reflection.Assembly?qualifyHint=False>  
  
 The generated assembly.  
  
## Return Value  
 The contents of the generated assembly, as a byte array.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.ITypeProvider Interface (F#)](../vs140/compilerservices.itypeprovider-interface--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)