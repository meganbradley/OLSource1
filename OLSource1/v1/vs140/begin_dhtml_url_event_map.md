---
title: "BEGIN_DHTML_URL_EVENT_MAP"
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
  - "BEGIN_DHTML_URL_EVENT_MAP"
  - "AFXDHTML/BEGIN_DHTML_URL_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_DHTML_URL_EVENT_MAP macro"
ms.assetid: 471ecb6e-d13f-4bad-b787-cf28daf5743b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_DHTML_URL_EVENT_MAP
Starts the definition of a DHTML and URL event map in a multipage dialog.  
  
## Syntax  
  
```  
  
BEGIN_DHTML_URL_EVENT_MAP( )  
  
```  
  
## Remarks  
 Put `BEGIN_DHTML_URL_EVENT_MAP` in the implementation file of your [CMultiPageDHtmlDialog](../vs140/cmultipagedhtmldialog-class.md)-derived class. Follow it with [embedded DHTML event maps](../vs140/begin_embed_dhtml_event_map.md) and [URL entries](../vs140/begin_url_entries.md), and then close it with [END_DHTML_URL_EVENT_MAP](../vs140/end_dhtml_url_event_map.md). Include the [DECLARE_DHTML_URL_EVENT_MAP](../vs140/declare_dhtml_url_event_map.md) macro within the class definition.  
  
## Example  
 [!code[NVC_MFCDocView#196](../vs140/codesnippet/CPP/begin_dhtml_url_event_map_1.cpp)]  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)