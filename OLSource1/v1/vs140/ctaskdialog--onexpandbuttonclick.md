---
title: "CTaskDialog::OnExpandButtonClick"
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
  - "CTaskDialog::OnExpandButtonClick"
  - "OnExpandButtonClick"
  - "CTaskDialog.OnExpandButtonClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnExpandButtonClick method"
ms.assetid: ea79fcb6-cab6-4f82-9b7c-7a6b83297f3b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnExpandButtonClick
The framework calls this method when the user clicks on the expansion button.  
  
## Syntax  
  
```  
virtual HRESULT OnExpandButtonClicked(  
   BOOL bExpanded  
);  
```  
  
#### Parameters  
 [in] `bExpanded`  
 A nonzero value indicates the extra information is displayed; 0 indicates the extra information is hidden.  
  
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