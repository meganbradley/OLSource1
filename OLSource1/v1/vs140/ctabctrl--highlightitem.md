---
title: "CTabCtrl::HighlightItem"
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
  - "CTabCtrl.HighlightItem"
  - "HighlightItem"
  - "CTabCtrl::HighlightItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "highlighting"
  - "highlighting, tab control"
  - "HighlightItem method"
ms.assetid: 128c4b50-43ea-4559-b3a3-6ae900c7a477
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::HighlightItem
Sets the highlight state of a tab item.  
  
## Syntax  
  
```  
  
      BOOL HighlightItem(  
  int idItem,  
  BOOL fHighlight = TRUE   
);  
```  
  
#### Parameters  
 `idItem`  
 Zero-based index of a tab control item.  
  
 `fHighlight`  
 Value specifying the highlight state to be set. If this value is **TRUE**, the tab is highlighted; if **FALSE**, the tab is set to its default state.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the Win32 message [TCM_HIGHLIGHTITEM](http://msdn.microsoft.com/library/windows/desktop/bb760602), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)