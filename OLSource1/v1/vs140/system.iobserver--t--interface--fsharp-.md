---
title: "System.IObserver&lt;&#39;T&gt; Interface (F#)"
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
  - "System.IObserver<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.IObserver`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IObserver interface [F#]"
ms.assetid: 38436152-0d4c-4b0f-9916-440b34f377fb
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# System.IObserver&lt;&#39;T&gt; Interface (F#)
A client that may be subscribed to observe the results from an IObservable.  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, \<xref:System.IObserver`1*>.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[OnCompleted](../vs140/iobserver.oncompleted--t--method--fsharp-.md)|Notify an observer that no more results will be produced|  
|[OnError](../vs140/iobserver.onerror--t--method--fsharp-.md)|Notify an observer of an error|  
|[OnNext](../vs140/iobserver.onnext--t--method--fsharp-.md)|Notify an observer of a new result|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System Namespace (F#)](../vs140/system-namespace--fsharp-.md)