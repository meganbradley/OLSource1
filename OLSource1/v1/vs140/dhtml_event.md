---
title: "DHTML_EVENT"
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
  - DHTML_EVENT
  - AFXDHTML/DHTML_EVENT
dev_langs: 
  - C++
helpviewer_keywords: 
  - DHTML_EVENT macro
ms.assetid: faab7fdd-30fc-43d3-a9cd-f1971febd9a6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DHTML_EVENT
Handles (at the document level) an event identified by `dispid` originated by the HTML element identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT(  
dispid  
, elemName, memberFxn )  
```  
  
#### Parameters  
 `dispid`  
 The DISPID of the event to be handled.  
  
 `elemName`  
 An `LPCWSTR` holding the ID of the HTML element sourcing the event, or **NULL** to handle document events.  
  
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