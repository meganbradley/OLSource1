---
title: "CListCtrl::SetTextBkColor"
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
  - "SetTextBkColor"
  - "CListCtrl.SetTextBkColor"
  - "CListCtrl::SetTextBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextBkColor method"
ms.assetid: 81712496-3b43-435a-8b4b-5edeb675cfca
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetTextBkColor
Sets the background color of text in a list view control.  
  
## Syntax  
  
```  
  
      BOOL SetTextBkColor(  
   COLORREF cr   
);  
```  
  
#### Parameters  
 `cr`  
 A **COLORREF** specifying the new text background color. For information, see [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#24](../vs140/codesnippet/CPP/clistctrl--settextbkcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetTextBkColor](../vs140/clistctrl--gettextbkcolor.md)