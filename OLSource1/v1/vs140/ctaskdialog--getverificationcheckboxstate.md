---
title: "CTaskDialog::GetVerificationCheckboxState"
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
  - "GetVerificationCheckboxState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetVerificationCheckboxState method"
ms.assetid: cb78596a-a2a2-4d2b-89b8-7f4e067f82ba
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::GetVerificationCheckboxState
Retrieves the state of the verification check box.  
  
## Syntax  
  
```  
BOOL GetVerificationCheckboxState() const;  
```  
  
## Return Value  
 `TRUE` if the check box is checked, `FALSE` if it is not.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#5](../vs140/codesnippet/CPP/ctaskdialog--getverificationcheckboxstate_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetVerificationCheckbox](../vs140/ctaskdialog--setverificationcheckbox.md)   
 [CTaskDialog::SetVerificationCheckboxText](../vs140/ctaskdialog--setverificationcheckboxtext.md)