---
title: "CMFCEditBrowseCtrl::OnDrawBrowseButton"
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
  - "CMFCEditBrowseCtrl::OnDrawBrowseButton"
  - "CMFCEditBrowseCtrl.OnDrawBrowseButton"
  - "OnDrawBrowseButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawBrowseButton method"
ms.assetid: c3d2b39f-d72d-4a6d-a4af-111a8db33ea6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCEditBrowseCtrl::OnDrawBrowseButton
Called by the framework to draw the browse button on the edit browse control.  
  
## Syntax  
  
```  
virtual void OnDrawBrowseButton(  
   CDC* pDC,  
   CRect rect,  
   BOOL bIsButtonPressed,  
   BOOL bIsButtonHot  
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to a device context.  
  
 `Rect`  
 The bounding rectangle of the browse button.  
  
 `bIsButtonPressed`  
 `TRUE` if the button is pressed; otherwise, `FALSE`.  
  
 `bIsButtonHot`  
 `TRUE` if the button is highlighted; otherwise, `FALSE`.  
  
## Remarks  
 Override this function in a derived class to customize the appearance of the browse button.  
  
## Requirements  
 **Header:** afxeditbrowsectrl.h  
  
## See Also  
 [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)