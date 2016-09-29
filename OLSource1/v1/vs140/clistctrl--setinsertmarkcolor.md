---
title: "CListCtrl::SetInsertMarkColor"
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
  - "CListCtrl.SetInsertMarkColor"
  - "SetInsertMarkColor"
  - "CListCtrl::SetInsertMarkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInsertMarkColor method"
ms.assetid: 56293105-802c-4d12-90da-a1116d207a18
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetInsertMarkColor
Sets the color of the insertion point.  
  
## Syntax  
  
```  
  
      COLORREF SetInsertMarkColor(  
   COLORREF color   
);  
```  
  
#### Parameters  
 `color`  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) structure specifying the color to set the insertion point.  
  
## Return Value  
 Returns a **COLORREF** structure containing the previous color.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_SETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb761184) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)