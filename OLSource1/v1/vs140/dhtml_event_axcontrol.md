---
title: "DHTML_EVENT_AXCONTROL"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DHTML_EVENT_AXCONTROL
  - AFXDHTML/DHTML_EVENT_AXCONTROL
dev_langs: 
  - C++
helpviewer_keywords: 
  - DHTML_EVENT_AXCONTROL macro
ms.assetid: b20f8e2a-e007-4f52-a1b2-e27e307a7127
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DHTML_EVENT_AXCONTROL
Handles the event identified by `dispid` fired by the ActiveX control identified by `controlName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_AXCONTROL(  
dispid  
,   
controlName  
,   
memberFxn  
 )  
  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of the event to be handled.  
  
 `controlName`  
 An `LPCWSTR` holding the HTML ID of the control firing the event.  
  
 `memberFxn`  
 The handler function for the event.  
  
## Remarks  
 Use this macro to add an entry to the [DHTML event map](../vs140/begin_dhtml_event_map_inline.md) in your class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)