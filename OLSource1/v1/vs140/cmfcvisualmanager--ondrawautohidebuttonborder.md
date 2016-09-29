---
title: "CMFCVisualManager::OnDrawAutoHideButtonBorder"
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
  - "CMFCVisualManager::OnDrawAutoHideButtonBorder"
  - "OnDrawAutoHideButtonBorder"
  - "CMFCVisualManager.OnDrawAutoHideButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawAutoHideButtonBorder method"
ms.assetid: 7e809b7d-fd6a-406e-9bbd-42eb02f794d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawAutoHideButtonBorder
The framework calls this method when it draws the border of an auto-hide button.  
  
## Syntax  
  
```  
virtual void OnDrawAutoHideButtonBorder(  
   CDC* pDC,  
   CRect rectBounds,  
   CRect rectBorderSize,  
   CMFCAutoHideButton* pButton   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectBounds`  
 The size and location of the auto-hide button.  
  
 [in] `rectBorderSize`  
 A [CRect](../vs140/crect-class.md) parameter that contains the sizes of the borders.  
  
 [in] `pButton`  
 A pointer to the auto-hide button. The framework is drawing the border for this button.  
  
## Remarks  
 Override this method in a derived class if you want to customize the appearance of the border of an auto-hide button. By default, this method fills a flat border with the default shadow color for your application.  
  
 The `rectBorderSize` parameter does not contain the coordinates of the border. It contains the size of the border in the `top`, `bottom`, `left`, and `right` data members. A value less than or equal to 0 indicates no border on that side of the auto-hide button.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)