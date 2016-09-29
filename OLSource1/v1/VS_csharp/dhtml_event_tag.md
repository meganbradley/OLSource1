---
title: "DHTML_EVENT_TAG"
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
  - "DHTML_EVENT_TAG"
  - "AFXDHTML/DHTML_EVENT_TAG"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_TAG macro"
ms.assetid: 2782379f-1e83-4431-8c6f-5734518bbb6a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_TAG
Handles (at the document level) an event identified by `dispid` originated by any HTML element with the HTML tag identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_TAG(  
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
 The HTML tag of the HTML elements sourcing the event.  
  
 `memberFxn`  
 The handler function for the event.  
  
## Remarks  
 Use this macro to add an entry to the [DHTML event map](../VS_csharp/begin_dhtml_event_map_inline.md) in your class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../VS_csharp/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../VS_csharp/cdhtmldialog-class.md)