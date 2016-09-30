---
title: "Event.partition&lt;&#39;T,&#39;Del&gt; Function (F#)"
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
  - "Microsoft.FSharp.Control.Event.partition``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
ms.assetid: 9854e530-5bd1-4705-bec6-688f53d7a952
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.partition&lt;&#39;T,&#39;Del&gt; Function (F#)
Returns a new event that listens to the original event and triggers the first resulting event if the application of the predicate to the event arguments returned <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and the second event if it returned <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Event  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to determine which output event to trigger.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The input event.  
  
## Return Value  
 A tuple of events. The first is triggered when the predicate evaluates to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the second when the predicate evaluates to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function to split an event into two events, each with its own event handling code.  
  
 [!code[FsEvents#7](../vs140/codesnippet/FSharp/event.partition--t--del--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)