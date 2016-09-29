---
title: "CMFCBaseTabCtrl::GetTabIcon"
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
  - "GetTabIcon"
  - "CMFCBaseTabCtrl.GetTabIcon"
  - "CMFCBaseTabCtrl::GetTabIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabIcon method"
ms.assetid: b3d1a54a-8776-47d8-91b9-51348bbb0d79
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabIcon
Retrieves the icon associated with the specified tab.  
  
## Syntax  
  
```  
virtual UINT GetTabIcon(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
## Return Value  
 The icon ID for the specified tab if successful; -1 if the index is invalid.  
  
## Remarks  
 The [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object stores the icons in the internal [CImageList](../vs140/cimagelist-class.md) object.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabIcon](../vs140/cmfcbasetabctrl--settabicon.md)