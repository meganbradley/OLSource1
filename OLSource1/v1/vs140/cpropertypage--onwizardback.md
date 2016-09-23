---
title: "CPropertyPage::OnWizardBack"
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
  - CPropertyPage.OnWizardBack
  - CPropertyPage::OnWizardBack
  - OnWizardBack
dev_langs: 
  - C++
helpviewer_keywords: 
  - property page overridables
  - CPropertyPage class, overridables
  - wizard buttons
  - Back buttons in wizards
  - OnWizardBack method
  - wizards [MFC], buttons
  - buttons, on wizard property pages
ms.assetid: e83fb46a-481a-4eb1-862a-e67aafdbd8de
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::OnWizardBack
This member function is called by the framework when the user clicks on the Back button in a wizard.  
  
## Syntax  
  
```  
  
virtual LRESULT OnWizardBack();  
  
```  
  
## Return Value  
 0 to automatically advance to the next page; –1 to prevent the page from changing. To jump to a page other than the next one, return the identifier of the dialog to be displayed.  
  
## Remarks  
 Override this member function to specify some action the user must take when the Back button is pressed.  
  
 For more information on how to make a wizard-type property sheet, see [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md).  
  
## Example  
 [!code[NVC_MFCDocView#118](../vs140/codesnippet/CPP/cpropertypage--onwizardback_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md)