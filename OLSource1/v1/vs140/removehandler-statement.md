---
title: "RemoveHandler Statement"
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
  - "vb.RemoveHandlerMethod"
  - "vb.RemoveHandler"
  - "RemoveHandler"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "RemoveHandler keyword"
  - "RemoveHandler statement"
ms.assetid: 647cd825-e877-4910-b4f1-8d168beebe6a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RemoveHandler Statement
Removes the association between an event and an event handler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The name of the event being handled.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The name of the procedure currently handling the event.|  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements allow you to start and stop event handling for a specific event at any time during program execution.  
  
> [!NOTE]
>  For custom events, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement invokes the event's <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> accessor. For more information on custom events, see [Event Statement](../vs140/event-statement.md).  
  
## Example  
 [!code[VbVbalrEvents#17](../vs140/codesnippet/VisualBasic/removehandler-statement_1.vb)]  
  
## See Also  
 [AddHandler Statement](../vs140/addhandler-statement.md)   
 [Handles](../vs140/handles-clause--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)