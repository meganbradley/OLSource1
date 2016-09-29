---
title: "CMFCVisualManager::OnDrawHeaderCtrlBorder"
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
  - "CMFCVisualManager.OnDrawHeaderCtrlBorder"
  - "CMFCVisualManager::OnDrawHeaderCtrlBorder"
  - "OnDrawHeaderCtrlBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawHeaderCtrlBorder method"
ms.assetid: a1cb9a6c-1ae5-4b24-9a14-09d7fdaa8ed1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawHeaderCtrlBorder
The framework calls this method when it draws the border around an instance of the [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawHeaderCtrlBorder(  
   CMFCHeaderCtrl* pCtrl,  
   CDC* pDC,  
   CRect& rect,  
   BOOL bIsPressed,  
   BOOL bIsHighlighted   
);  
```  
  
#### Parameters  
 [in] `pCtrl`  
 A pointer to a `CMFCHeaderCtrl` object. The framework draws the border of this header control.  
  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the header control.  
  
 [in] `bIsPressed`  
 A Boolean parameter that indicates whether the header control is pressed.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the header control is highlighted.  
  
## Remarks  
 Override this method in a derived visual manager to customize the border of the header control.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)