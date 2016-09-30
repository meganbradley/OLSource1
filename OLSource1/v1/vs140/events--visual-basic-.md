---
title: "Events (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "events [Visual Basic], about events"
  - "events [Visual Basic]"
ms.assetid: 8fb0353a-e41b-4e23-b78f-da65db832f70
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Events (Visual Basic)
While you might visualize a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project as a series of procedures that execute in a sequence, in reality, most programs are event driven—meaning the flow of execution is determined by external occurrences called *events*.  
  
 An event is a signal that informs an application that something important has occurred. For example, when a user clicks a control on a form, the form can raise a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> event and call a procedure that handles the event. Events also allow separate tasks to communicate. Say, for example, that your application performs a sort task separately from the main application. If a user cancels the sort, your application can send a cancel event instructing the sort process to stop.  
  
## Event Terms and Concepts  
 This section describes the terms and concepts used with events in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
### Declaring Events  
 You declare events within classes, structures, modules, and interfaces using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword, as in the following example:  
  
 [!code[VbVbalrEvents#24](../vs140/codesnippet/VisualBasic/events--visual-basic-_1.vb)]  
  
### Raising Events  
 An event is like a message announcing that something important has occurred. The act of broadcasting the message is called *raising* the event. In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you raise events with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement, as in the following example:  
  
 [!code[VbVbalrEvents#25](../vs140/codesnippet/VisualBasic/events--visual-basic-_2.vb)]  
  
 Events must be raised within the scope of the class, module, or structure where they are declared. For example, a derived class cannot raise events inherited from a base class.  
  
### Event Senders  
 Any object capable of raising an event is an *event sender*, also known as an *event source*. Forms, controls, and user-defined objects are examples of event senders.  
  
### Event Handlers  
 *Event handlers* are procedures that are called when a corresponding event occurs. You can use any valid subroutine with a matching signature as an event handler. You cannot use a function as an event handler, however, because it cannot return a value to the event source.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] uses a standard naming convention for event handlers that combines the name of the event sender, an underscore, and the name of the event. For example, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> event of a button named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> would be named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  We recommend that you use this naming convention when defining event handlers for your own events, but it is not required; you can use any valid subroutine name.  
  
## Associating Events with Event Handlers  
 Before an event handler becomes usable, you must first associate it with an event by using either the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement.  
  
### WithEvents and the Handles Clause  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause provide a declarative way of specifying event handlers. An event raised by an object declared with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword can be handled by any procedure with a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement for that event, as shown in the following example:  
  
 [!code[VbVbalrEvents#1](../vs140/codesnippet/VisualBasic/events--visual-basic-_3.vb)]  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement and the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause are often the best choice for event handlers because the declarative syntax they use makes event handling easier to code, read and debug. However, be aware of the following limitations on the use of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> variables:  
  
-   You cannot use a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable as an object variable. That is, you cannot declare it as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>—you must specify the class name when you declare the variable.  
  
-   Because shared eventsare not tied to class instances, you cannot use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to declaratively handle shared events. Similarly, you cannot use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to handle events from a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. In both cases, you can use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement to handle those events.  
  
-   You cannot create arrays of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> variables.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> variables allow a single event handler to handle one or more kind of event, or one or more event handlers to handle the same kind of event.  
  
 Although the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause is the standard way of associating an event with an event handler, it is limited to associating events with event handlers at compile time.  
  
 In some cases, such as with events associated with forms or controls, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] automatically stubs out an empty event handler and associates it with an event. For example, when you double-click a command button on a form in design mode, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] creates an empty event handler and a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> variable for the command button, as in the following code:  
  
 [!code[VbVbalrEvents#26](../vs140/codesnippet/VisualBasic/events--visual-basic-_4.vb)]  
  
### AddHandler and RemoveHandler  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement is similar to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> clause in that both allow you to specify an event handler. However, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, used with <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, provides greater flexibility than the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause, allowing you to dynamically add, remove, and change the event handler associated with an event. If you want to handle shared events or events from a structure, you must use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> takes two arguments: the name of an event from an event sender such as a control, and an expression that evaluates to a delegate. You do not need to explicitly specify the delegate class when using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, since the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement always returns a reference to the delegate. The following example associates an event handler with an event raised by an object:  
  
 [!code[VbVbalrEvents#28](../vs140/codesnippet/VisualBasic/events--visual-basic-_5.vb)]  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, which disconnects an event from an event handler, uses the same syntax as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. For example:  
  
 [!code[VbVbalrEvents#29](../vs140/codesnippet/VisualBasic/events--visual-basic-_6.vb)]  
  
 In the following example, an event handler is associated with an event, and the event is raised. The event handler catches the event and displays a message.  
  
 Then the first event handler is removed and a different event handler is associated with the event. When the event is raised again, a different message is displayed.  
  
 Finally, the second event handler is removed and the event is raised for a third time. Because there is no longer an event handler associated with the event, no action is taken.  
  
 [!code[VbVbalrEvents#38](../vs140/codesnippet/VisualBasic/events--visual-basic-_7.vb)]  
  
## Handling Events Inherited from a Base Class  
 *Derived classes*—classes that inherit characteristics from a base class—can handle events raised by their base class using the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> statement.  
  
#### To handle events from a base class  
  
-   Declare an event handler in the derived class by adding a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>*eventname* statement to the declaration line of your event-handler procedure, where *eventname* is the name of the event in the base class you are handling. For example:  
  
     [!code[VbVbalrEvents#12](../vs140/codesnippet/VisualBasic/events--visual-basic-_8.vb)]  
  
## Related Sections  
  
|Title|Description|  
|-----------|-----------------|  
|[Walkthrough: Declaring and Raising Events](../vs140/walkthrough--declaring-and-raising-events--visual-basic-.md)|Provides a step-by-step description of how to declare and raise events for a class.|  
|[Walkthrough: Handling Events](../vs140/walkthrough--handling-events--visual-basic-.md)|Demonstrates how to write an event-handler procedure.|  
|[How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md)|Demonstrates how to define a custom event that allows its event handlers to be called asynchronously.|  
|[How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md)|Demonstrates how to define a custom event that uses memory only when the event is handled.|  
|[Troubleshooting Inherited Event Handlers in Visual Basic 2005](../vs140/troubleshooting-inherited-event-handlers-in-visual-basic.md)|Lists common issues that arise with event handlers in inherited components.|  
|[Handling and Raising Events](assetId:///b6f65241-e0ad-4590-a99f-200ce741bb1f)|Provides an overview of the event model in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)].|  
|[Event Handling in Windows Forms](assetId:///6514e530-c6b8-489c-a8d2-eda7b7072701)|Describes how to work with events associated with Windows Forms objects.|  
|[Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)|Provides an overview of delegates in Visual Basic.|