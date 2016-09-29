---
title: "System.AggregateException Class (F#)"
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
  - "System.AggregateException"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.AggregateException"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AggregateException class [F#]"
ms.assetid: ae45f193-7168-4627-94f2-3c7928c78f61
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# System.AggregateException Class (F#)
Represents one or more errors that occur during application execution.  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type AggregateException =  
 class  
  member this.InnerExceptions :  ReadOnlyCollection<exn>  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.AggregateException*>.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[InnerExceptions](../vs140/aggregateexception.innerexceptions-property--fsharp-.md)|Gets a read-only collection of the `Exception` instances that caused the current exception.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System Namespace (F#)](../vs140/system-namespace--fsharp-.md)