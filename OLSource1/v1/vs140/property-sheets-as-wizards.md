---
title: "Property Sheets as Wizards"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property sheets, as wizards"
ms.assetid: 1ea66ecb-23b0-484a-838d-58671a2999b5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property Sheets as Wizards
A key characteristic of a wizard property sheet is that navigation is provided with Next or Finish, Back, and Cancel buttons instead of tabs. You need to call [CPropertySheet::SetWizardMode](../vs140/cpropertysheet--setwizardmode.md) before calling [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md) on the property sheet object to take advantage of this feature.  
  
 The user receives the same [CPropertyPage::OnSetActive](../vs140/cpropertypage--onsetactive.md) and [CPropertyPage::OnKillActive](../vs140/cpropertypage--onkillactive.md) notifications while moving from one page to another page. Next and Finish buttons are mutually exclusive controls; that is, only one of them will be shown at a time. On the first page, the Next button should be enabled. If the user is on the last page, the Finish button should be enabled. This is not done automatically by the framework. You have to call [CPropertySheet::SetWizardButton](../vs140/cpropertysheet--setwizardbuttons.md) on the last page to achieve this.  
  
 To display all of the default buttons, you mush show the Finish button and move the Next button. Then move the Back button so that its relative position to the Next button is maintained. For more explanation, search for KB article Q143210. Knowledge Base articles are available in the MSDN Library.  
  
## Example  
 [!code[NVC_MFCDocView#5](../vs140/codesnippet/CPP/property-sheets-as-wizards_1.cpp)]  
  
## See Also  
 [Property Sheets](../vs140/property-sheets--mfc-.md)