---
title: "BEGIN_URL_ENTRIES"
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
  - "BEGIN_URL_ENTRIES"
  - "AFXDHTML/BEGIN_URL_ENTRIES"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_URL_ENTRIES macro"
ms.assetid: 028d4de7-3e2b-48b6-8e3e-7774df6bf380
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_URL_ENTRIES
Starts the definition of a URL event entry map in a multipage dialog.  
  
## Syntax  
  
```  
  
BEGIN_URL_ENTRIES(  
className )  
```  
  
#### Parameters  
 `className`  
 The name of the class containing the URL event entry map. This class should derive directly or indirectly from [CMultiPageDHtmlDialog](../VS_csharp/cmultipagedhtmldialog-class.md). The URL event entry map must be inside a [DHTML and URL event map](../VS_csharp/begin_dhtml_url_event_map.md)).  
  
## Remarks  
 Because a multipage DHTML dialog consists of multiple HTML pages, URL event entries are used to map URLs or HTML resources to corresponding [embedded DHTML event maps](../VS_csharp/begin_embed_dhtml_event_map.md). Put `URL_EVENT_ENTRY` macros between `BEGIN_URL_ENTRIES` and [END_URL_ENTRIES](../VS_csharp/end_url_entries.md) macros.  
  
## Example  
 See the example in [BEGIN_DHTML_URL_EVENT_MAP](../VS_csharp/begin_dhtml_url_event_map.md).  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)