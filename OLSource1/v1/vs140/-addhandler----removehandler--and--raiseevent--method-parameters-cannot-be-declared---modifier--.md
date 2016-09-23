---
title: "&#39;AddHandler&#39;, &#39;RemoveHandler&#39; and &#39;RaiseEvent&#39; method parameters cannot be declared &#39;&lt;modifier&gt;&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc31138
  - bc31138
helpviewer_keywords: 
  - BC31138
ms.assetid: 6d8df92a-95fc-4a7d-ab1e-06d312155c55
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;AddHandler&#39;, &#39;RemoveHandler&#39; and &#39;RaiseEvent&#39; method parameters cannot be declared &#39;&lt;modifier&gt;&#39;
The parameters of the `AddHandler`, `RemoveHandler`, and `RaiseEvent` methods cannot be declared with the `Optional` or `ParamArray` modifiers.  
  
 The `Optional` or `ParamArray` modifiers are allowed only on parameters in `Declare`, `Function`, `Property`, and `Sub` declarations.  
  
 **Error ID:** BC31138  
  
### To correct this error  
  
-   Remove the `Optional` or `ParamArray` keyword from the parameter list.  
  
## See Also  
 [Event Statement](../vs140/event-statement.md)   
 [AddHandler - delete](assetId:///fc464cf8-582c-48a6-a9c2-185c4c3d5ff8)   
 [RemoveHandler - delete](assetId:///35c17f61-6e22-4b87-b6e1-3ed0c27a88a0)   
 [RaiseEvent - delete](assetId:///7f765da0-5491-40b6-9ed5-24c98f9daad9)   
 [Optional (Visual Basic)](../vs140/optional--visual-basic-.md)   
 [ParamArray](../vs140/paramarray--visual-basic-.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)