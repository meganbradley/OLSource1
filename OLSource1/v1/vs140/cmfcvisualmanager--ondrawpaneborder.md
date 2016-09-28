---
title: "CMFCVisualManager::OnDrawPaneBorder"
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
  - "CMFCVisualManager.OnDrawPaneBorder"
  - "CMFCVisualManager::OnDrawPaneBorder"
  - "OnDrawPaneBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPaneBorder method"
ms.assetid: 7c8b003c-1761-4400-984f-02408c906189
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawPaneBorder
The framework calls this method when it draws the border of a [CPane Class](../vs140/cpane-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawPaneBorder(  
   CDC* pDC,  
   CBasePane* pBar,  
   CRect& rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context of a control bar.  
  
 [in] `pBar`  
 A pointer to a pane. The visual manager draws the border of this pane.  
  
 [in] `rect`  
 A rectangle that indicates the boundaries of the pane.  
  
## Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived class to customize the appearance of the border.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)