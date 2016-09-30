---
title: "Rubber-Banding and Trackers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "trackers"
  - "CRectTracker class, implementing trackers"
  - "OLE objects, selecting"
  - "rubber banding"
  - "WM_LBUTTONDOWN"
ms.assetid: 0d0fa64c-6418-4baf-ab7f-2d16ca039230
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Rubber-Banding and Trackers
Another feature supplied with trackers is the "rubber-band" selection, which allows a user to select multiple OLE items by dragging a sizing rectangle around the items to be selected. When the user releases the left mouse button, items within the region selected by the user are selected and can be manipulated by the user. For instance, the user might drag the selection into another container application.  
  
 Implementing this feature requires some additional code in your application's <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> handler function.  
  
 The following code sample implements rubber-band selection and additional features.  
  
 [!code[NVC_MFCOClient#6](../vs140/codesnippet/CPP/rubber-banding-and-trackers_1.cpp)]  
  
 If you want to allow reversible orientation of the tracker during rubber-banding, you should call [CRectTracker::TrackRubberBand](../vs140/crecttracker--trackrubberband.md) with the third parameter set to **TRUE**. Remember that allowing reversible orientation will sometimes cause [CRectTracker::m_rect](../vs140/crecttracker--m_rect.md) to become inverted. This can be corrected by a call to [CRect::NormalizeRect](../vs140/crect--normalizerect.md).  
  
 For more information, see [Container Client Items](../vs140/containers--client-items.md) and [Customizing Drag and Drop](../vs140/drag-and-drop--customizing.md).  
  
## See Also  
 [Trackers: Implementing Trackers in Your OLE Application](../vs140/trackers--implementing-trackers-in-your-ole-application.md)   
 [CRectTracker Class](../vs140/crecttracker-class.md)