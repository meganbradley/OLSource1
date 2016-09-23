---
title: "CPropertyPage::OnWizardNext"
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
  - OnWizardNext
  - CPropertyPage::OnWizardNext
  - CPropertyPage.OnWizardNext
dev_langs: 
  - C++
helpviewer_keywords: 
  - property page overridables
  - CPropertyPage class, overridables
  - OnWizardNext method
  - Next buttons on wizards
  - buttons, on wizard property pages
ms.assetid: 33878416-2554-4d78-8262-5c77444401bc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::OnWizardNext
This member function is called by the framework when the user clicks on the Next button in a wizard.  
  
## Syntax  
  
```  
  
virtual LRESULT OnWizardNext();  
  
```  
  
## Return Value  
 0 to automatically advance to the next page; –1 to prevent the page from changing. To jump to a page other than the next one, return the identifier of the dialog to be displayed.  
  
## Remarks  
 Override this member function to specify some action the user must take when the Next button is pressed.  
  
 For more information on how to make a wizard-type property sheet, see [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md).  
  
## Example  
 [!code[NVC_MFCDocView#123](../vs140/codesnippet/CPP/cpropertypage--onwizardnext_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md)