---
title: "__event"
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
  - "__event_cpp"
  - "__event"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__event keyword [C++]"
  - "events [C++], __event"
ms.assetid: d3019b3e-722e-48df-8536-c05878461f9e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __event
Declares an event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The keyword <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be applied to a method declaration, an interface declaration, or a data member declaration. However, you cannot use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword to qualify a member of a nested class.  
  
 Depending on whether your event source and receiver are native C++, COM, or managed (.NET Framework), you can use the following constructs as events:  
  
|Native C++|COM|Managed (.NET Framework)|  
|------------------|---------|--------------------------------|  
|Method|—|method|  
|—|interface|—|  
|—|—|data member|  
  
 Use [__hook](../vs140/__hook.md) in an event receiver to associate a handler method with an event method. Note that after you create an event with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword, all event handlers subsequently hooked to that event will be called when the event is called.  
  
 An <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method declaration cannot have a definition; a definition is implicitly generated, so the event method can be called as if it were any ordinary method.  
  
> [!NOTE]
>  A templated class or struct cannot contain events.  
  
## Native Events  
 Native events are methods. The return type is typically <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, but can be any integral type, including an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. When an event uses an integral return type, an error condition is defined when an event handler returns a nonzero value, in which case the event being raised will call the other delegates.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 See [Event Handling in Native C++](../vs140/event-handling-in-native-c--.md) for sample code.  
  
## COM Events  
 COM events are interfaces. The parameters of a method in an event source interface should be **in** parameters (but this is not rigorously enforced), because an **out** parameter is not useful when multicasting. A level 1 warning will be issued if you use an **out** parameter.  
  
 The return type is typically <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, but can be any integral type, including <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. When an event uses an integral return type and an event handler returns a nonzero value, it is an error condition, in which case the event being raised aborts calls to the other delegates. Note that the compiler will automatically mark an event source interface as a [source](../vs140/source--c---.md) in the generated IDL.  
  
 The [__interface](../vs140/__interface.md) keyword is always required after <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for a COM event source.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 See [Event Handling in COM](../vs140/event-handling-in-com.md) for sample code.  
  
## Managed Events  
 For information on coding events in the new syntax, see [event](../vs140/event---c---component-extensions-.md).  
  
 Managed events are data members or methods. When used with an event, the return type of a delegate must be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6). The return type of the event handler must match the return type of the delegate. For more information on delegates, see [__delegate](../vs140/__delegate.md). If a managed event is a data member, its type must be a pointer to a delegate.  
  
 In the .NET Framework, you can treat a data member as if it were a method itself (that is, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method of its corresponding delegate). You must predefine the delegate type for declaring a managed event data member. In contrast, a managed event method implicitly defines the corresponding managed delegate if it is not already defined. For example, you can declare an event value such as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> as an event as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When implicitly declaring a managed event, you can specify add and remove accessors that will be called when event handlers are added or removed. You can also define the method that calls (raises) the event from outside the class.  
  
## Example: Native Events  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example: COM Events  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example: Managed Events  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 When applying an attribute to an event, you can specify that the attribute apply to either the generated methods or to the Invoke method of the generated delegate.  The default (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) is to apply the attribute to the event.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Event Handling](../vs140/event-handling.md)   
 [event_source](../vs140/event_source.md)   
 [event_receiver](../vs140/event_receiver.md)   
 [__hook](../vs140/__hook.md)   
 [__unhook](../vs140/__unhook.md)   
 [__raise](../vs140/__raise.md)