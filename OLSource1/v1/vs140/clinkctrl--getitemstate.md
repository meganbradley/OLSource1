---
title: "CLinkCtrl::GetItemState"
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
  - "CLinkCtrl::GetItemState"
  - "CLinkCtrl.GetItemState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemState method"
ms.assetid: 7da02236-fbfc-470c-aeab-d113a0463339
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::GetItemState
Retrieves the state of the link control item.  
  
## Syntax  
  
```  
  
      BOOL GetItemState(  
   int iLink,  
   UINT * pnState,  
   UINT stateMask = LIS_FOCUSED | LIS_ENABLED | LIS_VISITED   
) const;  
```  
  
#### Parameters  
 `iLink`  
 The index of a link control item.  
  
 `pnState`  
 The value of the specified state item.  
  
 `stateMask`  
 Combination of flags describing which state item to get. For a list of values, see the description of the **state** member in the [LITEM](http://msdn.microsoft.com/library/windows/desktop/bb760710) structure. Allowable items are identical to those allowed in **state**.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Retrieves the value of the specified state item of a specific link control item. For more information, see the Win32 message [LM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760720) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::SetItemState](../vs140/clinkctrl--setitemstate.md)   
 [CLinkCtrl::GetItem](../vs140/clinkctrl--getitem.md)