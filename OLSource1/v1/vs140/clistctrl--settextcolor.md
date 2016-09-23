---
title: "CListCtrl::SetTextColor"
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
  - CListCtrl::SetTextColor
  - CListCtrl.SetTextColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTextColor method
ms.assetid: d33fc4d5-ae56-4c09-b6f9-e514749d7b82
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetTextColor
Sets the text color of a list view control.  
  
## Syntax  
  
```  
  
      BOOL SetTextColor(  
   COLORREF cr   
);  
```  
  
#### Parameters  
 `cr`  
 A **COLORREF** specifying the new text color. For information, see [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#38](../vs140/codesnippet/CPP/clistctrl--settextcolor_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetTextBkColor](../vs140/clistctrl--settextbkcolor.md)