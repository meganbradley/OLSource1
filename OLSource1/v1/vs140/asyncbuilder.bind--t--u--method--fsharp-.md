---
title: "AsyncBuilder.Bind&lt;&#39;T,&#39;U&gt; Method (F#)"
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
  - "AsyncBuilder.Bind<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.Bind``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.Bind method [F#]"
  - "Bind method [F#]"
ms.assetid: 74deaad1-5d78-4ce7-905b-399231df02bc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.Bind&lt;&#39;T,&#39;U&gt; Method (F#)
Implements <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in asynchronous computations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The computation to provide an unbound result.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The function to bind the result of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 An asynchronous computation that performs a monadic bind on the result of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Creates an asynchronous computation that runs <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and when the computation generates a result, passes the result to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that binds the result of the computation to a value.  
  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)