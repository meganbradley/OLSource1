---
title: "CTaskDialog::SetFooterText"
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
  - CTaskDialog::SetFooterText
  - SetFooterText
  - CTaskDialog.SetFooterText
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetFooterText method
ms.assetid: c3101e6b-fbb8-4670-8fa4-5c9abd7548a7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::SetFooterText
Updates the text on the footer of the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetFooterText(  
   const CString& strFooterText  
);  
```  
  
#### Parameters  
 [in] `strFooterText`  
 The new text for the footer.  
  
## Remarks  
 The footer icon appears next to the footer text on the bottom of the `CTaskDialog`. You can change the footer icon with [CTaskDialog::SetFooterIcon](../vs140/ctaskdialog--setfootericon.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setfootertext_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetFooterIcon](../vs140/ctaskdialog--setfootericon.md)