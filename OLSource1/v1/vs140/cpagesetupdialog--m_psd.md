---
title: "CPageSetupDialog::m_psd"
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
  - CPageSetupDialog.m_psd
  - CPageSetupDialog::m_psd
  - m_psd
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_psd method
  - CPageSetupDialog class, data members
ms.assetid: e3704958-251b-4979-8f58-7a61ba3df4f2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPageSetupDialog::m_psd
A structure of type **PAGESETUPDLG**, whose members store the characteristics of the dialog object.  
  
## Syntax  
  
```  
  
PAGESETUPDLG m_psd;  
  
```  
  
## Remarks  
 After constructing a `CPageSetupDialog` object, you can use `m_psd` to set various aspects of the dialog box before calling the `DoModal` member function.  
  
 If you modify the `m_psd` data member directly, you will override any default behavior.  
  
 For more information on the [PAGESETUPDLG](http://msdn.microsoft.com/library/windows/desktop/ms646842) structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 See the example for [CPageSetupDialog::CPageSetupDialog](../vs140/cpagesetupdialog--cpagesetupdialog.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)