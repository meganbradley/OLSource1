---
title: "CMFCVisualManager::OnFillPopupWindowBackground"
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
  - "CMFCVisualManager::OnFillPopupWindowBackground"
  - "CMFCVisualManager.OnFillPopupWindowBackground"
  - "OnFillPopupWindowBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillPopupWindowBackground method"
ms.assetid: 8bb5cd0c-774d-4f34-b711-454e663f061b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillPopupWindowBackground
The framework calls this method when it fills the background of a pop-up window.  
  
## Syntax  
  
```  
virtual void OnFillPopupWindowBackground(  
   CDC* pDC,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the popup window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of pop-up windows.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)