---
title: "CPropertyPage::OnWizardFinish"
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
  - CPropertyPage.OnWizardFinish
  - CPropertyPage::OnWizardFinish
  - OnWizardFinish
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnWizardFinish method
  - property page overridables
  - CPropertyPage class, overridables
  - Finish buttons in wizards
  - buttons, on wizard property pages
ms.assetid: 933318e6-f4dd-401c-9ed2-fd2964a2e419
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::OnWizardFinish
This member function is called by the framework when the user clicks on the Finish button in a wizard.  
  
## Syntax  
  
```  
  
virtual BOOL OnWizardFinish( );  
  
```  
  
## Return Value  
 Nonzero if the property sheet is destroyed when the wizard finishes; otherwise zero.  
  
## Remarks  
 When a user clicks the **Finish** button in a wizard, the framework calls this function; when `OnWizardFinish` returns **TRUE** (a nonzero value), the property sheet is able to be destroyed (but is not actually destroyed). Call `DestroyWindow` to destroy the property sheet. Do not call `DestroyWindow` from `OnWizardFinish`; doing so will cause heap corruption or other errors.  
  
 You can override this member function to specify some action the user must take when the Finish button is pressed. When overriding this function, return **FALSE** to prevent the property sheet from being destroyed.  
  
 For more information about notification messages sent when the user presses the Finish button in a wizard property sheet, see [PSN_WIZFINISH](http://msdn.microsoft.com/library/windows/desktop/bb774571) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on how to make a wizard-type property sheet, see [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md).  
  
## Example  
 [!code[NVC_MFCDocView#119](../vs140/codesnippet/CPP/cpropertypage--onwizardfinish_1.cpp)]
  
  
 [!code[NVC_MFCDocView#120](../vs140/codesnippet/CPP/cpropertypage--onwizardfinish_2.cpp)]
  
  
 [!code[NVC_MFCDocView#121](../vs140/codesnippet/CPP/cpropertypage--onwizardfinish_3.cpp)]
  
  
 [!code[NVC_MFCDocView#122](../vs140/codesnippet/CPP/cpropertypage--onwizardfinish_4.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md)