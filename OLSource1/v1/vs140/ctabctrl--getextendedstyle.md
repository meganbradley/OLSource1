---
title: "CTabCtrl::GetExtendedStyle"
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
  - "CTabCtrl.GetExtendedStyle"
  - "CTabCtrl::GetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedStyle method"
  - "extended styles"
ms.assetid: 38f152f0-fb74-4a65-9cb3-3ae3b2654fad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::GetExtendedStyle
Retrieves the extended styles that are currently in use for the tab control.  
  
## Syntax  
  
```  
  
DWORD GetExtendedStyle( );  
  
```  
  
## Return Value  
 Represents the extended styles currently in use for the tab control. This value is a combination of [tab control extended styles](http://msdn.microsoft.com/library/windows/desktop/bb760546), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TCM_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb760585), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetExtendedStyle](../vs140/ctabctrl--setextendedstyle.md)