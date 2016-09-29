---
title: "CDateTimeCtrl::GetMonthCalFont"
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
  - "GetMonthCalFont"
  - "CDateTimeCtrl::GetMonthCalFont"
  - "CDateTimeCtrl.GetMonthCalFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMonthCalFont method"
ms.assetid: c02c92bc-accf-4504-bd83-51dd55c620a6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetMonthCalFont
Gets the font currently used by the date and time picker control's month calendar control.  
  
## Syntax  
  
```  
  
CFont* GetMonthCalFont( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CFont](../vs140/cfont-class.md) object, or **NULL** if unsuccessful.  
  
## Remarks  
 The `CFont` object pointed to by the return value is a temporary object and is destroyed during the next idle processing time.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::SetMonthCalFont](../vs140/cdatetimectrl--setmonthcalfont.md)