---
title: "CMFCVisualManager::OnDrawStatusBarPaneBorder"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCVisualManager::OnDrawStatusBarPaneBorder
  - CMFCVisualManager.OnDrawStatusBarPaneBorder
  - OnDrawStatusBarPaneBorder
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawStatusBarPaneBorder method
ms.assetid: 2d459de6-5cb5-4600-820d-23bc0a86da85
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawStatusBarPaneBorder
The framework calls this method when it draws the border for a [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawStatusBarPaneBorder(  
   CDC* pDC,  
   CMFCStatusBar* pBar,  
   CRect rectPane,  
   UINT uiID,  
   UINT nStyle  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pBar`  
 A pointer to a `CMFCStatusBar` object. The framework draws this status bar object.  
  
 [in] `rectPane`  
 A rectangle that specifies the boundaries of the status bar.  
  
 [in] `uiID`  
 The ID of the status bar.  
  
 [in] `nStyle`  
 The style of the status bar.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a `CMFCStatusBar` object.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)