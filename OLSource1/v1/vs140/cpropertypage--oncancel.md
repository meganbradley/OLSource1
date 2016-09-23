---
title: "CPropertyPage::OnCancel"
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
  - CPropertyPage::OnCancel
  - CPropertyPage.OnCancel
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPropertyPage class, overridables
  - OnCancel method
  - property pages, overridables
  - Cancel button on property pages
ms.assetid: dd40bd2b-7782-46da-938f-ddf16a42decc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::OnCancel
This member function is called by the framework when the Cancel button is selected.  
  
## Syntax  
  
```  
  
virtual void OnCancel( );  
```  
  
## Remarks  
 Override this member function to perform Cancel button actions. The default negates any changes that have been made.  
  
## Example  
 [!code[NVC_MFCDocView#114](../vs140/codesnippet/CPP/cpropertypage--oncancel_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::OnApply](../vs140/cpropertypage--onapply.md)   
 [CDialog::OnCancel](../vs140/cdialog--oncancel.md)   
 [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md)