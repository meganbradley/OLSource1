---
title: "CTaskDialog::SetVerificationCheckboxText"
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
  - "CTaskDialog.SetVerificationCheckboxText"
  - "SetVerificationCheckboxText"
  - "CTaskDialog::SetVerificationCheckboxText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetVerificationCheckboxText method"
ms.assetid: 6659cfc7-1e00-41fc-bb4f-9b0b1f1feff8
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetVerificationCheckboxText
Sets the text that is displayed to the right of the verification check box.  
  
## Syntax  
  
```  
void SetVerificationCheckboxText(  
   CString& strVerificationText  
);  
```  
  
#### Parameters  
 [in] `strVerificationText`  
 The text that this method displays next to the verification check box.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if this instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) is already displayed.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#5](../vs140/codesnippet/CPP/ctaskdialog--setverificationcheckboxtext_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetVerificationCheckbox](../vs140/ctaskdialog--setverificationcheckbox.md)