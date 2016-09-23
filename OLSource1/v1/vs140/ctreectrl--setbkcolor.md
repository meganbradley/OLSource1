---
title: "CTreeCtrl::SetBkColor"
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
  - CTreeCtrl.SetBkColor
  - CTreeCtrl::SetBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBkColor method
ms.assetid: a13c5193-2656-4458-a56f-510f2d253023
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::SetBkColor
This member function implements the behavior of the Win32 message [TVM_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773741), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      COLORREF SetBkColor(  
   COLORREF clr   
);  
```  
  
#### Parameters  
 `clr`  
 A **COLORREF** value that contains the new background color. If this value is -1, the control will revert to using the system color for the background color.  
  
## Return Value  
 A **COLORREF** value that represents the current text color. If this value is -1, the control is using the system color for the text color.  
  
## Example  
 See the example for [CTreeCtrl::SetTextColor](../vs140/ctreectrl--settextcolor.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetBkColor](../vs140/ctreectrl--getbkcolor.md)