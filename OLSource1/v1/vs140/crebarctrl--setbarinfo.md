---
title: "CReBarCtrl::SetBarInfo"
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
  - "CReBarCtrl::SetBarInfo"
  - "CReBarCtrl.SetBarInfo"
  - "SetBarInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBarInfo method"
  - "CReBarCtrl class, attributes"
ms.assetid: bd4e0eab-1d73-4e67-b27b-21b524b3673c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetBarInfo
Implements the behavior of the Win32 message [RB_SETBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774513), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL SetBarInfo(  
   REBARINFO* prbi   
);  
```  
  
#### Parameters  
 `prbi`  
 A pointer to a [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure that contains the information to be set. You must set the `cbSize` member of this structure to `sizeof(REBARINFO)` before sending this message  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#14](../vs140/codesnippet/CPP/crebarctrl--setbarinfo_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetBarInfo](../vs140/crebarctrl--getbarinfo.md)