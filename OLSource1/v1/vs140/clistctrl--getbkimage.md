---
title: "CListCtrl::GetBkImage"
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
  - "CListCtrl.GetBkImage"
  - "GetBkImage"
  - "CListCtrl::GetBkImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBkImage method"
ms.assetid: 1b067101-1a62-4da6-8214-0d206d980b3f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetBkImage
Retrieves the current background image of a list view control.  
  
## Syntax  
  
```  
  
      BOOL GetBkImage(  
   LVBKIMAGE* plvbkImage   
) const;  
```  
  
#### Parameters  
 `plvbkImage`  
 A pointer to an **LVBKIMAGE** structure containing the current background image of the list view.  
  
## Return Value  
 Returns nonzero if successful, or zero otherwise.  
  
## Remarks  
 This method implements the behavior of the Win32 macro, [ListView_GetBkImage](http://msdn.microsoft.com/library/windows/desktop/bb761246), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#10](../vs140/codesnippet/CPP/clistctrl--getbkimage_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetBkImage](../vs140/clistctrl--setbkimage.md)