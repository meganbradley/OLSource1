---
title: "CMFCVisualManager::OnDrawTabCloseButton"
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
  - "OnDrawTabCloseButton"
  - "CMFCVisualManager::OnDrawTabCloseButton"
  - "CMFCVisualManager.OnDrawTabCloseButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTabCloseButton method"
ms.assetid: fa0fdb86-1fd7-44cc-9b36-a955ecb2b945
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTabCloseButton
The framework calls this method when it draws the **Close** button on the active tab.  
  
## Syntax  
  
```  
virtual void OnDrawTabCloseButton(  
   CDC* pDC,  
   CRect rect,  
   const CMFCBaseTabCtrl* pTabWnd,  
   BOOL bIsHighlighted,  
   BOOL bIsPressed,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the **Close** button.  
  
 [in] `pTabWnd`  
 A pointer to a tab control. The framework draws the **Close** button for this tab control.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the **Close** button is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean parameter that indicates whether the **Close** button is pressed.  
  
 [in] `bIsDisabled`  
 A Boolean parameter that indicates whether the **Close** button is disabled.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the **Close** button on the active tab of `pTabWnd`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)