---
title: "CMFCToolBarDateTimeCtrl::SetTime"
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
  - "CMFCToolBarDateTimeCtrl.SetTime"
  - "CMFCToolBarDateTimeCtrl::SetTime"
  - "SetTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTime method"
ms.assetid: 6b12e277-a80c-4156-8913-67358b9630b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::SetTime
Sets the time and date in the time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the first version, a reference to a [COleDateTime](../vs140/coledatetime-class.md) object that contains the time to which the control will be set. In the second version, a pointer to a [CTime](../vs140/ctime-class.md) object that contains the time to which the control will be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the time to which the control will be set.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Sets the time in a date and time picker control by calling [CDateTimeCtrl::SetTime](../vs140/cdatetimectrl--settime.md).  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)