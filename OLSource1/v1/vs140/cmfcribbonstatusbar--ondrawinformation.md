---
title: "CMFCRibbonStatusBar::OnDrawInformation"
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
  - "CMFCRibbonStatusBar.OnDrawInformation"
  - "OnDrawInformation"
  - "CMFCRibbonStatusBar::OnDrawInformation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawInformation method"
ms.assetid: a9722d76-4b62-4277-bf80-2350d0a198b4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBar::OnDrawInformation
Displays the string that appears on the ribbon status bar when the information mode is enabled.  
  
## Syntax  
  
```  
virtual void OnDrawInformation(  
   CDC* pDC,  
   CString& strInfo,  
   CRect rectInfo   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `strInfo`  
 The information string.  
  
 [in] `rectInfo`  
 The bounding rectangle.  
  
## Remarks  
 Override this method in a derived class if you want to customize the appearance of the information string on the status bar. Use the [CMFCRibbonStatusBar::SetInformation](../vs140/cmfcribbonstatusbar--setinformation.md) method to put the status bar in information mode. In this mode, the status bar hides all panes and displays the information string specified by `strInfo`.  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
## See Also  
 [CMFCRibbonStatusBar Class](../vs140/cmfcribbonstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)