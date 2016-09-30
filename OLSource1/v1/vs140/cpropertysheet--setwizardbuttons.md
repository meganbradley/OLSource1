---
title: "CPropertySheet::SetWizardButtons"
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
  - "CPropertySheet.SetWizardButtons"
  - "CPropertySheet::SetWizardButtons"
  - "SetWizardButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWizardButtons method"
  - "CPropertySheet class, attributes"
ms.assetid: 97484c08-23b6-4033-a441-22f3734be0c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::SetWizardButtons
Enables or disables the Back, Next, or Finish button in a wizard property sheet.  
  
## Syntax  
  
```  
  
      void SetWizardButtons(  
   DWORD dwFlags   
);  
```  
  
#### Parameters  
 `dwFlags`  
 A set of flags that customize the function and appearance of the wizard buttons. This parameter can be a combination of the following values:  
  
-   **PSWIZB_BACK** Back button  
  
-   **PSWIZB_NEXT** Next button  
  
-   **PSWIZB_FINISH** Finish button  
  
-   **PSWIZB_DISABLEDFINISH** Disabled Finish button  
  
## Remarks  
 Call `SetWizardButtons` only after the dialog is open; you can't call `SetWizardButtons` before you call [DoModal](../vs140/cpropertysheet--domodal.md). Typically, you should call `SetWizardButtons` from [CPropertyPage::OnSetActive](../vs140/cpropertypage--onsetactive.md).  
  
 If you want to change the text on the Finish button or hide the Next and Back buttons once the user has completed the wizard, call [SetFinishText](../vs140/cpropertysheet--setfinishtext.md). Note that the same button is shared for Finish and Next. You can display a Finish or a Next button at one time, but not both.  
  
## Example  
 A `CPropertySheet` has three wizard property pages: `CStylePage`, `CColorPage`, and `CShapePage`.  The code fragment below shows how to enable and disable the **Back** and **Next** buttons on the wizard property page.  
  
 [!code[NVC_MFCDocView#140](../vs140/codesnippet/CPP/cpropertysheet--setwizardbuttons_1.cpp)]  
  
 [!code[NVC_MFCDocView#141](../vs140/codesnippet/CPP/cpropertysheet--setwizardbuttons_2.cpp)]  
  
 [!code[NVC_MFCDocView#138](../vs140/codesnippet/CPP/cpropertysheet--setwizardbuttons_3.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)