---
title: "CSpinButtonCtrl::SetRange"
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
  - "CSpinButtonCtrl.SetRange"
  - "CSpinButtonCtrl::SetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRange32 method"
  - "SetRange method"
ms.assetid: e7e32460-9772-4cf8-9a36-45a3a1800bf5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::SetRange
Sets the upper and lower limits (range) for a spin button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Upper and lower limits for the control. For <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, neither limit can be greater than **UD_MAXVAL** or less than **UD_MINVAL**; in addition, the difference between the two limits cannot exceed **UD_MAXVAL**. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> places no restrictions on the limits; use any integers.  
  
## Remarks  
 The member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> sets the 32-bit range for the spin button control.  
  
> [!NOTE]
>  The default range for the spin button has the maximum set to zero (0) and the minimum set to 100. Because the maximum value is less than the minimum value, clicking the up arrow will decrease the position and clicking the down arrow will increase it. Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to adjust these values.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::GetRange](../vs140/cspinbuttonctrl--getrange.md)   
 [CSpinButtonCtrl::GetPos](../vs140/cspinbuttonctrl--getpos.md)   
 [Using CSpinButtonCtrl](../vs140/using-cspinbuttonctrl.md)