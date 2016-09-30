---
title: "RaiseEvent Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.RaiseEventMethod"
  - "vb.RaiseEvent"
  - "RaiseEvent"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "raising events, RaiseEvent statement"
  - "RaiseEvent statement"
  - "event handlers, connecting events to"
ms.assetid: f82e380a-1e6b-4047-bea8-c853f4d2c742
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RaiseEvent Statement
Triggers an event declared at module level within a class, form, or document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Name of the event to trigger.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. Comma-delimited list of variables, arrays, or expressions. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument must be enclosed by parentheses. If there are no arguments, the parentheses must be omitted.  
  
## Remarks  
 The required <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the name of an event declared within the module. It follows Visual Basic variable naming conventions.  
  
 If the event has not been declared within the module in which it is raised, an error occurs. The following code fragment illustrates an event declaration and a procedure in which the event is raised.  
  
 [!code[VbVbalrEvents#37](../vs140/codesnippet/VisualBasic/raiseevent-statement_1.vb)]  
  
 You cannot use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to raise events that are not explicitly declared in the module. For example, all forms inherit a \<xref:System.Windows.Forms.Control.Click*> event from \<xref:System.Windows.Forms.Form*?displayProperty=fullName>, it cannot be raised using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in a derived form. If you declare a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event in the form module, it shadows the form's own \<xref:System.Windows.Forms.Control.Click*> event. You can still invoke the form's \<xref:System.Windows.Forms.Control.Click*> event by calling the \<xref:System.Windows.Forms.Control.OnClick*> method.  
  
 By default, an event defined in Visual Basic raises its event handlers in the order that the connections are established. Because events can have <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameters, a process that connects late may receive parameters that have been changed by an earlier event handler. After the event handlers execute, control is returned to the subroutine that raised the event.  
  
> [!NOTE]
>  Non-shared events should not be raised within the constructor of the class in which they are declared. Although such events do not cause run-time errors, they may fail to be caught by associated event handlers. Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifier to create a shared event if you need to raise an event from a constructor.  
  
> [!NOTE]
>  You can change the default behavior of events by defining a custom event. For custom events, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement invokes the event's <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> accessor. For more information on custom events, see [Event Statement](../vs140/event-statement.md).  
  
## Example  
 The following example uses events to count down seconds from 10 to 0. The code illustrates several of the event-related methods, properties, and statements, including the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement.  
  
 The class that raises an event is the event source, and the methods that process the event are the event handlers. An event source can have multiple handlers for the events it generates. When the class raises the event, that event is raised on every class that has elected to handle events for that instance of the object.  
  
 The example also uses a form (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) with a button (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) and a text box (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). When you click the button, the first text box displays a countdown from 10 to 0 seconds. When the full time (10 seconds) has elapsed, the first text box displays "Done".  
  
 The code for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> specifies the initial and terminal states of the form. It also contains the code executed when events are raised.  
  
 To use this example, open a new Windows Application project, add a button named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and a text box named <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to the main form, named <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Then right-click the form and click **View Code** to open the Code Editor.  
  
 Add a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> variable to the declarations section of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class.  
  
 [!code[VbVbalrEvents#14](../vs140/codesnippet/VisualBasic/raiseevent-statement_2.vb)]  
  
## Example  
 Add the following code to the code for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Replace any duplicate procedures that may exist, such as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrEvents#15](../vs140/codesnippet/VisualBasic/raiseevent-statement_3.vb)]  
  
 Press F5 to run the preceding example, and click the button labeled **Start**. The first text box starts to count down the seconds. When the full time (10 seconds) has elapsed, the first text box displays "Done".  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method does not process events in exactly the same way as the form does. To allow the form to handle the events directly, you can use multithreading. For more information, see [Threading (C# and Visual Basic)](../vs140/threading--csharp-and-visual-basic-.md).  
  
## See Also  
 [Events in Visual Basic](../vs140/events--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)   
 [AddHandler Statement](../vs140/addhandler-statement.md)   
 [RemoveHandler Statement](../vs140/removehandler-statement.md)   
 [Handles](../vs140/handles-clause--visual-basic-.md)