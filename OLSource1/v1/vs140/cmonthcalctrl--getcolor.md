---
title: "CMonthCalCtrl::GetColor"
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
  - "CMonthCalCtrl.GetColor"
  - "CMonthCalCtrl::GetColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, attributes"
  - "GetColor method"
ms.assetid: 6b139276-552a-4b46-a4ee-713ffbdd8a3f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetColor
Retrieves the color of an area of the month calendar control specified by `nRegion`.  
  
## Syntax  
  
```  
  
      COLORREF GetColor(  
   int nRegion   
) const;  
```  
  
#### Parameters  
 `nRegion`  
 The region of the month calendar control from which the color is retrieved. For a list of values, see the `nRegion` parameter of [SetColor](../vs140/cmonthcalctrl--setcolor.md).  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value specifying the color associated with the portion of the month calendar control, if successful. Otherwise, this member function returns -1.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetColor](../vs140/cmonthcalctrl--setcolor.md)