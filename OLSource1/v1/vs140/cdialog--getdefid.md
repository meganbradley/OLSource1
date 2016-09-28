---
title: "CDialog::GetDefID"
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
  - "GetDefID"
  - "CDialog::GetDefID"
  - "CDialog.GetDefID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, operations"
  - "GetDefID method"
ms.assetid: 2e0dd782-bb16-418f-a647-ee04af76f5e6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::GetDefID
Call the `GetDefID` member function to get the ID of the default pushbutton control for a dialog box.  
  
## Syntax  
  
```  
  
DWORD GetDefID( ) const;  
```  
  
## Return Value  
 A 32-bit value (`DWORD`). If the default pushbutton has an ID value, the high-order word contains **DC_HASDEFID** and the low-order word contains the ID value. If the default pushbutton does not have an ID value, the return value is 0.  
  
## Remarks  
 This is usually an OK button.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::SetDefID](../vs140/cdialog--setdefid.md)   
 [DM_GETDEFID](http://msdn.microsoft.com/library/windows/desktop/ms645406)