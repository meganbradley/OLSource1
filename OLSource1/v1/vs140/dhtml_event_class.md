---
title: "DHTML_EVENT_CLASS"
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
  - "AFXDHTML/DHTML_EVENT_CLASS"
  - "DHTML_EVENT_CLASS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML_EVENT_CLASS macro"
ms.assetid: 9edb5a0c-533d-44fb-9dee-41b017830a74
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTML_EVENT_CLASS
Handles (at the document level) an event identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> originated by any HTML element with the CSS class identified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The dispatch ID of the event to be handled.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> holding the CSS class of the HTML elements sourcing the event.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The handler function for the event.  
  
## Remarks  
 Use this macro to add an entry to the [DHTML event map](../vs140/begin_dhtml_event_map_inline.md) in your class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Event Maps](../vs140/dhtml-event-maps.md)   
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)