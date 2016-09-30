---
title: "Frame Window Classes (Architecture)"
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
  - "vc.classes.frame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frame window classes, document/view architecture"
ms.assetid: 5da01fb4-f531-46cc-914f-e422e4f07f5d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Frame Window Classes (Architecture)
In document/view architecture, frame windows are windows that contain a view window. They also support having control bars attached to them.  
  
 In multiple document interface (MDI) applications, the main window is derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. It indirectly contains the documents' frames, which are <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects, in turn, contain the documents' views.  
  
 In single document interface (SDI) applications, the main window, derived from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, contains the view of the current document.  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
 The base class for an SDI application's main frame window. Also the base class for all other frame window classes.  
  
 [CMDIFrameWnd](../vs140/cmdiframewnd-class.md)  
 The base class for an MDI application's main frame window.  
  
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)  
 The base class for an MDI application's document frame windows.  
  
 [COleIPFrameWnd](../vs140/coleipframewnd-class.md)  
 Provides the frame window for a view when a server document is being edited in place.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)