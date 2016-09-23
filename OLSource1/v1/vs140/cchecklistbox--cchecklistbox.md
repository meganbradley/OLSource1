---
title: "CCheckListBox::CCheckListBox"
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
  - CCheckListBox::CCheckListBox
  - CCheckListBox.CCheckListBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - CCheckListBox class, constructor
ms.assetid: 7ef3c30a-ddf0-40fc-a9d5-6e7c429d11a0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCheckListBox::CCheckListBox
Constructs a `CCheckListBox` object.  
  
## Syntax  
  
```  
  
CCheckListBox( );  
  
```  
  
## Remarks  
 You construct a `CCheckListBox` object in two steps. First define a class derived from `CCheckListBox`, then call **Create**, which initializes the Windows checklist box and attaches it to the `CCheckListBox` object.  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#60](../vs140/codesnippet/CPP/cchecklistbox--cchecklistbox_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::Create](../vs140/cchecklistbox--create.md)