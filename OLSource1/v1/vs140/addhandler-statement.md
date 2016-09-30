---
title: "AddHandler Statement"
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
  - "vb.AddHandlerMethod"
  - "addhandler"
  - "vb.addhandler"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "AddHandler statement"
ms.assetid: cfe69799-2a0f-42c0-a99e-09fed954da01
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AddHandler Statement
Associates an event with an event handler at run time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the event to handle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a procedure that handles the event.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements allow you to start and stop event handling at any time during program execution.  
  
 The signature of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure must match the signature of the event <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement both allow you to specify that particular procedures handle particular events, but there are differences. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement connects procedures to events at run time. Use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword when defining a procedure to specify that it handles a particular event. For more information, see [Handles](../vs140/handles-clause--visual-basic-.md).  
  
> [!NOTE]
>  For custom events, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement invokes the event's <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> accessor. For more information on custom events, see [Event Statement](../vs140/event-statement.md).  
  
## Example  
 [!code[VbVbalrEvents#17](../vs140/codesnippet/VisualBasic/addhandler-statement_1.vb)]  
  
## See Also  
 [RemoveHandler Statement](../vs140/removehandler-statement.md)   
 [Handles](../vs140/handles-clause--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)