---
title: "DHTML_EVENT_ONRESIZE"
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
  - "DHTML_EVENT_ONRESIZE"
  - "AFXDHTML/DHTML_EVENT_ONRESIZE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_ONRESIZE macro"
ms.assetid: cbd38304-d18a-40f8-b5de-810913f05e1c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_ONRESIZE
Handles (at the element level) the **onresize** event. This is a nonbubbling event.  
  
## Syntax  
  
```  
  
DHTML_EVENT_ONRESIZE(  
elemName  
,   
memberFxn  
 )  
  
```  
  
#### Parameters  
 `elemName`  
 An `LPCWSTR` holding the ID of the HTML element sourcing the event.  
  
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