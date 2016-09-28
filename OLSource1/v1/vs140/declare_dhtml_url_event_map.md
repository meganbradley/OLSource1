---
title: "DECLARE_DHTML_URL_EVENT_MAP"
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
  - "DECLARE_DHTML_URL_EVENT_MAP"
  - "AFXDHTML/DECLARE_DHTML_URL_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_DHTML_URL_EVENT_MAP macro"
ms.assetid: 03d80959-334f-44ef-b3e3-b422dca2a92f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_DHTML_URL_EVENT_MAP
Declares a DHTML and URL event map in a class definition.  
  
## Syntax  
  
```  
  
DECLARE_DHTML_URL_EVENT_MAP( )  
  
```  
  
## Remarks  
 This macro is to be used in the definition of [CMultiPageDHtmlDialog](../vs140/cmultipagedhtmldialog-class.md)-derived classes.  
  
 A DHTML and URL event map contains [embedded DHTML event maps](../vs140/begin_embed_dhtml_event_map.md) and [URL event entries](../vs140/begin_url_entries.md) to map DHTML events to handlers on a per-page basis. Use [BEGIN_DHTML_URL_EVENT_MAP](../vs140/begin_dhtml_url_event_map.md) to implement the map.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)