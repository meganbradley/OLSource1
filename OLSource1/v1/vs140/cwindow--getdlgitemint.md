---
title: "CWindow::GetDlgItemInt"
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
  - "ATL::CWindow::GetDlgItemInt"
  - "ATL.CWindow.GetDlgItemInt"
  - "CWindow::GetDlgItemInt"
  - "CWindow.GetDlgItemInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgItemInt method"
ms.assetid: e5dcc47a-cca2-4219-b428-1c3f05b6e7df
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetDlgItemInt
Translates a control's text to an integer.  
  
## Syntax  
  
```  
  
      UINT GetDlgItemInt(  
   int nID,  
   BOOL* lpTrans = NULL,  
   BOOL bSigned = TRUE   
) const throw();  
```  
  
## Remarks  
 See [GetDlgItemInt](http://msdn.microsoft.com/library/windows/desktop/ms645485) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetDlgItemInt](../vs140/cwindow--setdlgitemint.md)   
 [CWindow::GetDlgItemText](../vs140/cwindow--getdlgitemtext.md)