---
title: "How to: Declare Custom Events To Conserve Memory (Visual Basic)"
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
  - "declaring events, custom"
  - "events [Visual Basic], custom"
  - "custom events"
ms.assetid: 87ebee87-260c-462f-979c-407874debd19
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Custom Events To Conserve Memory (Visual Basic)
There are several circumstances when it is important that an application keep its memory usage low. Custom events allow the application to use memory only for the events that it handles.  
  
 By default, when a class declares an event, the compiler allocates memory for a field to store the event information. If a class has many unused events, they needlessly take up memory.  
  
 Instead of using the default implementation of events that Visual Basic provides, you can use custom events to manage the memory usage more carefully.  
  
## Example  
 In this example, the class uses one instance of the <xref:System.ComponentModel.EventHandlerList*> class, stored in the `Events` field, to store information about the events in use. The <xref:System.ComponentModel.EventHandlerList*> class is an optimized list class designed to hold delegates.  
  
 All events in the class use the `Events` field to keep track of what methods are handling each event.  
  
 [!code[VbVbalrEvents#22](../vs140/codesnippet/VisualBasic/how-to--declare-custom-events-to-conserve-memory--visual-basic-_1.vb)]  
  
## See Also  
 <xref:System.ComponentModel.EventHandlerList*>   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)   
 [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md)