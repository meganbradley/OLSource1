---
title: "IObserver.OnNext&lt;&#39;T&gt; Method (F#)"
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
  - IObserver.OnNext<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - System.IObserver`1.OnNext
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IObserver.OnNext method [F#]
  - OnNext method [F#]
ms.assetid: 3d2e91d2-c589-431c-b9e3-e822b422f29c
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IObserver.OnNext&lt;&#39;T&gt; Method (F#)
Notify an observer of a new result  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.OnNext : 'T -> unit  
  
// Usage:  
iObserver.OnNext (value)  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to notify observers.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.IObserver`1.OnNext?qualifyHint=False>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.IObserver<'T> Interface (F#)](../vs140/system.iobserver--t--interface--fsharp-.md)   
 [System Namespace (F#)](../vs140/system-namespace--fsharp-.md)