---
title: "Statement recursively calls the containing &#39;AddHandler&#39; for event &#39;&lt;eventname&gt;&#39;"
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
  - bc41998
  - vbc41998
helpviewer_keywords: 
  - BC41998
ms.assetid: 4375b191-fbd9-4e93-b9bb-9159d533ddf6
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Statement recursively calls the containing &#39;AddHandler&#39; for event &#39;&lt;eventname&gt;&#39;
The statements in the `AddHandler` accessor of an event definition must not reference the event directly.  
  
 The recommended approach is to store the list of the event's handlers as a private field in the class, structure, or module that defined the event. For more information, see [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md) and [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md).  
  
 **Error ID:** BC41998  
  
### To correct this error  
  
-   Rewrite the event definition to avoid recursion.  
  
## See Also  
 [AddHandler - delete](assetId:///fc464cf8-582c-48a6-a9c2-185c4c3d5ff8)   
 [Event Statement](../vs140/event-statement.md)   
 [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md)   
 [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md)