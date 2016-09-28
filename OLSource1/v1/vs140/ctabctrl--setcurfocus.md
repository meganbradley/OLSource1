---
title: "CTabCtrl::SetCurFocus"
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
  - "CTabCtrl::SetCurFocus"
  - "CTabCtrl.SetCurFocus"
  - "SetCurFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCurFocus method"
ms.assetid: 14a2b63e-b344-4c83-8ce6-79a2766035a1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetCurFocus
Sets the focus to a specified tab in a tab control.  
  
## Syntax  
  
```  
  
      void SetCurFocus(  
  int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Specifies the index of the tab that gets the focus.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TCM_SETCURFOCUS](http://msdn.microsoft.com/library/windows/desktop/bb760610), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetCurSel](../vs140/ctabctrl--setcursel.md)