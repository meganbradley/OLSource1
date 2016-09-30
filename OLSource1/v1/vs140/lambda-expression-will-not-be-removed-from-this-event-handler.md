---
title: "Lambda expression will not be removed from this event handler"
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
  - "bc42326"
  - "vbc42326"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42326"
ms.assetid: 63214dc6-0112-4245-8ebf-7c9e8f5a5782
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda expression will not be removed from this event handler
Lambda expression will not be removed from this event handler. Assign the lambda expression to a variable and use the variable to add and remove the event.  
  
 When lambda expressions are used with event handlers, you may not see the behavior you expect. The compiler generates a new method for each lambda expression definition, even if they are identical. Therefore, the following code displays <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When lambda expressions are used with event handlers, this may cause unexpected results. In the following example, the lambda expression added by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not removed by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 By default, this message is a warning. For more information about how to hide warnings or treat warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42326  
  
### To correct this error  
  
-   To avoid the warning and remove the lambda expression, assign the lambda expression to a variable and use the variable in both the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statements, as shown in the following example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)