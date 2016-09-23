---
title: "CTreeCtrl::SetInsertMark"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTreeCtrl::SetInsertMark
  - CTreeCtrl.SetInsertMark
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetInsertMark method
ms.assetid: 21356b64-20c7-4891-a742-53b29f499695
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::SetInsertMark
This member function implements the behavior of the Win32 message [TVM_SETINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb773753), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL SetInsertMark(  
   HTREEITEM hItem,  
   BOOL fAfter = TRUE   
);  
```  
  
#### Parameters  
 `hItem`  
 **HTREEITEM** that specifies at which item the insertion mark will be placed. If this argument is **NULL**, the insertion mark is removed.  
  
 *fAfter*  
 **BOOL** value that specifies if the insertion mark is placed before or after the specified item. If this argument is nonzero, the insertion mark will be placed after the item. If this argument is zero, the insertion mark will be placed before the item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#31](../vs140/codesnippet/CPP/ctreectrl--setinsertmark_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)