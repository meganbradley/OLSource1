---
title: "CProgressCtrl::SetBkColor"
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
  - CProgressCtrl::SetBkColor
  - CProgressCtrl.SetBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBkColor method
  - background colors, progress control
ms.assetid: 828fd2bb-cd14-45f1-84ce-56701506d30c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::SetBkColor
Sets the background color for the progress bar.  
  
## Syntax  
  
```  
  
      COLORREF SetBkColor(  
   COLORREF clrNew   
);  
```  
  
#### Parameters  
 `clrNew`  
 A **COLORREF** value that specifies the new background color. Specify the `CLR_DEFAULT` value to use the default background color for the progress bar.  
  
## Return Value  
 The [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value indicating the previous background color, or **CLR_DEFAULT** if the background color is the default color.  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#6](../vs140/codesnippet/CPP/cprogressctrl--setbkcolor_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760840)