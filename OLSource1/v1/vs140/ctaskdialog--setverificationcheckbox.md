---
title: "CTaskDialog::SetVerificationCheckbox"
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
  - CTaskDialog.SetVerificationCheckbox
  - SetVerificationCheckbox
  - CTaskDialog::SetVerificationCheckbox
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetVerificationCheckbox method
ms.assetid: 2248d37d-7cf3-4e3c-89ef-dc9bb2e2a9d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::SetVerificationCheckbox
Sets the checked state of the verification check box.  
  
## Syntax  
  
```  
void SetVerificationCheckbox(  
   BOOL bChecked  
);  
```  
  
#### Parameters  
 [in] `bChecked`  
 `TRUE` to have the verification check box selected when the `CTaskDialog` is displayed; `FALSE` to have the verification check box unselected when the `CTaskDialog` is displayed.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#5](../vs140/codesnippet/CPP/ctaskdialog--setverificationcheckbox_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetVerificationCheckboxText](../vs140/ctaskdialog--setverificationcheckboxtext.md)