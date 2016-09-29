---
title: "CListCtrl::HitTest"
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
  - "LVHT_NOWHERE"
  - "LV_HITTESTINFO"
  - "CListCtrl.HitTest"
  - "LVHT_TORIGHT"
  - "LVHT_TOLEFT"
  - "LVHT_ONITEMLABEL"
  - "CListCtrl::HitTest"
  - "LVHT_BELOW"
  - "LVHT_ONITEMSTATEICON"
  - "LVHT_ABOVE"
  - "LVHT_ONITEMICON"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVHT_TORIGHT"
  - "LVHT_BELOW"
  - "LVHT_ONITEMICON"
  - "LVHT_ONITEMSTATEICON"
  - "LV_HITTESTINFO"
  - "LVHT_ONITEMLABEL"
  - "LVHT_NOWHERE"
  - "LVHT_TOLEFT"
  - "HitTest method [MFC]"
  - "LVHT_ABOVE"
ms.assetid: 0f32449a-1eca-444c-b550-c160a10a01c4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::HitTest
Determines which list view item, if any, is at a specified position.  
  
## Syntax  
  
```  
  
      int HitTest(  
   LVHITTESTINFO* pHitTestInfo   
) const;  
int HitTest(  
   CPoint pt,  
   UINT* pFlags = NULL   
) const;  
```  
  
#### Parameters  
 `pHitTestInfo`  
 Address of an **LVHITTESTINFO** structure that contains the position to hit test and that receives information about the results of the hit test.  
  
 `pt`  
 Point to be tested.  
  
 `pFlags`  
 Pointer to an integer that receives information about the results of the test. See the explanation of the **flags** member of the [LVHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb774754) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 The index of the item at the position specified by `pHitTestInfo`, if any, or -1 otherwise.  
  
## Remarks  
 You can use the `LVHT_ABOVE`, `LVHT_BELOW`, `LVHT_TOLEFT`, and `LVHT_TORIGHT` values of the structure's **flag** member to determine whether to scroll the contents of a list view control. Two of these flags can be combined, for example, if the position is above and to the left of the client area.  
  
 You can test for the **LVHT_ONITEM** value of the structure's **flag** member to determine whether a given position is over a list view item. This value is a bitwise-OR operation on the `LVHT_ONITEMICON`, `LVHT_ONITEMLABEL`, and `LVHT_ONITEMSTATEICON` values of the structure's **flag** member.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#31](../vs140/codesnippet/CPP/clistctrl--hittest_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemPosition](../vs140/clistctrl--getitemposition.md)