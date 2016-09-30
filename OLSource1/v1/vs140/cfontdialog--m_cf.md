---
title: "CFontDialog::m_cf"
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
  - "CFontDialog::m_cf"
  - "m_cf"
  - "CFontDialog.m_cf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFontDialog class, data members"
  - "m_cf"
ms.assetid: 81dd4051-8ffb-4b9b-8663-3228ca83260f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog::m_cf
A structure whose members store the characteristics of the dialog object.  
  
## Syntax  
  
```  
  
CHOOSEFONT m_cf;  
  
```  
  
## Remarks  
 After constructing a `CFontDialog` object, you can use `m_cf` to modify various aspects of the dialog box before calling the `DoModal` member function. For more information on this structure, see [CHOOSEFONT](http://msdn.microsoft.com/library/windows/desktop/ms646832) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#89](../vs140/codesnippet/CPP/cfontdialog--m_cf_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)