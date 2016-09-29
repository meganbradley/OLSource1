---
title: "CHeaderCtrl::GetOrderArray"
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
  - "GetOrderArray"
  - "CHeaderCtrl.GetOrderArray"
  - "CHeaderCtrl::GetOrderArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOrderArray method"
ms.assetid: 73aa7231-9e46-47c5-86de-ee3421419dfb
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetOrderArray
Retrieves the left-to-right order of items in a header control.  
  
## Syntax  
  
```  
  
      BOOL GetOrderArray(  
   LPINT piArray,  
   int iCount  
);  
```  
  
#### Parameters  
 `piArray`  
 A pointer to the address of a buffer that receives the index values of the items in the header control, in the order in which they appear from left to right.  
  
 `iCount`  
 The number of header control items. Must be non-negative.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_GETORDERARRAY](http://msdn.microsoft.com/library/windows/desktop/bb775343), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#11](../vs140/codesnippet/CPP/cheaderctrl--getorderarray_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::SetOrderArray](../vs140/cheaderctrl--setorderarray.md)   
 [CHeaderCtrl::OrderToIndex](../vs140/cheaderctrl--ordertoindex.md)