---
title: "BEGIN_EVENT_MAP"
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
  - "BEGIN_EVENT_MAP"
  - "AFXCTL/BEGIN_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_EVENT_MAP macro"
ms.assetid: bfafa9d7-cd14-42d8-823d-9e7c04c3e9a5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_EVENT_MAP
Begins the definition of your event map.  
  
## Syntax  
  
```  
  
BEGIN_EVENT_MAP(  
theClass  
,   
baseClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the control class whose event map this is.  
  
 `baseClass`  
 Specifies the name of the base class of `theClass`.  
  
## Remarks  
 In the implementation (.cpp) file that defines the member functions for your class, start the event map with the `BEGIN_EVENT_MAP` macro, then add macro entries for each of your events, and complete the event map with the `END_EVENT_MAP` macro.  
  
 For more information on event maps and the `BEGIN_EVENT_MAP` macro, see the article [ActiveX Controls: Events](../vs140/mfc-activex-controls--events.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_EVENT_MAP](../vs140/declare_event_map.md)   
 [END_EVENT_MAP](../vs140/end_event_map.md)