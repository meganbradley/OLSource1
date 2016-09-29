---
title: "CMFCToolBarButton::CanBeStored"
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
  - "CMFCToolBarButton::CanBeStored"
  - "CMFCToolBarButton.CanBeStored"
  - "CanBeStored"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeStored method"
ms.assetid: 39b6ccf2-e05e-422d-b33d-e23ca0e446b6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::CanBeStored
Determines whether the button can be stored.  
  
## Syntax  
  
```  
virtual BOOL CanBeStored() const;  
```  
  
## Return Value  
 This method returns `TRUE`.  
  
## Remarks  
 The framework uses this method to determine whether the button can participate in a drag-and-drop operation.  
  
 The default implementation returns `TRUE`. Override this method if your button cannot be stored as part of a drag-and-drop operation. For more information about drag-and-drop operations, see [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md)