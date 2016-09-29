---
title: "CMFCBaseTabCtrl::GetTabLabel"
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
  - "GetTabLabel"
  - "CMFCBaseTabCtrl::GetTabLabel"
  - "CMFCBaseTabCtrl.GetTabLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabLabel method"
ms.assetid: b7069046-c598-40da-ac2a-1cdeee7d75ad
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabLabel
Retrieves the text of a tab label.  
  
## Syntax  
  
```  
virtual BOOL GetTabLabel(  
   int iTab,  
   CString& strLabel  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
 [out] `strLabel`  
 A reference to a `CString` object. This method stores the label of the tab in this parameter.  
  
## Return Value  
 `TRUE` if successful; `FALSE` otherwise.  
  
## Remarks  
 This method fails if the index `iTab` is invalid.  
  
 You set the label for a tab when you create the tab by using [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md). You can also change the label after creation with the method [CMFCBaseTabCtrl::SetTabLabel](../vs140/cmfcbasetabctrl--settablabel.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabLabel](../vs140/cmfcbasetabctrl--settablabel.md)