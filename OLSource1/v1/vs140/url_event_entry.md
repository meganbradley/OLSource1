---
title: "URL_EVENT_ENTRY"
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
  - "URL_EVENT_ENTRY"
  - "AFXDHTML/URL_EVENT_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "URL_EVENT_ENTRY macro"
ms.assetid: 6486140c-e865-462c-85db-8e36d8ddccc7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# URL_EVENT_ENTRY
Maps a URL or HTML resource to a page in a multipage dialog.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the class containing the URL event entry map. This class should derive directly or indirectly from [CMultiPageDHtmlDialog](../vs140/cmultipagedhtmldialog-class.md). The URL event entry map must be inside a [DHTML and URL event map](../vs140/begin_dhtml_url_event_map.md)).  
  
 *url*  
 The URL or HTML resource for the page.  
  
 *mapName*  
 Specifies the page whose URL is *url*. This matches *mapName* in the [BEGIN_EMBED_DHTML_EVENT_MAP](../vs140/begin_embed_dhtml_event_map.md) macro that maps events from this page.  
  
## Remarks  
 If the page is an HTML resource, *url* must be the string representation of the resource's ID number (that is, "123", not 123 or ID_HTMLRES1).  
  
 The page identifier, *mapName*, is an arbitrary symbol used to link embedded DHTML event maps to URL event entry maps. It is limited in scope to the DHTML and URL event map.  
  
## Example  
 See the example in [BEGIN_DHTML_URL_EVENT_MAP](../vs140/begin_dhtml_url_event_map.md).  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)