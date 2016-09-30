---
title: "BEGIN_DHTML_EVENT_MAP"
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
  - "BEGIN_DHTML_EVENT_MAP"
  - "AFXDHTML/BEGIN_DHTML_EVENT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_DHTML_EVENT_MAP macro"
ms.assetid: b54a8c7c-a146-4813-9867-09ba51b36c93
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_DHTML_EVENT_MAP
Marks the beginning of the DHTML event map when placed in the source file for the class identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the class containing the DHTML event map. This class should derive directly or indirectly from [CDHtmlDialog](../vs140/cdhtmldialog-class.md) and include the [DECLARE_DHTML_EVENT_MAP](../vs140/declare_dhtml_event_map.md) macro within its class definition.  
  
## Remarks  
 Add a DHTML event map to your class to provide information to **CDHtmlDialog** that can be used to route events fired by HTML elements or ActiveX controls in a web page to handler functions in your class.  
  
 Place the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro in the class's implementation (.cpp) file followed by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macros for the events the class is to handle (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for mouseover events). Use the [END_DHTML_EVENT_MAP](../vs140/end_dhtml_event_map.md) macro to mark the end of the event map. These macros implement the following function:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [BEGIN_DHTML_EVENT_MAP_INLINE](../vs140/begin_dhtml_event_map_inline.md)