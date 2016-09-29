---
title: "CPropertySheet::SetWizardMode"
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
  - "CPropertySheet.SetWizardMode"
  - "CPropertySheet::SetWizardMode"
  - "SetWizardMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWizardMode method"
  - "CPropertySheet class, attributes"
ms.assetid: 31746ad9-0678-4eac-9eac-ab1bf20a51c9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::SetWizardMode
Establishes a property page as a wizard.  
  
## Syntax  
  
```  
  
void SetWizardMode( );  
  
```  
  
## Remarks  
 A key characteristic of a wizard property page is that the user navigates using Next or Finish, Back, and Cancel buttons instead of tabs.  
  
 Call `SetWizardMode` before calling [DoModal](../vs140/cpropertysheet--domodal.md). After you call `SetWizardMode`, `DoModal` will return either **ID_WIZFINISH** (if the user closes with the Finish button) or **IDCANCEL**.  
  
 `SetWizardMode` sets the PSH_WIZARD flag.  
  
## Example  
 [!code[NVC_MFCDocView#142](../vs140/codesnippet/CPP/cpropertysheet--setwizardmode_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)