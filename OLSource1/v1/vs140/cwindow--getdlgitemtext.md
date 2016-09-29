---
title: "CWindow::GetDlgItemText"
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
  - "ATL.CWindow.GetDlgItemText"
  - "CWindow.GetDlgItemText"
  - "CWindow::GetDlgItemText"
  - "ATL::CWindow::GetDlgItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgItemText method"
ms.assetid: df2e1f60-6a57-46b3-b78c-5588c634a69d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetDlgItemText
Retrieves a control's text.  
  
## Syntax  
  
```  
  
      UINT GetDlgItemText(  
   int nID,  
   LPTSTR lpStr,  
   int nMaxCount   
) const throw();  
BOOL GetDlgItemText(  
   int nID,  
   BSTR& bstrText   
) const throw();  
```  
  
## Remarks  
 See [GetDlgItemText](http://msdn.microsoft.com/library/windows/desktop/ms645489) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The second version of this method allows you to copy the control's text to a `BSTR`. This version returns **TRUE** if the text is successfully copied; otherwise, **FALSE**.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetDlgItemText](../vs140/cwindow--setdlgitemtext.md)   
 [CWindow::GetDlgItem](../vs140/cwindow--getdlgitem.md)