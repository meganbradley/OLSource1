---
title: "CMFCToolBarButton::SaveBarState"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMFCToolBarButton::SaveBarState"
  - "CMFCToolBarButton.SaveBarState"
  - "SaveBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveBarState method"
ms.assetid: f6a090c1-f4ce-41c6-855a-c1dcd220f7d3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SaveBarState
Saves the state of the toolbar button.  
  
## Syntax  
  
```  
virtual void SaveBarState();  
```  
  
## Remarks  
 The framework calls this method when it creates a `CMFCToolBarButton` object as the result of a drag-and-drop operation.  
  
 The default implementation of this method does nothing. Override this method to save the state of the toolbar button to an external data source.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)