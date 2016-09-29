---
title: "CLinkCtrl::GetItem"
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
  - "CLinkCtrl::GetItem"
  - "CLinkCtrl.GetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItem method [MFC]"
ms.assetid: d4cb6fef-e9a9-4764-9ba0-cb814e94e1bc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::GetItem
Retrieves the states and attributes of a link control item.  
  
## Syntax  
  
```  
  
      BOOL GetItem(  
   PLITEM pItem  
) const;  
```  
  
#### Parameters  
 `pItem`  
 A pointer to a [LITEM](http://msdn.microsoft.com/library/windows/desktop/bb760710) structure to receive item information.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [LM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760720), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::SetItem](../vs140/clinkctrl--setitem.md)   
 [CLinkCtrl::GetItemID](../vs140/clinkctrl--getitemid.md)   
 [CLinkCtrl::GetItemState](../vs140/clinkctrl--getitemstate.md)   
 [CLinkCtrl::GetItemUrl](../vs140/clinkctrl--getitemurl.md)