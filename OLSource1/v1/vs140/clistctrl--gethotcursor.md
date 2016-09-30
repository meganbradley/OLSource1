---
title: "CListCtrl::GetHotCursor"
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
  - "GetHotCursor"
  - "CListCtrl.GetHotCursor"
  - "CListCtrl::GetHotCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHotCursor method"
ms.assetid: 4d50e262-6377-44a1-8a93-bfa70a551490
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetHotCursor
Retrieves the cursor used when hot tracking is enabled for a list view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The handle to the current hot cursor resource being used by the list view control.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetHotCursor](http://msdn.microsoft.com/library/windows/desktop/bb761292), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The hot cursor, only visible when hover selection is enabled, appears when the cursor passes over any list view item. Hover selection is enabled by setting the **LVS_EX_TRACKSELECT** extended style.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#17](../vs140/codesnippet/CPP/clistctrl--gethotcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetHotCursor](../vs140/clistctrl--sethotcursor.md)   
 [CListCtrl::GetHotItem](../vs140/clistctrl--gethotitem.md)