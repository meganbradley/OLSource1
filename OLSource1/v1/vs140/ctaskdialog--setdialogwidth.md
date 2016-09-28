---
title: "CTaskDialog::SetDialogWidth"
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
  - "CTaskDialog.SetDialogWidth"
  - "SetDialogWidth"
  - "CTaskDialog::SetDialogWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDialogWidth method"
ms.assetid: 6f552246-0c2f-4b22-8ad8-c457a681a872
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetDialogWidth
Adjusts the width of the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetDialogWidth(  
   int nWidth = 0  
);  
```  
  
#### Parameters  
 [in] `nWidth`  
 The width of the dialog box, in pixels.  
  
## Remarks  
 The parameter `nWidth` must be greater than or equal to 0. Otherwise, this method throws an exception.  
  
 If `nWidth` is set to 0, this method sets the dialog box to the default size.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setdialogwidth_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)