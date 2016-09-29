---
title: "Stream.AsyncRead Extension Method (F#)"
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
  - "Stream.AsyncRead"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.IO.CommonExtensions.AsyncReadBytes"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CommonExtensions.AsyncRead extension method [F#]"
  - "AsyncReadBytes extension method [F#]"
  - "CommonExtensions.AsyncReadBytes extension method [F#]"
  - "AsyncRead extension method [F#]"
ms.assetid: 85698aaa-bdda-47e6-abed-3730f59fda5e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stream.AsyncRead Extension Method (F#)
Returns an asynchronous computation that will read from the stream into the given buffer.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.CommonExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
type System.IO.Stream with  
  member AsyncRead : byte [] * ?int * ?int -> Async<int>  
type System.IO.Stream with  
  member AsyncRead : int -> Async<byte []>  
  
// Usage:  
stream.AsyncRead (buffer)  
stream.AsyncRead (count)  
```  
  
#### Parameters  
 `buffer`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The buffer to read into.  
  
 `offset`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional offset as a number of bytes in the stream.  
  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional number of bytes to read from the stream.  
  
## Exceptions  
  
|Exception|Description|  
|---------------|-----------------|  
|<xref:System.ArgumentException*>|Thrown when the sum of `offset` and `count` is longer than the buffer length.|  
|<xref:System.ArgumentOutOfRangeException*>|Thrown when `offset` or `count` is negative.|  
  
## Return Value  
  
## Remarks  
 This member is named `AsyncRead` in compiled assemblies. If you are accessing the method from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 <xref:System.IO.Stream*>   
 [Control.CommonExtensions Module (F#)](../vs140/control.commonextensions-module--fsharp-.md)