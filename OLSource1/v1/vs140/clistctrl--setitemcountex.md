---
title: "CListCtrl::SetItemCountEx"
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
  - "CListCtrl.SetItemCountEx"
  - "CListCtrl::SetItemCountEx"
  - "SetItemCountEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemCountEx method"
ms.assetid: c50a684d-c9a4-467c-940c-2da57a94a8aa
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItemCountEx
Sets the item count for a virtual list view control.  
  
## Syntax  
  
```  
  
      BOOL SetItemCountEx(  
   int iCount,  
   DWORD dwFlags = LVSICF_NOINVALIDATEALL   
);  
```  
  
#### Parameters  
 `iCount`  
 Number of items that the control will ultimately contain.  
  
 `dwFlags`  
 Specifies the behavior of the list view control after resetting the item count. This value can be a combination of the following:  
  
-   **LVSICF_NOINVALIDATEALL** The list view control will not repaint unless affected items are currently in view. This is the default value.  
  
-   **LVSICF_NOSCROLL** The list view control will not change the scroll position when the item count changes.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetItemCountEx](http://msdn.microsoft.com/library/windows/desktop/bb775095), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]and should only be called for virtual list views.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#36](../vs140/codesnippet/CPP/clistctrl--setitemcountex_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetItemCount](../vs140/clistctrl--setitemcount.md)