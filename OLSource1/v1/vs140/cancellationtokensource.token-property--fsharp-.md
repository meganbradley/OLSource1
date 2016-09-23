---
title: "CancellationTokenSource.Token Property (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - CancellationTokenSource.Token
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - System.Threading.CancellationTokenSource.Token
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Token property [F#]
  - CancellationTokenSource.Token property [F#]
ms.assetid: 02eac69e-62eb-4b1b-a247-27adaa30c88a
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CancellationTokenSource.Token Property (F#)
Fetches the token representing the capability to detect cancellation of an operation.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Token :  CancellationToken  
  
// Usage:  
cancellationTokenSource.Token  
```  
  
## Return Value  
 A <xref:System.Threading.CancellationToken?qualifyHint=False> object.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Threading.CancellationTokenSource.Token?qualifyHint=False>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Threading.CancellationTokenSource Class (F#)](../vs140/threading.cancellationtokensource-class--fsharp-.md)   
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)