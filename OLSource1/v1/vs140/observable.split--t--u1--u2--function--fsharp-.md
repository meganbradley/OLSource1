---
title: "Observable.split&lt;&#39;T,&#39;U1,&#39;U2&gt; Function (F#)"
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
  - "Observable.split<'T,'U1,'U2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Split``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "split function [F#]"
  - "Observable.split function [F#]"
ms.assetid: a628f66b-8712-4a5d-b9fc-ba2f323cb333
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.split&lt;&#39;T,&#39;U1,&#39;U2&gt; Function (F#)
Returns two observables which split the observations of the source by the given function. The first will trigger observations for which the splitter returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The second will trigger observations <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for which the splitter returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The splitter is executed once for each subscribed observer. Both also propagate error observations arising from the source and each completes when the source completes.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Observable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [Choice](../vs140/core.choice--t1--t2--union--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The function that takes an observation and transforms it into one of the two output [Choice](../vs140/core.choice--t1--t2--union--fsharp-.md) types.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 The input Observable.  
  
## Return Value  
 A tuple of Observables. The first triggers when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the second triggers when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)