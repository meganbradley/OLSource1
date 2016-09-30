---
title: "CTaskDialog::SetDefaultRadioButton"
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
  - "SetDefaultRadioButton"
  - "CTaskDialog.SetDefaultRadioButton"
  - "CTaskDialog::SetDefaultRadioButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultRadioButton method"
ms.assetid: ce5115fb-4bbc-4214-bd19-5c63a4b1b93b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetDefaultRadioButton
Specifies the default radio button.  
  
## Syntax  
  
```  
void SetDefaultRadioButton(  
   int nRadioButtonID  
);  
```  
  
#### Parameters  
 [in] `nRadioButtonID`  
 The ID of the radio button to be the default.  
  
## Remarks  
 The default radio button is the button that is selected when the `CTaskDialog` is first displayed to the user.  
  
 This method throws an exception if it cannot find the radio button specified by `nRadioButtonID`.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#3](../vs140/codesnippet/CPP/ctaskdialog--setdefaultradiobutton_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddRadioButton](../vs140/ctaskdialog--addradiobutton.md)   
 [CTaskDialog::SetRadioButtonOptions](../vs140/ctaskdialog--setradiobuttonoptions.md)   
 [CTaskDialog::GetSelectedRadioButtonID](../vs140/ctaskdialog--getselectedradiobuttonid.md)   
 [CTaskDialog::IsRadioButtonEnabled](../vs140/ctaskdialog--isradiobuttonenabled.md)   
 [CTaskDialog::RemoveAllRadioButtons](../vs140/ctaskdialog--removeallradiobuttons.md)