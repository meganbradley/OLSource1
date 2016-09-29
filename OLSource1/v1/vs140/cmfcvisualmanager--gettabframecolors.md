---
title: "CMFCVisualManager::GetTabFrameColors"
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
  - "GetTabFrameColors"
  - "CMFCVisualManager::GetTabFrameColors"
  - "CMFCVisualManager.GetTabFrameColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabFrameColors method"
ms.assetid: 34e1a4dc-fee9-403a-89f7-85f8b43b5532
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetTabFrameColors
The framework calls this function when it has to retrieve the set of colors for drawing a tab window.  
  
## Syntax  
  
```  
virtual void GetTabFrameColors(  
   const CMFCBaseTabCtrl* pTabWnd,  
   COLORREF& clrDark,  
   COLORREF& clrBlack,  
   COLORREF& clrHighlight,  
   COLORREF& clrFace,  
   COLORREF& clrDarkShadow,  
   COLORREF& clrLight,  
   CBrush*& pbrFace,  
   CBrush*& pbrBlack   
);  
```  
  
#### Parameters  
 [in] `pTabWnd`  
 A pointer to the tabbed window where the frame is drawing a tab.  
  
 [out] `clrDark`  
 A reference to a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter where this method stores the color for the dark border of a tab.  
  
 [out] `clrBlack`  
 A reference to a `COLORREF` parameter where this method stores the color for the border of the tab window. The default color for the border is black.  
  
 [out] `clrHighlight`  
 A reference to a `COLORREF` parameter where this method stores the color for the highlight state of the tab window.  
  
 [out] `clrFace`  
 A reference to a `COLORREF` parameter where this method stores the color for face of the tab window.  
  
 [out] `clrDarkShadow`  
 A reference to a `COLORREF` parameter where this method stores the color for the shadow of the tab window.  
  
 [out] `clrLight`  
 A reference to a `COLORREF` parameter where this method stores the color for the light edge of the tab window.  
  
 [out] `pbrFace`  
 A pointer to a reference for a brush. This method stores the brush that it uses to fill the face of the tab window in this parameter.  
  
 [out] `pbrBlack`  
 A pointer to a reference for a brush. This method stores the brush it uses to fill the black edge of the tab window in this parameter.  
  
## Remarks  
 Override this function in a derived class if you want to customize the set of colors that the framework uses when it draws a tab window.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)