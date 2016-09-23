---
title: "CLinkCtrl::SetItem"
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
  - CLinkCtrl.SetItem
  - CLinkCtrl::SetItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetItem method
ms.assetid: f7bc3b0b-f2d4-4925-afce-f14666faf19a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLinkCtrl::SetItem
Sets the states and attributes of a link control item.  
  
## Syntax  
  
```  
  
      BOOL SetItem(  
   PLITEM pItem  
);  
```  
  
#### Parameters  
 `pItem`  
 A pointer to a [LITEM](http://msdn.microsoft.com/library/windows/desktop/bb760710) structure containing the information to set.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [LM_SETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760724), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::GetItem](../vs140/clinkctrl--getitem.md)   
 [CLinkCtrl::SetItemID](../vs140/clinkctrl--setitemid.md)   
 [CLinkCtrl::SetItemState](../vs140/clinkctrl--setitemstate.md)   
 [CLinkCtrl::SetItemUrl](../vs140/clinkctrl--setitemurl.md)