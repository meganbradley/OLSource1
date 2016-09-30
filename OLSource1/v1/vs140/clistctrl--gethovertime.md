---
title: "CListCtrl::GetHoverTime"
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
  - "CListCtrl::GetHoverTime"
  - "GetHoverTime"
  - "CListCtrl.GetHoverTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHoverTime method"
ms.assetid: 8cf840b3-b900-4c82-8f77-c5c17c08d8a6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetHoverTime
Retrieves the current hover time of a list view control.  
  
## Syntax  
  
```  
  
DWORD GetHoverTime( ) const;  
  
```  
  
## Return Value  
 Returns the delay, in milliseconds, which the mouse cursor must hover over an item before it is selected. If the return value is -1, then the hover time is the default hover time.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetHoverTime](http://msdn.microsoft.com/library/windows/desktop/bb761296), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#19](../vs140/codesnippet/CPP/clistctrl--gethovertime_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetHoverTime](../vs140/clistctrl--sethovertime.md)   
 [CListCtrl::GetHotCursor](../vs140/clistctrl--gethotcursor.md)