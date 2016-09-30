---
title: "CStatusBarCtrl::SetParts"
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
  - "SetParts"
  - "CStatusBarCtrl::SetParts"
  - "CStatusBarCtrl.SetParts"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParts method"
  - "status bar controls, setting number of parts"
  - "CStatusBarCtrl class, attributes"
ms.assetid: f7598715-328b-4184-a8bf-04fa01b42860
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::SetParts
Sets the number of parts in a status bar control and the coordinate of the right edge of each part.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of parts to set. The number of parts cannot be greater than 255.  
  
 *pWidths*  
 Address of an integer array having the same number of elements as parts specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Each element in the array specifies the position, in client coordinates, of the right edge of the corresponding part. If an element is – 1, the position of the right edge for that part extends to the right edge of the control.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#10](../vs140/codesnippet/CPP/cstatusbarctrl--setparts_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetBorders](../vs140/cstatusbarctrl--getborders.md)   
 [CStatusBarCtrl::GetParts](../vs140/cstatusbarctrl--getparts.md)