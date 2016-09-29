---
title: "CTabCtrl::GetItemState"
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
  - "CTabCtrl::GetItemState"
  - "CTabCtrl.GetItemState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "retrieving state information"
  - "state information"
  - "state information, retrieving"
  - "GetItemState method"
ms.assetid: 4f04afb2-3fb4-4a65-8b21-bd2ab68656f7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::GetItemState
Retrieves the state of the tab control item identified by `nItem`.  
  
## Syntax  
  
```  
  
      DWORD GetItemState(   
   int nItem,   
   DWORD dwMask    
) const;  
```  
  
#### Parameters  
 `nItem`  
 The zero-based index number of the item for which to retrieve state information.  
  
 `dwMask`  
 Mask specifying which of the item's state flags to return. For a list of values, see the mask member of the [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A reference to a `DWORD` value receiving the state information. Can be one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|**TCIS_BUTTONPRESSED**|The tab control item is selected.|  
|**TCIS_HIGHLIGHTED**|The tab control item is highlighted, and the tab and text are drawn using the current highlight color. When using highlight color, this will be a true interpolation, not a dithered color.|  
  
## Remarks  
 An item's state is specified by the **dwState** member of the `TCITEM` structure.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetItemState](../vs140/ctabctrl--setitemstate.md)