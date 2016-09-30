---
title: "AsyncBuilder.TryWith&lt;&#39;T&gt; Method (F#)"
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
  - "AsyncBuilder.TryWith<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.TryWith``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.TryWith method [F#]"
  - "TryWith method [F#]"
ms.assetid: 47fa979f-0790-40ca-bf32-96628c83f763
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.TryWith&lt;&#39;T&gt; Method (F#)
Implements <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in asynchronous computations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The input computation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [exn](../vs140/core.exn-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The function to run when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> throws an exception.  
  
## Return Value  
 An asynchronous computation that executes <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if an exception is thrown.  
  
## Remarks  
 This function creates an asynchronous computation that runs <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns its result. If an exception happens then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is called and the resulting computation executed instead.  
  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)