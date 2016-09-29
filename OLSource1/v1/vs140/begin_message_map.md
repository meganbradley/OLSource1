---
title: "BEGIN_MESSAGE_MAP"
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
  - "AFXWIN/BEGIN_MESSAGE_MAP"
  - "BEGIN_MESSAGE_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message map macros"
  - "BEGIN_MESSAGE_MAP macro"
ms.assetid: d9201e18-04e0-4639-9810-f15768627fc2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_MESSAGE_MAP
Begins the definition of your message map.  
  
## Syntax  
  
```  
  
BEGIN_MESSAGE_MAP(  
theClass  
,   
baseClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the class whose message map this is.  
  
 `baseClass`  
 Specifies the name of the base class of `theClass`.  
  
## Remarks  
 In the implementation (.cpp) file that defines the member functions for your class, start the message map with the `BEGIN_MESSAGE_MAP` macro, then add macro entries for each of your message-handler functions, and complete the message map with the `END_MESSAGE_MAP` macro.  
  
 For more information about message maps, see [Message Maps (MFC)](../vs140/message-maps--mfc-.md)  
  
## Example  
 [!code[NVC_MFCListView#10](../vs140/codesnippet/CPP/begin_message_map_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Message Maps (MFC)](../vs140/message-maps--mfc-.md)   
 [DECLARE_MESSAGE_MAP](../vs140/declare_message_map.md)   
 [END_MESSAGE_MAP](../vs140/end_message_map.md)   
 [BEGIN_TEMPLATE_MESSAGE_MAP](../vs140/begin_template_message_map.md)