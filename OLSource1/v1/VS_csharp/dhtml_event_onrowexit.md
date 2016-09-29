---
title: "DHTML_EVENT_ONROWEXIT"
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
  - "DHTML_EVENT_ONROWEXIT"
  - "AFXDHTML/DHTML_EVENT_ONROWEXIT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_ONROWEXIT macro"
ms.assetid: f263563e-de6b-451b-85dc-ca6c596ac891
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_ONROWEXIT
Handles (at the document level) the **onrowexit** event originated by the HTML element identified by `elemName`.  
  
## Syntax  
  
```  
  
DHTML_EVENT_ONROWEXIT(  
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