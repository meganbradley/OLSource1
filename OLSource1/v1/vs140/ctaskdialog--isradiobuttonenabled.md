---
title: "CTaskDialog::IsRadioButtonEnabled"
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
  - "CTaskDialog::IsRadioButtonEnabled"
  - "IsRadioButtonEnabled"
  - "CTaskDialog.IsRadioButtonEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsRadioButtonEnabled method"
ms.assetid: 53ba6e89-ccde-4531-9133-7578f9b77055
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::IsRadioButtonEnabled
Determines whether a radio button is enabled.  
  
## Syntax  
  
```  
BOOL IsRadioButtonEnabled(  
   int nRadioButtonID  
) const;  
```  
  
#### Parameters  
 [in] `nRadioButtonID`  
 The ID of the radio button to test.  
  
## Return Value  
 `TRUE` if the radio button is enabled, `FALSE` if it is not.  
  
## Remarks  
 If `nRadioButtonID` is not a valid identifier for a radio button, this method throws an exception.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#3](../vs140/codesnippet/CPP/ctaskdialog--isradiobuttonenabled_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddRadioButton](../vs140/ctaskdialog--addradiobutton.md)   
 [CTaskDialog::SetRadioButtonOptions](../vs140/ctaskdialog--setradiobuttonoptions.md)   
 [CTaskDialog::GetSelectedRadioButtonID](../vs140/ctaskdialog--getselectedradiobuttonid.md)   
 [CTaskDialog::SetDefaultRadioButton](../vs140/ctaskdialog--setdefaultradiobutton.md)   
 [CTaskDialog::RemoveAllRadioButtons](../vs140/ctaskdialog--removeallradiobuttons.md)