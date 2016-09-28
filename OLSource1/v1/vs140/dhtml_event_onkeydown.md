---
title: "DHTML_EVENT_ONKEYDOWN"
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
  - "DHTML_EVENT_ONKEYDOWN"
  - "AFXDHTML/DHTML_EVENT_ONKEYDOWN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_ONKEYDOWN macro"
ms.assetid: 2791a620-b2fd-4b6b-a373-5a36fbed6b21
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_ONKEYDOWN
Handles (at the document level) the **onkeydown** event originated by the HTML element identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_ONKEYDOWN(  
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
 Use this macro to add an entry to the [DHTML event map](../vs140/begin_dhtml_event_map_inline.md) in your class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)