---
title: "CTaskDialog::AddRadioButton"
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
  - "CTaskDialog::AddRadioButton"
  - "AddRadioButton"
  - "CTaskDialog.AddRadioButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRadioButton method"
ms.assetid: df67d201-5d67-423f-9798-d57ef1fccba9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::AddRadioButton
Adds a radio button to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The identification number of the radio button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> displays next to the radio button.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the radio button is enabled.  
  
## Remarks  
 The radio buttons for the [CTaskDialog Class](../vs140/ctaskdialog-class.md) enable you to gather information from the user. Use the function [CTaskDialog::GetSelectedRadioButtonID](../vs140/ctaskdialog--getselectedradiobuttonid.md) to determine which radio button is selected.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not require that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters are unique for each radio button. However, you may experience unexpected behavior if you do not use a distinct identifier for each radio button.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#3](../vs140/codesnippet/CPP/ctaskdialog--addradiobutton_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::GetSelectedRadioButtonID](../vs140/ctaskdialog--getselectedradiobuttonid.md)   
 [CTaskDialog::LoadRadioButtons](../vs140/ctaskdialog--loadradiobuttons.md)   
 [CTaskDialog::IsRadioButtonEnabled](../vs140/ctaskdialog--isradiobuttonenabled.md)   
 [CTaskDialog::SetRadioButtonOptions](../vs140/ctaskdialog--setradiobuttonoptions.md)   
 [CTaskDialog::ClickRadioButton](../vs140/ctaskdialog--clickradiobutton.md)   
 [CTaskDialog::RemoveAllRadioButtons](../vs140/ctaskdialog--removeallradiobuttons.md)