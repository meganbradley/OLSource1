---
title: "DHTML_EVENT_ELEMENT"
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
  - "AFXDHTML/DHTML_EVENT_ELEMENT"
  - "DHTML_EVENT_ELEMENT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_ELEMENT macro"
ms.assetid: 0c463f83-d8ce-490c-add0-d7e082260998
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_ELEMENT
Handles (at the element identified by `elemName`) an event identified by `dispid`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_ELEMENT(  
dispid  
,   
elemName  
,   
memberFxn  
 )  
  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of the event to be handled.  
  
 `elemName`  
 An `LPCWSTR` holding the ID of the HTML element sourcing the event.  
  
 `memberFxn`  
 The handler function for the event.  
  
## Remarks  
 Use this macro to add an entry to the [DHTML event map](../vs140/begin_dhtml_event_map_inline.md) in your class.  
  
 If this macro is used to handle nonbubbling events, the source of the event will be the element identified by `elemName`.  
  
 If this macro is used to handle bubbling events, the element identified by `elemName` may not be the source of the event (the source could be any element contained by `elemName`).  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)