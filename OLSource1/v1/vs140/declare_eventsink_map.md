---
title: "DECLARE_EVENTSINK_MAP"
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
  - "DECLARE_EVENTSINK_MAP"
  - "AFXWIN/DECLARE_EVENTSINK_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_EVENTSINK_MAP macro"
ms.assetid: ee957771-3d0d-4d91-84db-345b9034e4f1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_EVENTSINK_MAP
An OLE container can provide an event sink map to specify the events your container will be notified of.  
  
## Syntax  
  
```  
  
DECLARE_EVENTSINK_MAP( )  
```  
  
## Remarks  
 Use the `DECLARE_EVENTSINK_MAP` macro at the end of your class declaration. Then, in the .CPP file that defines the member functions for the class, use the `BEGIN_EVENTSINK_MAP` macro, macro entries for each of the events to be notified of, and the `END_EVENTSINK_MAP` macro to declare the end of the event sink list.  
  
 For more information on event sink maps, see the article [ActiveX Control Containers](../vs140/activex-control-containers.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_EVENTSINK_MAP](../vs140/begin_eventsink_map.md)   
 [END_EVENTSINK_MAP](../vs140/end_eventsink_map.md)   
 [ON_EVENT](../vs140/on_event.md)   
 [ON_PROPNOTIFY](../vs140/on_propnotify.md)