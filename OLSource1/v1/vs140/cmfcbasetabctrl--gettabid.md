---
title: "CMFCBaseTabCtrl::GetTabID"
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
  - "GetTabID"
  - "CMFCBaseTabCtrl.GetTabID"
  - "CMFCBaseTabCtrl::GetTabID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabID method"
ms.assetid: bed2efb3-dfad-459c-85fb-37ca643288e2
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabID
Retrieves the ID for a tab specified by the tab index.  
  
## Syntax  
  
```  
int GetTabID(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
## Return Value  
 An ID of the tab or -1 if `iTab` is out of range.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)