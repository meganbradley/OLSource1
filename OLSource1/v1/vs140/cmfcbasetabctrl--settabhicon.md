---
title: "CMFCBaseTabCtrl::SetTabHicon"
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
  - "SetTabHicon"
  - "CMFCBaseTabCtrl.SetTabHicon"
  - "CMFCBaseTabCtrl::SetTabHicon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTabHicon method"
ms.assetid: 1f94a71b-f1ff-4074-8cd9-2097982e8299
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetTabHicon
Sets the icon for a tab label.  
  
## Syntax  
  
```  
virtual BOOL SetTabHicon(  
   int iTab,  
   HICON hIcon  
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of a tab. This method changes the icon for this tab.  
  
 [in] `hIcon`  
 A handle to an icon.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)