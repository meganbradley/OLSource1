---
title: "Event Handling in COM"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handling, COM"
  - "event handling, about event handling"
  - "declaring events"
  - "event handlers, COM"
  - "event handlers"
  - "COM, events"
  - "event receivers, in event handling"
  - "event handling"
  - "hooking events"
  - "event receivers, name and signature matching"
  - "event sources, in event handling"
  - "declaring events, in COM"
  - "declaring events, event handling in COM"
ms.assetid: 6b4617d4-a58e-440c-a8a6-1ad1c715b2bb
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event Handling in COM
In COM event handling, you set up an event source and event receiver using the [event_source](../vs140/event_source.md) and [event_receiver](../vs140/event_receiver.md) attributes, respectively, specifying <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>=**com**. These attributes inject the appropriate code for custom, dispatch, and dual interfaces to allow the classes to which they are applied to fire events and handle events through COM connection points.  
  
## Declaring Events  
 In an event source class, use the [__event](../vs140/__event.md) keyword on an interface declaration to declare that interface's methods as events. The events of that interface are fired when you call them as interface methods. Methods on event interfaces can have zero or more parameters (which should all be **in** parameters). The return type can be void or any integral type.  
  
## Defining Event Handlers  
 In an event receiver class, you define event handlers, which are methods with signatures (return types, calling conventions, and arguments) that match the event that they will handle. For COM events, calling conventions do not have to match; see [Layout Dependent COM Events](#vcconeventhandlingincomanchorlayoutdependentcomevents) below for details.  
  
## Hooking Event Handlers to Events  
 Also in an event receiver class, you use the intrinsic function [__hook](../vs140/__hook.md) to associate events with event handlers and [__unhook](../vs140/__unhook.md) to dissociate events from event handlers. You can hook several events to an event handler, or several event handlers to an event.  
  
> [!NOTE]
>  Typically, there are two techniques to allow a COM event receiver to access event source interface definitions. The first, as shown below, is to share a common header file. The second is to use [#import](../vs140/sharpimport-directive--c---.md) with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> import qualifier, so that the event source type library is written to the .tlh file with the attribute-generated code preserved.  
  
## Firing Events  
 To fire an event, simply call a method in the interface declared with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword in the event source class. If handlers have been hooked to the event, the handlers will be called.  
  
### COM Event Code  
 The following example shows how to fire an event in a COM class. To compile and run the example, refer to the comments in the code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then the server:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 And then the client:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="vcconeventhandlingincomanchorlayoutdependentcomevents">\</a> Layout Dependent COM Events  
 Layout dependency is only an issue for COM programming. In native and managed event handling, the signatures (return type, calling convention, and arguments) of the handlers must match their events, but the handler names do not have to match their events.  
  
 However, in COM event handling, when you set the *layout_dependent* parameter of **event_receiver** to **true**, the name and signature matching is enforced. This means that the names and signatures of the handlers in the event receiver must exactly match the names and signatures of the events to which they are hooked.  
  
 When *layout_dependent* is set to **false**, the calling convention and storage class (virtual, static, and so on) can be mixed and matched between the firing event method and the hooking methods (its delegates). It is slightly more efficient to have *layout_dependent*=**true**.  
  
 For example, suppose <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is defined to have the following methods:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Assume the event source has the following form:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Then, in the event receiver, any handler hooked to a method in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must match its name and signature, as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Event Handling](../vs140/event-handling.md)