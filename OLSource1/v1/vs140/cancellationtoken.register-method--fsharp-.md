---
title: "CancellationToken.Register Method (F#)"
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
  - "CancellationToken.Register"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationToken.Register"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CancellationToken.Register method [F#]"
  - "Register method [F#]"
ms.assetid: e2e0e6b6-2656-4cb7-9ad0-0a10cd874d6e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CancellationToken.Register Method (F#)
Registers an action to perform with the CancellationToken.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Register : Action<obj> * obj -> CancellationTokenRegistration  
  
// Usage:  
cancellationToken.Register (action, state)  
```  
  
#### Parameters  
 `action`  
 Type: <xref:System.Action`1*>`<`[obj](../vs140/core.obj-type-abbreviation--fsharp-.md)`>`  
  
 The action to associate with the token.  
  
 `state`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The state associated with the action.  
  
## Return Value  
 The created registration object.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Threading.CancellationToken.Register*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Threading.CancellationToken Structure (F#)](../vs140/threading.cancellationtoken-structure--fsharp-.md)   
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)