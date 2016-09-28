---
title: "CMFCToolBarDateTimeCtrl::GetDateTimeCtrl"
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
  - "GetDateTimeCtrl"
  - "CMFCToolBarDateTimeCtrl::GetDateTimeCtrl"
  - "CMFCToolBarDateTimeCtrl.GetDateTimeCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDateTimeCtrl method"
ms.assetid: 15958fc2-5899-4f30-a5b9-7b7cebe6a672
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::GetDateTimeCtrl
Returns a pointer to the date and time picker control.  
  
## Syntax  
  
```  
CDateTimeCtrl* GetDateTimeCtrl() const;  
```  
  
## Return Value  
 A pointer to date and time picker control; or `NULL` if the control does not exist.  
  
## Remarks  
 The `CMFCToolBarDateTimeCtrl` class initializes the `m_pWndDateTime` data member when you insert a `CMFCToolBarDateTimeCtrl` object into a toolbar.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)