---
title: "AggregateException.InnerExceptions Property (F#)"
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
  - "AggregateException.InnerExceptions"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.AggregateException.InnerExceptions"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AggregateException.InnerExceptions property [F#]"
  - "InnerExceptions property [F#]"
ms.assetid: 2a59eae4-bb9e-40d1-88de-01bcb665248c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AggregateException.InnerExceptions Property (F#)
Gets a read-only collection of the `Exception` instances that caused the current exception.  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.InnerExceptions :  ReadOnlyCollection<exn>  
  
// Usage:  
aggregateException.InnerExceptions  
```  
  
## Return Value  
 A <xref:System.Collections.ObjectModel.ReadOnlyCollection`1*> that contains the inner exceptions.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.AggregateException.InnerExceptions*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.AggregateException Class (F#)](../VS_csharp/system.aggregateexception-class--fsharp-.md)   
 [System Namespace (F#)](../VS_csharp/system-namespace--fsharp-.md)