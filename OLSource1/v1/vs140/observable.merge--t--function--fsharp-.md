---
title: "Observable.merge&lt;&#39;T&gt; Function (F#)"
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
  - "Observable.merge<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Merge``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Observable.merge function [F#]"
  - "merge function [F#]"
ms.assetid: 33e40753-6895-41a8-acd5-85fcb4eb7524
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.merge&lt;&#39;T&gt; Function (F#)
Returns an observable for the merged observations from the sources. The returned object propagates success and error values arising from either source and completes when both the sources have completed.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Observable  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The first Observable.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The second Observable.  
  
## Return Value  
 An Observable that propagates information from both sources.  
  
## Remarks  
 For each observer, the registered intermediate observing object is not thread safe. That is, observations arising from the sources must not be triggered concurrently on different threads.  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)