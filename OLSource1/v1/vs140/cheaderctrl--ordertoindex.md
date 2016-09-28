---
title: "CHeaderCtrl::OrderToIndex"
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
  - "OrderToIndex"
  - "CHeaderCtrl.OrderToIndex"
  - "CHeaderCtrl::OrderToIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OrderToIndex method"
ms.assetid: b810c359-777b-4b71-8eab-2ada9a9717d9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::OrderToIndex
Retrieves the index value for an item based on its order in the header control.  
  
## Syntax  
  
```  
  
      int OrderToIndex(  
   int nOrder   
) const;  
```  
  
#### Parameters  
 *nOrder*  
 The zero-based order that the item appears in the header control, from left to right.  
  
## Return Value  
 The index of the item, based on its order in the header control. The index counts from left to right, beginning with 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro [HDM_ORDERTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb775355), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetOrderArray](../vs140/cheaderctrl--getorderarray.md)   
 [CHeaderCtrl::SetOrderArray](../vs140/cheaderctrl--setorderarray.md)