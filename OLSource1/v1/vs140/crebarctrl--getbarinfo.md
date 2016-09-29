---
title: "CReBarCtrl::GetBarInfo"
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
  - "CReBarCtrl::GetBarInfo"
  - "CReBarCtrl.GetBarInfo"
  - "GetBarInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBarInfo method"
  - "CReBarCtrl class, attributes"
ms.assetid: 7bb02f2b-b8e8-411e-ad00-88742e989f82
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetBarInfo
Implements the behavior of the Win32 message [RB_GETBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774457), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL GetBarInfo(  
   REBARINFO* prbi   
) const;  
```  
  
#### Parameters  
 `prbi`  
 A pointer to a [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure that will receive the rebar control information. You must set the `cbSize` member of this structure to `sizeof(REBARINFO)` before sending this message.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetBarInfo](../vs140/crebarctrl--setbarinfo.md)