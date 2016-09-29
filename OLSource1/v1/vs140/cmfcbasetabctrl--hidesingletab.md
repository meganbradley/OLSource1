---
title: "CMFCBaseTabCtrl::HideSingleTab"
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
  - "CMFCBaseTabCtrl.HideSingleTab"
  - "CMFCBaseTabCtrl::HideSingleTab"
  - "HideSingleTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HideSingleTab method"
ms.assetid: 58ddfba0-9bae-4ce9-851c-de874a1b99ba
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::HideSingleTab
Sets the option to hide the tabs for the tab control when there is one visible tab.  
  
## Syntax  
  
```  
virtual void HideSingleTab(  
   BOOL bHide = TRUE  
);  
```  
  
#### Parameters  
 [in] `bHide`  
 A Boolean that specifies whether to enable hiding single tabs.  
  
## Remarks  
 When your application is configured to hide single tabs, the framework automatically displays tabs when a second tab is added to the tab control.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)