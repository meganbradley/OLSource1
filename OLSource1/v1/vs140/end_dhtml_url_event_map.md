---
title: "END_DHTML_URL_EVENT_MAP"
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
  - "END_DHTML_URL_EVENT_MAP"
  - "AFXDHTML/END_DHTML_URL_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "END_DHTML_URL_EVENT_MAP macro"
ms.assetid: cc4b8972-648d-4b13-a81f-bef6e52356d3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# END_DHTML_URL_EVENT_MAP
Marks the end of a DHTML and URL event map.  
  
## Syntax  
  
```  
  
END_DHTML_URL_EVENT_MAP(  
className  
)  
  
```  
  
#### Parameters  
 `className`  
 The name of the class containing the event map. This class should derive directly or indirectly from [CMultiPageDHtmlDialog](../vs140/cmultipagedhtmldialog-class.md). This should match `className` in the corresponding [BEGIN_DHTML_URL_EVENT_MAP](../vs140/begin_dhtml_url_event_map.md) macro.  
  
## Example  
 See the example in [BEGIN_DHTML_URL_EVENT_MAP](../vs140/begin_dhtml_url_event_map.md).  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Multipage DHTML and URL Event Maps (NIB)](assetId:///2a7332f0-79d7-46e4-b816-0a618c46777a)