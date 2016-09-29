---
title: "Core.EntryPointAttribute Class (F#)"
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
  - "Core.EntryPointAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.EntryPointAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EntryPoint attribute [F#]"
  - "EntryPointAttribute class [F#]"
ms.assetid: accfa56a-f18e-4671-b31e-9209e4a337a9
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.EntryPointAttribute Class (F#)
Adding this attribute to a function indicates it is the entry point for an application. If this absent is not specified for an EXE then the initialization implicit in the module bindings in the last file in the compilation sequence are used as the entry point.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>]  
[<Sealed>]  
type EntryPointAttribute =  
 class  
  new EntryPointAttribute : unit -> EntryPointAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `EntryPoint`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.entrypointattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)   
 [Entry Point (F#)](../vs140/entry-point--fsharp-.md)