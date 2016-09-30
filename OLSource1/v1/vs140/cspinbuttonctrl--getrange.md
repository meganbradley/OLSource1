---
title: "CSpinButtonCtrl::GetRange"
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
  - "CSpinButtonCtrl::GetRange"
  - "CSpinButtonCtrl.GetRange"
  - "GetRange32"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRange32 method"
  - "GetRange method"
ms.assetid: 60dfd404-5e77-44bd-9f7f-adabbf1423a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::GetRange
Retrieves the upper and lower limits (range) for a spin button control.  
  
## Syntax  
  
```  
  
      DWORD GetRange( ) const;  
void GetRange(  
   int &lower,  
   int& upper   
) const;  
void GetRange32(   
   int &lower,    
   int &upper    
) const;  
```  
  
#### Parameters  
 *lower*  
 Reference to an integer that receives the lower limit for the control.  
  
 *upper*  
 Reference to an integer that receives the upper limit for the control.  
  
## Return Value  
 The first version returns a 32-bit value containing the upper and lower limits. The low-order word is the upper limit for the control, and the high-order word is the lower limit.  
  
## Remarks  
 The member function `GetRange32` retrieves the spin button control's range as a 32-bit integer.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::SetRange](../vs140/cspinbuttonctrl--setrange.md)