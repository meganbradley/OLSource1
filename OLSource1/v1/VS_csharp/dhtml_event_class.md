---
title: "DHTML_EVENT_CLASS"
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
  - "AFXDHTML/DHTML_EVENT_CLASS"
  - "DHTML_EVENT_CLASS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_CLASS macro"
ms.assetid: 9edb5a0c-533d-44fb-9dee-41b017830a74
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_CLASS
Handles (at the document level) an event identified by `dispid` originated by any HTML element with the CSS class identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_CLASS(  
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
 An `LPCWSTR` holding the CSS class of the HTML elements sourcing the event.  
  
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