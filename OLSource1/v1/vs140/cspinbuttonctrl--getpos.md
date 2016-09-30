---
title: "CSpinButtonCtrl::GetPos"
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
  - "CSpinButtonCtrl::GetPos"
  - "GetPos32"
  - "CSpinButtonCtrl.GetPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPos method"
  - "GetPos32 method"
ms.assetid: 0241c2b7-59b3-4e85-999d-a76a46c547ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::GetPos
Retrieves the current position of a spin button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpbError*  
 A pointer to a boolean value that is set to zero if the value is successfully retrieved or non-zero if an error occurs. If this parameter is set to **NULL**, errors are not reported.  
  
## Return Value  
 The first version returns the 16-bit current position in the low-order word. The high-order word is nonzero if an error occurred.  
  
 The second version returns the 32-bit position.  
  
## Remarks  
 When it processes the value returned, the control updates its current position based on the caption of the buddy window. The control returns an error if there is no buddy window or if the caption specifies an invalid or out-of-range value.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::SetPos](../vs140/cspinbuttonctrl--setpos.md)