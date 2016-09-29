---
title: "CListCtrl::GetSelectionMark"
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
  - "CListCtrl.GetSelectionMark"
  - "CListCtrl::GetSelectionMark"
  - "GetSelectionMark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectionMark method"
ms.assetid: d3825f05-e4e6-4060-9acf-ba722542df97
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetSelectionMark
Retrieves the selection mark of a list view control.  
  
## Syntax  
  
```  
  
int GetSelectionMark( );  
  
```  
  
## Return Value  
 The zero-based selection mark, or -1 if there is no selection mark.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetSelectionMark](http://msdn.microsoft.com/library/windows/desktop/bb774998), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#27](../vs140/codesnippet/CPP/clistctrl--getselectionmark_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetSelectionMark](../vs140/clistctrl--setselectionmark.md)