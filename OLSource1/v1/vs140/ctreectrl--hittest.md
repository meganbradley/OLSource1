---
title: "CTreeCtrl::HitTest"
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
  - "TVHT_TOLEFT"
  - "CTreeCtrl.HitTest"
  - "TVHT_ONITEMBUTTON"
  - "TVHT_ONITEMLABEL"
  - "TVHT_ONITEMINDENT"
  - "CTreeCtrl::HitTest"
  - "TVHT_ONITEMSTATEICON"
  - "TV_HITTESTINFO"
  - "TVHT_NOWHERE"
  - "TVHT_ABOVE"
  - "TVHT_ONITEM"
  - "TVHT_ONITEMICON"
  - "TVHT_ONITEMRIGHT"
  - "TVHT_TORIGHT"
  - "TVHT_BELOW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TVHT_NOWHERE"
  - "TVHT_ONITEMLABEL"
  - "TV_HITTESTINFO"
  - "TVHT_ONITEM"
  - "TVHT_ONITEMICON"
  - "TVHT_ONITEMINDENT"
  - "TVHT_BELOW"
  - "TVHT_ONITEMBUTTON"
  - "TVHT_ONITEMSTATEICON"
  - "HitTest method [MFC]"
  - "TVHT_ABOVE"
  - "TVHT_TORIGHT"
  - "TVHT_TOLEFT"
  - "TVHT_ONITEMRIGHT"
ms.assetid: 5ef7bab4-f376-4468-a605-ac1c79521470
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::HitTest
Call this function to determine the location of the specified point relative to the client area of a tree view control.  
  
## Syntax  
  
```  
  
      HTREEITEM HitTest(  
   CPoint pt,  
   UINT* pFlags = NULL  
) const;  
HTREEITEM HitTest(  
   TVHITTESTINFO* pHitTestInfo   
) const;  
```  
  
#### Parameters  
 `pt`  
 Client coordinates of the point to test.  
  
 `pFlags`  
 Pointer to an integer that receives information about the results of the hit test. It can be one or more of the values listed under the **flags** member in the Remarks section.  
  
 `pHitTestInfo`  
 Address of a [TVHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb773448) structure that contains the position to hit test and that receives information about the results of the hit test.  
  
## Return Value  
 The handle of the tree view item that occupies the specified point or **NULL** if no item occupies the point.  
  
## Remarks  
 When this function is called, the `pt` parameter specifies the coordinates of the point to test. The function returns the handle of the item at the specified point or **NULL** if no item occupies the point. In addition, the `pFlags` parameter contains a value that indicates the location of the specified point. Possible values are:  
  
|||  
|-|-|  
|Value|Meaning|  
|TVHT_ABOVE|Above the client area.|  
|TVHT_BELOW|Below the client area.|  
|TVHT_NOWHERE|In the client area, but below the last item.|  
|TVHT_ONITEM|On the bitmap or label associated with an item.|  
|TVHT_ONITEMBUTTON|On the button associated with an item.|  
|TVHT_ONITEMICON|On the bitmap associated with an item.|  
|TVHT_ONITEMINDENT|In the indentation associated with an item.|  
|TVHT_ONITEMLABEL|On the label (string) associated with an item.|  
|TVHT_ONITEMRIGHT|In the area to the right of an item.|  
|TVHT_ONITEMSTATEICON|On the state icon for a tree-view item that is in a user-defined state.|  
|TVHT_TOLEFT|To the left of the client area.|  
|TVHT_TORIGHT|To the right of the client area.|  
|||  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#26](../vs140/codesnippet/CPP/ctreectrl--hittest_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItemRect](../vs140/ctreectrl--getitemrect.md)