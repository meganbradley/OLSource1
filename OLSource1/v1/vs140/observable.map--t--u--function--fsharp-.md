---
title: "Observable.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Observable.map<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Observable.map function [F#]"
ms.assetid: e3274517-65e4-4c3c-aa9f-61a5c4ba1031
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.map&lt;&#39;T,&#39;U&gt; Function (F#)
Returns an observable which transforms the observations of the source by the given function. The transformation function is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Observable  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function applied to observations from the source.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input Observable.  
  
## Return Value  
 An Observable of the type specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)