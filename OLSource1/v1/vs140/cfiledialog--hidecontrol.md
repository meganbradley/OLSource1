---
title: "CFileDialog::HideControl"
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
  - "CFileDialog::HideControl"
  - "CFileDialog.HideControl"
  - "HideControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "hiding explorer-style control"
  - "HideControl method"
ms.assetid: aeaf7976-53e7-4167-ba9b-00d9304de343
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::HideControl
Call this member function to hide the specified control in an Explorer-style Open or Save As common dialog box.  
  
## Syntax  
  
```  
  
      void HideControl(  
   int nID   
);  
```  
  
#### Parameters  
 `nID`  
 The ID of the control to hide.  
  
## Remarks  
 The dialog box must have been created with the **OFN_EXPLORER** style; otherwise, the function will fail with an assertion.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDM_HIDECONTROL](http://msdn.microsoft.com/library/windows/desktop/ms646853)   
 [CFileDialog::SetControlText](../vs140/cfiledialog--setcontroltext.md)