---
title: "CFileDialog::GetOFN"
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
  - "CFileDialog.GetOFN"
  - "CFileDialog::GetOFN"
  - "GetOFN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetOFN method"
ms.assetid: 9b27b347-16da-44c0-a178-0d9fa270f2f0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetOFN
Retrieves the associated **OPENFILENAME** structure.  
  
## Syntax  
  
```  
  
      const OPENFILENAME& GetOFN( ) const;   
OPENFILENAME& GetOFN( );  
```  
  
## Return Value  
 An [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure.  
  
## Remarks  
 Use the second version of this function to initialize the appearance of a **File Open** or **File Save As** dialog box after it is constructed but before it is displayed with the `DoModal` member function. For example, you can set the **lpstrTitle** member of **m_ofn** to the caption you want the dialog box to have.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::m_ofn](../vs140/cfiledialog--m_ofn.md)