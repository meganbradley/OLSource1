---
title: "CTaskDialog::SetRadioButtonOptions"
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
  - "CTaskDialog::SetRadioButtonOptions"
  - "CTaskDialog.SetRadioButtonOptions"
  - "SetRadioButtonOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRadioButtonOptions method"
ms.assetid: 688066a5-6067-490b-a634-2d098f61bc5e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetRadioButtonOptions
Enables or disables a radio button.  
  
## Syntax  
  
```  
void SetRadioButtonOptions(  
   int nRadioButtonID,  
   BOOL bEnabled  
);  
```  
  
#### Parameters  
 [in] `nRadioButtonID`  
 The ID of the radio button control.  
  
 [in] `bEnabled`  
 `TRUE` to enable the radio button; `FALSE` to disable the radio button.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if `nRadioButtonID` is not a valid ID for a radio button.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#3](../vs140/codesnippet/CPP/ctaskdialog--setradiobuttonoptions_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddRadioButton](../vs140/ctaskdialog--addradiobutton.md)   
 [CTaskDialog::GetSelectedRadioButtonID](../vs140/ctaskdialog--getselectedradiobuttonid.md)   
 [CTaskDialog::IsRadioButtonEnabled](../vs140/ctaskdialog--isradiobuttonenabled.md)   
 [CTaskDialog::SetDefaultRadioButton](../vs140/ctaskdialog--setdefaultradiobutton.md)   
 [CTaskDialog::RemoveAllRadioButtons](../vs140/ctaskdialog--removeallradiobuttons.md)