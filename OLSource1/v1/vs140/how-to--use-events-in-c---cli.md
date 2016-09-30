---
title: "How to: Use Events in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Events in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "events [C++], accessing in interfaces"
ms.assetid: fbf452dc-2dd7-4322-adc0-656512d654d1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Events in C++-CLI
This article shows how to use an interface that declares an event and a function to invoke that event, and the class and event handler that implement the interface.  
  
## Interface events  
 The following code example adds an event handler, invokes the event—which causes the event handler to write its name to the console—and then removes the event handler.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **EventReceiver::Handler**   
## Custom accessor methods  
 The following sample shows how to define an event's behavior when handlers are added or removed, and when an event is raised.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **In event handler H1**  
**In event handler H2 with args 1 and 2.2**   
## Override default access on add, remove, and raise accessors  
 This sample shows how to override the default access on the add, remove, and raise events methods:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **17**   
## Multiple event handlers  
 An event receiver, or any other client code, can add one or more handlers to an event.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **Click(x=7,y=3.14159)**  
**DblClick(s=System.Char[])**  
**DblClickAgain(s=System.Char[])**   
## Static events  
 The following sample shows how to define and use static events.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **In event handler H1**  
**In event handler H2 with args 11 and 11.11**  
**In event handler H1**  
**In event handler H2 with args 22 and 22.22**   
## Virtual events  
 This sample implements virtual, managed events in an interface and class:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **In handler H1**  
**In handler H2 with args 1 and 2.2** A simple event cannot be specified to override or hide a base class event.  You must define all of the event's accessor functions, and then specify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword on each accessor function.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Abstract events  
 The following sample shows how to implement an abstract event.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Output**  
  
 **hi**  
**hello from Event2**   
## Raising events that are defined in a different assembly  
 An event and event handler can be defined in one assembly, and consumed by another assembly.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This client code consumes the event:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Output**  
  
 **hello**  
**hello**   
## See Also  
 [event](../vs140/event---c---component-extensions-.md)