---
title: "CFileDialog::SetDefExt"
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
  - "CFileDialog.SetDefExt"
  - "SetDefExt"
  - "CFileDialog::SetDefExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefExt method"
  - "CFileDialog class, operations"
ms.assetid: 06ccc1fe-5364-4835-abdf-5e1896c62472
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetDefExt
Call this function to set the default file name extension for an Explorer-style Open or Save As common dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the default extension to use for the dialog box object. This string must not contain a period (.).  
  
## Remarks  
 The dialog box must have been created with the **OFN_EXPLORER** style; otherwise, the function will fail with an assertion.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDM_SETDEFEXT](http://msdn.microsoft.com/library/windows/desktop/ms646856)