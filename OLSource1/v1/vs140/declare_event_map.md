---
title: "DECLARE_EVENT_MAP"
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
  - "DECLARE_EVENT_MAP"
  - "AFXCTL/DECLARE_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_EVENT_MAP macro"
ms.assetid: cd25283d-ea94-40f3-91df-89c84a328ed0
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_EVENT_MAP
Each `COleControl`-derived class in your program can provide an event map to specify the events your control will fire.  
  
## Syntax  
  
```  
  
DECLARE_EVENT_MAP( )  
```  
  
## Remarks  
 Use the `DECLARE_EVENT_MAP` macro at the end of your class declaration. Then, in the .cpp file that defines the member functions for the class, use the `BEGIN_EVENT_MAP` macro, macro entries for each of the control's events, and the `END_EVENT_MAP` macro to declare the end of the event list.  
  
 For more information on event maps, see the article [ActiveX Controls: Events](../vs140/mfc-activex-controls--events.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_EVENT_MAP](../vs140/begin_event_map.md)   
 [END_EVENT_MAP](../vs140/end_event_map.md)   
 [EVENT_CUSTOM](../vs140/event_custom.md)   
 [EVENT_CUSTOM_ID](../vs140/event_custom_id.md)