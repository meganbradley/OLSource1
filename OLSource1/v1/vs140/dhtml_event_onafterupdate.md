---
title: "DHTML_EVENT_ONAFTERUPDATE"
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
  - "DHTML_EVENT_ONAFTERUPDATE"
  - "AFXDHTML/DHTML_EVENT_ONAFTERUPDATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_ONAFTERUPDATE macro"
ms.assetid: 8b54ddbb-2700-4505-bdda-4cc3c81bec7e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_ONAFTERUPDATE
Handles (at the document level) the **onafterupdate** event originated by the HTML element identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_ONAFTERUPDATE(  
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