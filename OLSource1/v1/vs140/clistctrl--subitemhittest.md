---
title: "CListCtrl::SubItemHitTest"
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
  - "CListCtrl::SubItemHitTest"
  - "SubItemHitTest"
  - "CListCtrl.SubItemHitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SubItemHitTest method"
ms.assetid: a6e26f1e-958d-41d4-8191-570aff92af0f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SubItemHitTest
Determines which list view item, if any, is at a given position.  
  
## Syntax  
  
```  
  
      int SubItemHitTest(  
   LPLVHITTESTINFO pInfo   
);  
```  
  
#### Parameters  
 `pInfo`  
 A pointer to the [LVHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb774754) structure.  
  
## Return Value  
 The one-based index of the item, or subitem, being tested (if any), or -1 otherwise.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SubItemHitTest](http://msdn.microsoft.com/library/windows/desktop/bb775135), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#41](../vs140/codesnippet/CPP/clistctrl--subitemhittest_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)