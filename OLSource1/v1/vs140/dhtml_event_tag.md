---
title: "DHTML_EVENT_TAG"
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
  - "DHTML_EVENT_TAG"
  - "AFXDHTML/DHTML_EVENT_TAG"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_TAG macro"
ms.assetid: 2782379f-1e83-4431-8c6f-5734518bbb6a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_TAG
Handles (at the document level) an event identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> originated by any HTML element with the HTML tag identified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The dispatch ID of the event to be handled.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The HTML tag of the HTML elements sourcing the event.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The handler function for the event.  
  
## Remarks  
 Use this macro to add an entry to the [DHTML event map](../vs140/begin_dhtml_event_map_inline.md) in your class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)