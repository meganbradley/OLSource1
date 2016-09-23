---
title: "CListCtrl::SetInsertMark"
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
  - CListCtrl.SetInsertMark
  - CListCtrl::SetInsertMark
  - SetInsertMark
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetInsertMark method
ms.assetid: d4257c7a-d578-4406-b0c3-fde8416b31fc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetInsertMark
Sets the insertion point to the defined position.  
  
## Syntax  
  
```  
  
      BOOL SetInsertMark(  
   LPLVINSERTMARK lvim   
);  
```  
  
#### Parameters  
 `lvim`  
 A pointer to an [LVINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb774758) structure specifying where to set the insertion point.  
  
## Return Value  
 Returns **TRUE** if successful, or **FALSE** otherwise. **FALSE** is returned if the size in the `cbSize` member of the **LVINSERTMARK** structure does not equal the actual size of the structure, or when an insertion point does not apply in the current view.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_SETINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb761182) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)