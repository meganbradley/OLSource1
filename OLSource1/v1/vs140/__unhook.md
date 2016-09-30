---
title: "__unhook"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__unhook"
  - "__unhook_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handlers, dissociating events"
  - "__unhook keyword [C++]"
ms.assetid: 953a14f3-5199-459d-81e5-fcf015a19878
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __unhook
Dissociates a handler method from an event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **&** *SourceClass* <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> *EventMethod*  
 A pointer to the event method from which you unhook the event handler method:  
  
-   Native C++ events: *SourceClass* is the event source class and *EventMethod* is the event.  
  
-   COM events: *SourceClass* is the event source interface and *EventMethod* is one of its methods.  
  
-   Managed events: *SourceClass* is the event source class and *EventMethod* is the event.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The interface name being unhooked from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, only for COM event receivers in which the *layout_dependent* parameter of the [event_receiver](../vs140/event_receiver.md) attribute is **true**.  
  
 *source*  
 A pointer to an instance of the event source. Depending on the code <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specified in **event_receiver**, *source* can be one of the following:  
  
-   A native event source object pointer.  
  
-   An **IUnknown**-based pointer (COM source).  
  
-   A managed object pointer (for managed events).  
  
 **&** *ReceiverClass* <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the event handler method to be unhooked from an event. The handler is specified as a method of a class or a reference to the same; if you do not specify the class name, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> assumes the class to be that in which it is called.  
  
-   Native C++ events: *ReceiverClass* is the event receiver class and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the handler.  
  
-   COM events: *ReceiverClass* is the event receiver interface and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is one of its handlers.  
  
-   Managed events: *ReceiverClass* is the event receiver class and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the handler.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>(optional)  
 A pointer to an instance of the event receiver class. If you do not specify a receiver, the default is the receiver class or structure in which <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called.  
  
## Usage  
 Can be use in any function scope, including main, outside the event receiver class.  
  
## Remarks  
 Use the intrinsic function <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in an event receiver to dissociate or "unhook" a handler method from an event method.  
  
 There are three forms of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. You can use the first (four-argument) form in most cases. You can use the second (two-argument) form of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> only for a COM event receiver; this unhooks the entire event interface. You can use the third (one-argument) form to unhook all delegates from the specified source.  
  
 A nonzero return value indicates that an error has occurred (managed events will throw an exception).  
  
 If you call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on an event and event handler that are not already hooked, it will have no effect.  
  
 At compile time, the compiler verifies that the event exists and does parameter type checking with the specified handler.  
  
 With the exception of COM events, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> can be called outside the event receiver.  
  
 An alternative to using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is to use the -= operator.  
  
 For information on coding managed events in the new syntax, see [event](../vs140/event---c---component-extensions-.md).  
  
> [!NOTE]
>  A templated class or struct cannot contain events.  
  
## Example  
 See [Event Handling in Native C++](../vs140/event-handling-in-native-c--.md) and [Event Handling in COM](../vs140/event-handling-in-com.md) for samples.  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [event_source](../vs140/event_source.md)   
 [event_receiver](../vs140/event_receiver.md)   
 [__event](../vs140/__event.md)   
 [__hook](../vs140/__hook.md)   
 [__raise](../vs140/__raise.md)