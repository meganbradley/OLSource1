---
title: "CDateTimeCtrl::GetMonthCalCtrl"
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
  - "CDateTimeCtrl.GetMonthCalCtrl"
  - "CDateTimeCtrl::GetMonthCalCtrl"
  - "GetMonthCalCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMonthCalCtrl method"
ms.assetid: 80db45df-e256-421e-b2b7-a8c984154c40
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetMonthCalCtrl
Retrieves the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object associated with the date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CMonthCalCtrl](../vs140/cmonthcalctrl-class.md) object, or **NULL** if unsuccessful or if the window is not visible.  
  
## Remarks  
 Date and time picker controls create a child month calendar control when the user clicks the drop-down arrow. When the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is no longer needed, it is destroyed, so your application must not rely on storing the object representing the date time picker control's child month calendar.  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#3](../vs140/codesnippet/CPP/cdatetimectrl--getmonthcalctrl_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)