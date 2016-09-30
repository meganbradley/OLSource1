---
title: "How to: Declare Custom Events To Avoid Blocking (Visual Basic)"
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
ms.assetid: 998b6a90-67c5-4d2c-8b11-366d3e355505
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Custom Events To Avoid Blocking (Visual Basic)
There are several circumstances when it is important that one event handler not block subsequent event handlers. Custom events allow the event to call its event handlers asynchronously.  
  
 By default, the backing-store field for an event declaration is a multicast delegate that serially combines all the event handlers. This means that if one handler takes a long time to complete, it blocks the other handlers until it completes. (Well-behaved event handlers should never perform lengthy or potentially blocking operations.)  
  
 Instead of using the default implementation of events that Visual Basic provides, you can use a custom event to execute the event handlers asynchronously.  
  
## Example  
 In this example, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> accessor adds the delegate for each handler of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> event to an \<xref:System.Collections.ArrayList*> stored in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field.  
  
 When code raises the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> event, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> accessor invokes all the event handler delegates asynchronously using the \<xref:System.Web.Services.Protocols.LogicalMethodInfo.BeginInvoke*> method. That method invokes each handler on a worker thread and returns immediately, so handlers cannot block one another.  
  
 [!code[VbVbalrEvents#27](../vs140/codesnippet/VisualBasic/how-to--declare-custom-events-to-avoid-blocking--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Collections.ArrayList*>   
 \<xref:System.Web.Services.Protocols.LogicalMethodInfo.BeginInvoke*>   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)   
 [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md)