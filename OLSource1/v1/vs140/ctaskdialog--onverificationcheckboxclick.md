---
title: "CTaskDialog::OnVerificationCheckboxClick"
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
  - "CTaskDialog::OnVerificationCheckboxClick"
  - "CTaskDialog.OnVerificationCheckboxClick"
  - "OnVerificationCheckboxClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnVerificationCheckboxClick method"
ms.assetid: 17f61946-24eb-491a-a06e-01f047a344fc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnVerificationCheckboxClick
The framework calls this method when the user clicks the verification check box.  
  
## Syntax  
  
```  
virtual HRESULT OnVerificationCheckboxClick(  
   BOOL bChecked  
);  
```  
  
#### Parameters  
 [in] `bChecked`  
 `TRUE` indicates the verification check box is selected; `FALSE` indicates it is not.  
  
## Return Value  
 The default implementation returns `S_OK`.  
  
## Remarks  
 Override this method in a derived class to implement custom behavior.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::TaskDialogCallback](../vs140/ctaskdialog--taskdialogcallback.md)