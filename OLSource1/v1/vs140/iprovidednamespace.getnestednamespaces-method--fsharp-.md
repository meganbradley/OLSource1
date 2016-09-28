---
title: "IProvidedNamespace.GetNestedNamespaces Method (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.IProvidedNamespace.GetNestedNamespaces"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IProvidedNamespaces.GetNestedNamespaces method [F#]"
ms.assetid: db115ed5-fa4b-477e-85ed-73bf22af5065
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IProvidedNamespace.GetNestedNamespaces Method (F#)
The sub-namespaces in this namespace. An optional member to prevent generation of namespaces until an outer namespace is explored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.GetNestedNamespaces : unit -> IProvidedNamespace []  
  
// Usage:  
iProvidedNamespace.GetNestedNamespaces ()  
```  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.IProvidedNamespace Interface (F#)](../vs140/compilerservices.iprovidednamespace-interface--fsharp-.md)