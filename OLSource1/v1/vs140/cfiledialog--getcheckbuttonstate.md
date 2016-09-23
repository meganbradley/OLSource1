---
title: "CFileDialog::GetCheckButtonState"
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
  - afxdlgs/CFileDialog::GetCheckButtonState
  - GetCheckButtonState
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCheckButtonState
ms.assetid: c44f6dea-5a87-4701-a670-8c9393a6860c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::GetCheckButtonState
Retrieves the current state of a check button (check box) in the dialog.  
  
## Syntax  
  
```  
HRESULT GetCheckButtonState(  
   DWORD dwIDCtl,  
   BOOL& bChecked  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the check box.  
  
 `bChecked`  
 The state of the check box. `TRUE` indicates checked; `FALSE` indicates unchecked.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)