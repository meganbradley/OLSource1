---
title: "Observable.subscribe&lt;&#39;T&gt; Function (F#)"
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
  - "Observable.subscribe<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Subscribe``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Observable.subscribe function [F#]"
  - "subscribe function [F#]"
ms.assetid: 19e66519-0b77-4396-8159-67ec47be0a63
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.subscribe&lt;&#39;T&gt; Function (F#)
Creates an observer which subscribes to the given observable and which calls the given function for each observation.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Observable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to be called on each observation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input Observable.  
  
## Return Value  
 An object that will remove the callback if disposed.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)