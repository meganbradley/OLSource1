---
title: "messages::close"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Close"
  - "close"
  - "messages.close"
  - "xlocmes/std::messages::close"
  - "std::messages::close"
  - "messages::close"
  - "std.messages.close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "close method"
ms.assetid: f160ca8c-823c-499f-8c59-61eb3cc95d6c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# messages::close
Closes the message catalog.  
  
## Syntax  
  
```  
void close(  
    catalog _Catval  
) const;  
```  
  
#### Parameters  
 `_Catval`  
 The catalog to be closed.  
  
## Remarks  
 The member function calls [do_close](../vs140/messages--do_close.md)(_*Catval*).  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)