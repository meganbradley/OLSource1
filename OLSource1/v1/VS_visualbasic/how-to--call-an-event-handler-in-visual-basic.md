---
title: "How to: Call an Event Handler in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Visual Basic code, procedures"
  - "event handlers, calling"
  - "event handlers"
  - "procedures, event handlers"
  - "procedures, calling"
ms.assetid: 72e18ef8-144e-40df-a1f4-066a57271e28
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Call an Event Handler in Visual Basic
An *event* is an action or occurrence — such as a mouse click or a credit limit exceeded — that is recognized by some program component, and for which you can write code to respond. An *event handler* is the code you write to respond to an event.  
  
 An event handler in [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] is a `Sub` procedure. However, you do not normally call it the same way as other `Sub` procedures. Instead, you identify the procedure as a handler for the event. You can do this either with a [Handles](../VS_visualbasic/handles-clause--visual-basic-.md) clause and a [WithEvents](../VS_visualbasic/withevents--visual-basic-.md) variable, or with an [AddHandler Statement](../VS_visualbasic/addhandler-statement.md). Using a `Handles` clause is the default way to declare an event handler in [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)]. This is the way the event handlers are written by the designers when you program in the integrated development environment (IDE). The `AddHandler` statement is suitable for raising events dynamically at run time.  
  
 When the event occurs, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] automatically calls the event handler procedure. Any code that has access to the event can cause it to occur by executing a [RaiseEvent Statement](../VS_visualbasic/raiseevent-statement.md).  
  
 You can associate more than one event handler with the same event. In some cases you can dissociate a handler from an event. For more information, see [Events](../VS_visualbasic/events--visual-basic-.md).  
  
### To call an event handler using Handles and WithEvents  
  
1.  Make sure the event is declared with an [Event Statement](../VS_visualbasic/event-statement.md).  
  
2.  Declare an object variable at module or class level, using the [WithEvents](../VS_visualbasic/withevents--visual-basic-.md) keyword. The `As` clause for this variable must specify the class that raises the event.  
  
3.  In the declaration of the event-handling `Sub` procedure, add a [Handles](../VS_visualbasic/handles-clause--visual-basic-.md) clause that specifies the `WithEvents` variable and the event name.  
  
4.  When the event occurs, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] automatically calls the `Sub` procedure. Your code can use a `RaiseEvent` statement to make the event occur.  
  
     The following example defines an event and a `WithEvents` variable that refers to the class that raises the event. The event-handling `Sub` procedure uses a `Handles` clause to specify the class and event it handles.  
  
     [!code[VbVbcnProcedures#4](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-an-event-handler-in-visual-basic_1.vb)]  
  
### To call an event handler using AddHandler  
  
1.  Make sure the event is declared with an `Event` statement.  
  
2.  Execute an [AddHandler Statement](../VS_visualbasic/addhandler-statement.md) to dynamically connect the event-handling `Sub` procedure with the event.  
  
3.  When the event occurs, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] automatically calls the `Sub` procedure. Your code can use a `RaiseEvent` statement to make the event occur.  
  
     The following example defines a `Sub` procedure to handle the \<xref:System.Windows.Forms.Form.Closing> event of a form. It then uses the [AddHandler Statement](../VS_visualbasic/addhandler-statement.md) to associate the `catchClose` procedure as an event handler for \<xref:System.Windows.Forms.Form.Closing>.  
  
     [!code[VbVbcnProcedures#5](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-an-event-handler-in-visual-basic_2.vb)]  
  
     You can dissociate an event handler from an event by executing the [RemoveHandler Statement](../VS_visualbasic/removehandler-statement.md).  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Sub Procedures](../VS_visualbasic/sub-procedures--visual-basic-.md)   
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)   
 [AddressOf Operator](../VS_visualbasic/addressof-operator--visual-basic-.md)   
 [How to: Create a Procedure](../VS_visualbasic/how-to--create-a-procedure--visual-basic-.md)   
 [How to: Call a Procedure that Does Not Return a Value](../VS_visualbasic/how-to--call-a-procedure-that-does-not-return-a-value--visual-basic-.md)