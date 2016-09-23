---
title: "CMFCVisualManager::OnDrawTabContent"
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
  - CMFCVisualManager::OnDrawTabContent
  - CMFCVisualManager.OnDrawTabContent
  - OnDrawTabContent
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawTabContent method
ms.assetid: cbac3399-1c9a-4986-b49e-09e43824d4e8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawTabContent
The framework calls this method when it draws the contents located on the interior of an instance of the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawTabContent(  
   CDC* pDC,  
   CRect rectTab,  
   int iTab,  
   BOOL bIsActive,  
   const CMFCBaseTabCtrl* pTabWnd,  
   COLORREF clrText  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectTab`  
 A rectangle that specifies the boundaries of the tab interior.  
  
 [in] `iTab`  
 The zero-based index of the tab. The framework draws the interior of this tab.  
  
 [in] `bIsActive`  
 A Boolean parameter that indicates whether a tab is active.  
  
 [in] `pTabWnd`  
 A pointer to the tabbed control that contains the tab being drawn.  
  
 [in] `clrText`  
 The color of text on the interior of the tab.  
  
## Remarks  
 The interior of a tab contains the text and icons of the tab. Override this method in a derived visual manager to customize the appearance of tabs.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)