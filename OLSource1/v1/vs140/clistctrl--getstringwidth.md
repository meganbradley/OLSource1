---
title: "CListCtrl::GetStringWidth"
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
  - "CListCtrl.GetStringWidth"
  - "GetStringWidth"
  - "CListCtrl::GetStringWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStringWidth method"
ms.assetid: 0dc82110-6552-4020-b192-ce35642c9082
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetStringWidth
Determines the minimum column width necessary to display all of a given string.  
  
## Syntax  
  
```  
  
      int GetStringWidth(  
   LPCTSTR lpsz   
) const;  
```  
  
#### Parameters  
 `lpsz`  
 Address of a null-terminated string whose width is to be determined.  
  
## Return Value  
 The width, in pixels, of the string pointed to by `lpsz`.  
  
## Remarks  
 The returned width takes into account the control's current font and column margins, but not the width of a small icon.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#28](../vs140/codesnippet/CPP/clistctrl--getstringwidth_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetColumnWidth](../vs140/clistctrl--getcolumnwidth.md)