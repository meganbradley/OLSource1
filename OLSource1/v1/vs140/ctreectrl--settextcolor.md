---
title: "CTreeCtrl::SetTextColor"
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
  - "CTreeCtrl.SetTextColor"
  - "CTreeCtrl::SetTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextColor method"
ms.assetid: 3fd22223-d692-4a40-92ac-1fc1e6334be1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetTextColor
This member function implements the behavior of the Win32 message [TVM_SETTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773769), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      COLORREF SetTextColor(  
   COLORREF clr   
);  
```  
  
#### Parameters  
 `clr`  
 A **COLORREF** value that contains the new text color. If this argument is -1, the control will revert to using the system color for the text color.  
  
## Return Value  
 A **COLORREF** value that represents the previous text color. If this value is -1, the control was using the system color for the text color.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#36](../vs140/codesnippet/CPP/ctreectrl--settextcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetTextColor](../vs140/ctreectrl--gettextcolor.md)