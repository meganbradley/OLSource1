---
title: "CMFCToolBarDateTimeCtrl::CanBeStretched"
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
  - CanBeStretched
  - CMFCToolBarDateTimeCtrl.CanBeStretched
  - CMFCToolBarDateTimeCtrl::CanBeStretched
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanBeStretched method
ms.assetid: 6562e93c-5cd6-44c5-b8c0-c6c33391098d
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarDateTimeCtrl::CanBeStretched
Specifies whether a user can stretch the button during customization.  
  
## Syntax  
  
```  
virtual BOOL CanBeStretched() const;  
```  
  
## Return Value  
 This method returns `TRUE`.  
  
## Remarks  
 By default, the framework does not allow the user to stretch a toolbar button during customization. This method extends the base class implementation ([CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton--canbestretched.md)) by allowing the user to stretch a date and time toolbar button during customization.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton--canbestretched.md)