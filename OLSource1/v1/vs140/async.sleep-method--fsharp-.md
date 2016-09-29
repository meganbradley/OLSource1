---
title: "Async.Sleep Method (F#)"
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
  - "Async.Sleep"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.Sleep"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.Sleep method [F#]"
  - "Sleep method [F#]"
ms.assetid: de7a7567-fade-494e-af85-3758a31c4960
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.Sleep Method (F#)
Creates an asynchronous computation that will sleep for the given time. This is scheduled using a <xref:System.Threading.Timer*> object. The operation will not block operating system threads for the duration of the wait.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Sleep : int -> Async<unit>  
  
// Usage:  
Async.Sleep (millisecondsDueTime)  
```  
  
#### Parameters  
 `millisecondsDueTime`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of milliseconds to sleep.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentOutOfRangeException*>|Thrown when the due time is negative and not infinite.|  
  
## Return Value  
 An asynchronous computation that will sleep for the given time.  
  
## Remarks  
  
## Example  
 The following code example shows how to use `Async.Sleep` to simulate computations that run for specific durations.  
  
 [!code[FsAsyncAPIs#6](../vs140/codesnippet/FSharp/async.sleep-method--fsharp-_1.fs)]  
  
 **Sample Output**  
  
 The output is interleaved, because there are multiple threads running at the same time.  
  
 **Job Job 0 start**  
**1 start**  
**Job 2 starJob 3 start**  
**Job 4 start**  
**Job 5 start**  
**Job 6 start**  
**Job 7 start**  
**Job 8 start**  
**Job 9 start**  
**t**  
**Job 0 end 0:00:00:01.0091009**  
**Job 1 end 0:00:00:02.0102010**  
**Job 2 end 0:00:00:03.0033003**  
**Job 3 end 0:00:00:04.0074007**  
**Job 4 end 0:00:00:05.0065006**  
**Job 5 end 0:00:00:06.0076007**  
**Job 6 end 0:00:00:07.0007000**  
**Job 7 end 0:00:00:07.9957995**  
**Job 8 end 0:00:00:08.9928992**  
**Job 9 end 0:00:00:09.9919991**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)