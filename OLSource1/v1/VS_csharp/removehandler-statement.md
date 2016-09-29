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
  
```  
RemoveHandler event, AddressOf eventhandler  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`event`|The name of the event being handled.|  
|`eventhandler`|The name of the procedure currently handling the event.|  
  
## Remarks  
 The `AddHandler` and `RemoveHandler` statements allow you to start and stop event handling for a specific event at any time during program execution.  
  
> [!NOTE]
>  For custom events, the `RemoveHandler` statement invokes the event's `RemoveHandler` accessor. For more information on custom events, see [Event Statement](../VS_csharp/event-statement.md).  
  
## Example  
 [!code[VbVbalrEvents#17](../VS_csharp/codesnippet/VisualBasic/removehandler-statement_1.vb)]  
  
## See Also  
 [AddHandler Statement](../VS_csharp/addhandler-statement.md)   
 [Handles](../VS_csharp/handles-clause--visual-basic-.md)   
 [Event Statement](../VS_csharp/event-statement.md)   
 [Events (Visual Basic)](../VS_csharp/events--visual-basic-.md)