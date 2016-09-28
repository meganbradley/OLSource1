---
title: "Stream.AsyncWrite Extension Method (F#)"
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
  - "Stream.AsyncWrite"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.IO.CommonExtensions.AsyncWrite"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CommonExtensions.AsyncWrite extension method [F#]"
  - "AsyncWrite extension method [F#]"
ms.assetid: 1b0a2751-e42a-47e1-bd27-020224adc618
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stream.AsyncWrite Extension Method (F#)
Returns an asynchronous computation that will write the given bytes to the stream.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.CommonExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.IO.Stream with  
  member AsyncWrite : byte [] * ?int * ?int -> Async<unit>  
  
// Usage:  
stream.AsyncWrite (buffer)  
```  
  
#### Parameters  
 `buffer`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The buffer to write from.  
  
 `offset`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional offset as the number of bytes in the stream.  
  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional number of bytes to write to the stream.  
  
## Exceptions  
  
|Exception|Description|  
|---------------|-----------------|  
|<xref:System.ArgumentException*>|Thrown when `offset` or `count` is longer than the buffer length.|  
  
## Return Value  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 <xref:System.IO.Stream*>   
 [Control.CommonExtensions Module (F#)](../vs140/control.commonextensions-module--fsharp-.md)