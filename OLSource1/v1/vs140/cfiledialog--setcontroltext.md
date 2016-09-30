---
title: "CFileDialog::SetControlText"
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
  - "CFileDialog::SetControlText"
  - "CFileDialog.SetControlText"
  - "SetControlText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "SetControlText method"
ms.assetid: b4c54ed6-d73a-4537-87e0-9d32672faeab
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetControlText
Call this method to set the text for the specified control in an Explorer-style **Open** or **Save As** dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of the control for which to set the text.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the string that contains the text to set for the control.  
  
## Remarks  
 Both versions of this function are valid for applications that use Unicode. However, only the version with the LPCSTR type is valid for applications that use [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)].  
  
 To use this method, you must create the dialog box with the OFN_EXPLORER style. Otherwise, the function will fail with an assertion.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDM_SETCONTROLTEXT](http://msdn.microsoft.com/library/windows/desktop/ms646855)   
 [CFileDialog::HideControl](../vs140/cfiledialog--hidecontrol.md)