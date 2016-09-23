---
title: "CTaskDialog::LoadRadioButtons"
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
  - CTaskDialog::LoadRadioButtons
  - CTaskDialog.LoadRadioButtons
  - LoadRadioButtons
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadRadioButtons method
ms.assetid: ed035c7b-8736-4144-8c73-ba03205ca58d
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::LoadRadioButtons
Adds radio button controls by using data from the string table.  
  
## Syntax  
  
```  
void LoadRadioButtons(  
   int nIDRadioButtonsFirst,  
   int nIDRadioButtonsLast  
);  
```  
  
#### Parameters  
 [in] `nIDRadioButtonsFirst`  
 The string ID of the first radio button.  
  
 [in] `nIDRadioButtonsLast`  
 The string ID of the last radio button.  
  
## Remarks  
 This method creates radio buttons by using data from the resource file of your application. The string table in the resource file has several strings with associated string IDs. New radio buttons added by using this method use the string for the radio button's caption and the string ID for the radio button's ID. The range of strings selected is provided by `nIDRadioButtonsFirst` and `nRadioButtonsLast`, inclusive. If there is an empty entry in the range, the method does not add a radio button for that entry.  
  
 By default, new radio buttons are enabled.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#3](../vs140/codesnippet/CPP/ctaskdialog--loadradiobuttons_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddRadioButton](../vs140/ctaskdialog--addradiobutton.md)   
 [CTaskDialog::SetRadioButtonOptions](../vs140/ctaskdialog--setradiobuttonoptions.md)   
 [CTaskDialog::RemoveAllRadioButtons](../vs140/ctaskdialog--removeallradiobuttons.md)