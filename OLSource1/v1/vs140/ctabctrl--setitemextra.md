---
title: "CTabCtrl::SetItemExtra"
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
  - "CTabCtrl::SetItemExtra"
  - "SetItemExtra"
  - "CTabCtrl.SetItemExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemExtra method"
ms.assetid: 483661ab-ff82-4e9f-974a-1712fac93d5e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetItemExtra
Sets the number of bytes per tab reserved for application-defined data in a tab control.  
  
## Syntax  
  
```  
  
      BOOL SetItemExtra(  
  int nBytes   
);  
```  
  
#### Parameters  
 `nBytes`  
 The number of extra bytes to set.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TCM_SETITEMEXTRA](http://msdn.microsoft.com/library/windows/desktop/bb760633), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetItem](../vs140/ctabctrl--setitem.md)