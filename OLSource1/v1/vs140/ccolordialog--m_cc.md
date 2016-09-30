---
title: "CColorDialog::m_cc"
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
  - "CColorDialog.m_cc"
  - "CColorDialog::m_cc"
  - "m_cc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CColorDialog class, data members"
  - "m_cc"
ms.assetid: 472c73c0-d411-401b-a0e0-81e28560ab02
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog::m_cc
A structure of type [CHOOSECOLOR](http://msdn.microsoft.com/library/windows/desktop/ms646830), whose members store the characteristics and values of the dialog box.  
  
## Syntax  
  
```  
  
CHOOSECOLOR m_cc;  
```  
  
## Remarks  
 After constructing a `CColorDialog` object, you can use `m_cc` to set various aspects of the dialog box before calling the [DoModal](../vs140/ccolordialog--domodal.md) member function.  
  
## Example  
 [!code[NVC_MFCDocView#53](../vs140/codesnippet/CPP/ccolordialog--m_cc_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)