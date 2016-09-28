---
title: "CHeaderCtrl::SetOrderArray"
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
  - "CHeaderCtrl.SetOrderArray"
  - "SetOrderArray"
  - "CHeaderCtrl::SetOrderArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOrderArray method"
ms.assetid: c42827e1-0f99-437d-9998-317cc54b8d9f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetOrderArray
Sets the left-to-right order of items in a header control.  
  
## Syntax  
  
```  
  
      BOOL SetOrderArray(  
   int iCount,  
   LPINT piArray   
);  
```  
  
#### Parameters  
 `iCount`  
 The number of header control items.  
  
 `piArray`  
 A pointer to the address of a buffer that receives the index values of the items in the header control, in the order in which they appear from left to right.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro [HDM_SETORDERARRAY](http://msdn.microsoft.com/library/windows/desktop/bb775369), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
## Example  
 See the example for [CHeaderCtrl::GetOrderArray](../vs140/cheaderctrl--getorderarray.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetOrderArray](../vs140/cheaderctrl--getorderarray.md)   
 [CHeaderCtrl::OrderToIndex](../vs140/cheaderctrl--ordertoindex.md)