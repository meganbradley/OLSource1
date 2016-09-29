---
title: "CTreeCtrl::GetScrollTime"
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
  - "GetScrollTime"
  - "CTreeCtrl.GetScrollTime"
  - "CTreeCtrl::GetScrollTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollTime method"
ms.assetid: 8003a961-654f-4510-9324-9b2c0343ae48
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetScrollTime
Call this member function to retrieve the maximum scroll time for the tree view control.  
  
## Syntax  
  
```  
  
UINT GetScrollTime( ) const;  
  
```  
  
## Return Value  
 The maximum scroll time, in milliseconds.  
  
## Remarks  
 This member function implements the behavior of the win32 message [TVM_GETSCROLLTIME](http://msdn.microsoft.com/library/windows/desktop/bb773625), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetScrollTime](../vs140/ctreectrl--setscrolltime.md)