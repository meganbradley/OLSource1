---
title: "Event.merge&lt;&#39;Del1,&#39;T,&#39;Del2&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.Event.merge``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "merge function [F#]"
ms.assetid: 4eb364ff-9a40-41cf-b62e-64a80576fdc6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.merge&lt;&#39;Del1,&#39;T,&#39;Del2&gt; Function (F#)
Fires the output event when either of the input events fire.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Event  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The first input event.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The second input event.  
  
## Return Value  
 An event that fires when either of the input events fire.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function.  
  
 [!code[FsEvents#5](../vs140/codesnippet/FSharp/event.merge--del1--t--del2--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)