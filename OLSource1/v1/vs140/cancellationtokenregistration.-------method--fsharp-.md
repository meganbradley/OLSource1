---
title: "CancellationTokenRegistration.( &lt;&gt; ) Method (F#)"
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
  - "CancellationTokenRegistration.( != )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationTokenRegistration.op_BangEquals"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "!= operator [F#]"
  - "CancellationTokenRegistration.op_BangEquals operator [F#]"
  - "CancellationTokenRegistration.( != ) operator [F#]"
  - "op_BangEquals operator [F#]"
ms.assetid: f9a1c67d-624e-4360-81d2-024d761cde25
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CancellationTokenRegistration.( &lt;&gt; ) Method (F#)
Inequality operator for registrations.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ( <> ) : CancellationTokenRegistration * CancellationTokenRegistration -> bool  
  
// Usage:  
registration1 <> registration2  
```  
  
#### Parameters  
 `registration1`  
 Type: [CancellationTokenRegistration](../vs140/threading.cancellationtokenregistration-structure--fsharp-.md)  
  
 The first input registration.  
  
 `registration2`  
 Type: [CancellationTokenRegistration](../vs140/threading.cancellationtokenregistration-structure--fsharp-.md)  
  
 The second input registration.  
  
## Return Value  
 False if the two registrations are equal.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, [Inequality](assetId:///M:System.Threading.CancellationTokenRegistration.op_Inequality(System.Threading.CancellationTokenRegistration,System.Threading.CancellationTokenRegistration)?qualifyHint=False&autoUpgrade=True).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Threading.CancellationTokenRegistration Structure (F#)](../vs140/threading.cancellationtokenregistration-structure--fsharp-.md)   
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)