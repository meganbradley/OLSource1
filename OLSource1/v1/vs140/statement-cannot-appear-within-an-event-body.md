---
title: "Statement cannot appear within an event body"
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
  - bc31112
  - vbc31112
helpviewer_keywords: 
  - BC31112
ms.assetid: fd51fc53-a008-4b79-85fb-2d9fa1fb5a79
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Statement cannot appear within an event body
Statement cannot appear within an event body. End of event assumed.  
  
 A statement that is not valid inside an event body appears inside one.  
  
 **Error ID:** BC31112  
  
### To correct this error  
  
-   Add an `End Event` before the statement.  
  
## See Also  
 [Application Events Sample](assetId:///289a787f-b97e-43c8-a304-fe95e45f4a0d)   
 [Event Statement](../vs140/event-statement.md)