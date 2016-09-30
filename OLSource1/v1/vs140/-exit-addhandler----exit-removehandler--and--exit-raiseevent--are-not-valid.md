---
title: "&#39;Exit AddHandler&#39;, &#39;Exit RemoveHandler&#39; and &#39;Exit RaiseEvent&#39; are not valid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31111"
  - "bc31111"
helpviewer_keywords: 
  - "BC31111"
ms.assetid: e02264f3-0645-4de5-b622-8a2a74496b64
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Exit AddHandler&#39;, &#39;Exit RemoveHandler&#39; and &#39;Exit RaiseEvent&#39; are not valid
'Exit AddHandler', 'Exit RemoveHandler' and 'Exit RaiseEvent' are not valid. Use 'Return' to exit from event members.  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement cannot be used to exit <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> declaration. Instead, use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, without specifying a return expression, to exit the method.  
  
 **Error ID:** BC31111  
  
### To correct this error  
  
-   Replace the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement with a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement.  
  
     Make sure the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement does not specify a return expression.  
  
## See Also  
 [Event Statement](../vs140/event-statement.md)   
 [AddHandler - delete](assetId:///fc464cf8-582c-48a6-a9c2-185c4c3d5ff8)   
 [RemoveHandler - delete](assetId:///35c17f61-6e22-4b87-b6e1-3ed0c27a88a0)   
 [RaiseEvent - delete](assetId:///7f765da0-5491-40b6-9ed5-24c98f9daad9)   
 [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)