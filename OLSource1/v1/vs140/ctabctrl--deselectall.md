---
title: "CTabCtrl::DeselectAll"
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
  - CTabCtrl::DeselectAll
  - CTabCtrl.DeselectAll
  - DeselectAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeselectAll method
  - deselecting items
ms.assetid: 835a8646-1ff3-4343-bf8c-bb81146a1fde
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTabCtrl::DeselectAll
Resets items in a tab control, clearing any that were pressed.  
  
## Syntax  
  
```  
  
      void DeselectAll(  
  BOOL fExcludeFocus   
);  
```  
  
#### Parameters  
 *fExcludeFocus*  
 Flag that specifies the scope of the item deselection. If this parameter is set to **FALSE**, all tab buttons will be reset. If it is set to **TRUE**, then all tab items except for the one currently selected will be reset.  
  
## Remarks  
 This member function implements the behavior of the Win32 message, [TCM_DESELECTALL](http://msdn.microsoft.com/library/windows/desktop/bb760579), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)