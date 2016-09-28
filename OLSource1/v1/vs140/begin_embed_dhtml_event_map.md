---
title: "BEGIN_EMBED_DHTML_EVENT_MAP"
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
  - "BEGIN_EMBED_DHTML_EVENT_MAP"
  - "AFXDHTML/BEGIN_EMBED_DHTML_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_EMBED_DHTML_EVENT_MAP macro"
ms.assetid: 5346210f-f8b7-4e28-9d2c-d9d7fd42421d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_EMBED_DHTML_EVENT_MAP
Starts the definition of an embedded DHTML event map in a multipage dialog.  
  
## Syntax  
  
```  
  
BEGIN_EMBED_DHTML_EVENT_MAP(  
className  
,   
mapName  
 )  
  
```  
  
#### Parameters  
 `className`  
 The name of the class containing the event map. This class should derive directly or indirectly from [CMultiPageDHtmlDialog](../vs140/cmultipagedhtmldialog-class.md). The embedded DHTML event map must be inside a [DHTML and URL event map](../vs140/begin_dhtml_url_event_map.md)).  
  
 *mapName*  
 Specifies the page whose event map this is. This matches *mapName* in the [URL_EVENT_ENTRY](../vs140/url_event_entry.md) macro actually defining the URL or HTML resource.  
  
## Remarks  
 Because a multipage DHTML dialog consists of multiple HTML pages, each of which can raise DHTML events, embedded event maps are used to map events to handlers on a per-page basis.  
  
 Embedded event maps within a DHTML and URL event map consist of a `BEGIN_EMBED_DHTML_EVENT_MAP` macro followed by [DHTML_EVENT](../vs140/dhtml-event-maps.md) macros and an [END_EMBED_DHTML_EVENT_MAP](../vs140/end_embed_dhtml_event_map.md) macro.  
  
 Each embedded event map requires a corresponding [URL event entry](../vs140/url_event_entry.md) to map *mapName* (specified in `BEGIN_EMBED_DHTML_EVENT_MAP`) to a URL or HTML resource.  
  
## Example  
 See the example in [BEGIN_DHTML_URL_EVENT_MAP](../vs140/begin_dhtml_url_event_map.md).  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)