---
title: "CMFCVisualManager::OnFillBarBackground"
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
  - "CMFCVisualManager::OnFillBarBackground"
  - "OnFillBarBackground"
  - "CMFCVisualManager.OnFillBarBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillBarBackground method"
ms.assetid: d62bff39-cf01-4b19-9183-d3122177280e
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillBarBackground
The framework calls this method when it fills the background of a [CBasePane](../vs140/cbasepane-class.md) object.  
  
## Syntax  
  
```  
virtual void OnFillBarBackground(  
   CDC* pDC,  
   CBasePane* pBar,  
   CRect rectClient,  
   CRect rectClip,  
   BOOL bNCArea = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for a control bar.  
  
 [in] `pBar`  
 A pointer to a `CBasePane` object. The framework fills the background of this pane.  
  
 [in] `rectClient`  
 A rectangle that specifies the boundaries of the pane.  
  
 [in] `rectClip`  
 A rectangle that specifies the clipping area of the pane.  
  
 [in] `bNCArea`  
 A reserved value.  
  
## Remarks  
 The default implementation of this method fills the background of the bar with the 3d background color from the global variable `afxGlobalData`. Override this method in a derived visual manager to customize the background of a pane.  
  
## Example  
 The following example demonstrates how to use the `OnFillBarBackground` in the `CMFCVisualManager` class. This code snippet is part of the [Outlook Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookDemo#4](../vs140/codesnippet/CPP/cmfcvisualmanager--onfillbarbackground_1.cpp)]  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane Class](../vs140/cbasepane-class.md)