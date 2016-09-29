---
title: "BEGIN_DHTML_EVENT_MAP_INLINE"
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
  - "AFXDHTML/BEGIN_DHTML_EVENT_MAP_INLINE"
  - "BEGIN_DHTML_EVENT_MAP_INLINE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event maps, DHTML"
  - "BEGIN_DHTML_EVENT_MAP_INLINE macro"
  - "DHTML events, event map"
  - "DHTML events"
ms.assetid: ca0027e2-6d1d-4406-92bb-b8df50b925b9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_DHTML_EVENT_MAP_INLINE
Marks the beginning of the DHTML event map within the class definition for `className`.  
  
## Syntax  
  
```  
  
BEGIN_DHTML_EVENT_MAP_INLINE(  
className  
 )  
  
```  
  
#### Parameters  
 `className`  
 The name of the class containing the DHTML event map. This class should derive directly or indirectly from [CDHtmlDialog](../vs140/cdhtmldialog-class.md) and include the [DECLARE_DHTML_EVENT_MAP](../vs140/declare_dhtml_event_map.md) macro within its class definition.  
  
## Remarks  
 Add a DHTML event map to your class to provide information to **CDHtmlDialog** that can be used to route events fired by HTML elements or ActiveX controls in a web page to handler functions in your class.  
  
 Place the `BEGIN_DHTML_EVENT_MAP` macro in the class's definition (.h) file followed by `DHTML_EVENT` macros for the events the class is to handle (for example, `DHTML_EVENT_ONMOUSEOVER` for mouseover events). Use the [END_DHTML_EVENT_MAP_INLINE](../vs140/end_dhtml_event_map_inline.md) macro to mark the end of the event map. These macros implement the following function:  
  
 `virtual const DHtmlEventMapEntry* GetDHtmlEventMap();`  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [BEGIN_DHTML_EVENT_MAP](../vs140/begin_dhtml_event_map.md)