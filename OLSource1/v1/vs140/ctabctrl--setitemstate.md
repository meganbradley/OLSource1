---
title: "CTabCtrl::SetItemState"
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
  - "CTabCtrl.SetItemState"
  - "CTabCtrl::SetItemState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemState method"
ms.assetid: 09541f7b-874a-41df-8e5b-049d644c5ef3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetItemState
Sets the state of the tab control item identified by `nItem`.  
  
## Syntax  
  
```  
  
      BOOL SetItemState(  
  int nItem,  
  DWORD dwMask,  
  DWORD dwState   
);  
```  
  
#### Parameters  
 `nItem`  
 The zero-based index number of the item for which to set state information.  
  
 `dwMask`  
 Mask specifying which of the item's state flags to set. For a list of values, see the mask member of the [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwState`  
 A reference to a `DWORD` value containing the state information. Can be one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|**TCIS_BUTTONPRESSED**|The tab control item is selected.|  
|**TCIS_HIGHLIGHTED**|The tab control item is highlighted, and the tab and text are drawn using the current highlight color. When using highlight color, this will be a true interpolation, not a dithered color.|  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::GetItemState](../vs140/ctabctrl--getitemstate.md)