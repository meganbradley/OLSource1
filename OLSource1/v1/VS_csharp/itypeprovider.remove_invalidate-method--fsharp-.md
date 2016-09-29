---
title: "ITypeProvider.remove_Invalidate Method (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.ITypeProvider.remove_Invalidate"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "remove_Invalidate method [F#]"
  - "ITypeProvider.remove_Invalidate method [F#]"
ms.assetid: 222c81e5-4b1b-49bd-9d38-a89d5fbc93f2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITypeProvider.remove_Invalidate Method (F#)
Removes an event handler for the [Invalidate](../VS_csharp/itypeprovider.invalidate-event--fsharp-.md) event.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.remove_Invalidate : EventHandler -> unit  
  
// Usage:  
iTypeProvider.remove_Invalidate ()  
```  
  
#### Parameters  
 `handler`  
 Type: <xref:System.EventHandler*>  
  
 The event handler to remove.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.ITypeProvider Interface (F#)](../VS_csharp/compilerservices.itypeprovider-interface--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)