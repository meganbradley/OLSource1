---
title: "Event Handling in Native C++"
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
  - "event handling, Visual C++"
ms.assetid: e4b9219a-15d8-42fb-83c8-6d2e4e087c8d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event Handling in Native C++
In native C++ event handling, you set up an event source and event receiver using the [event_source](../vs140/event_source.md) and [event_receiver](../vs140/event_receiver.md) attributes, respectively, specifying <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. These attributes allow the classes to which they are applied to fire events and handle events in a native, non-COM context.  
  
## Declaring Events  
 In an event source class, use the [__event](../vs140/__event.md) keyword on a method declaration to declare the method as an event. Make sure to declare the method, but do not define it; to do so will generate a compiler error, because the compiler defines the method implicitly when it is made into an event. Native events can be methods with zero or more parameters. The return type can be void or any integral type.  
  
## Defining Event Handlers  
 In an event receiver class, you define event handlers, which are methods with signatures (return types, calling conventions, and arguments) that match the event that they will handle.  
  
## Hooking Event Handlers to Events  
 Also in an event receiver class, you use the intrinsic function [__hook](../vs140/__hook.md) to associate events with event handlers and [__unhook](../vs140/__unhook.md) to dissociate events from event handlers. You can hook several events to an event handler, or several event handlers to an event.  
  
## Firing Events  
 To fire an event, simply call the method declared as an event in the event source class. If handlers have been hooked to the event, the handlers will be called.  
  
### Native C++ Event Code  
 The following example shows how to fire an event in native C++. To compile and run the example, refer to the comments in the code.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Event Handling](../vs140/event-handling.md)