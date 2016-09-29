---
title: "ITypeProvider.Invalidate Event (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.ITypeProvider.Invalidate"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Invalidate property [F#]"
  - "ITypeProvider.Invalidate property [F#]"
ms.assetid: 5a8d95dc-e462-4f07-90e4-9b8dfb82d100
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITypeProvider.Invalidate Event (F#)
Triggered when an assumption changes that invalidates the resolutions so far reported by the provider.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.Invalidate : IEvent<EventHandler,EventArgs>  
  
// Usage:  
iTypeProvider.Invalidate  
```  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library VersionsF# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable2.0, 4.0, Portable  
  
## See Also  
 [CompilerServices.ITypeProvider Interface (F#)](../VS_csharp/compilerservices.itypeprovider-interface--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)