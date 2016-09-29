---
title: "CMFCMaskedEdit::SetWindowText"
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
  - "SetWindowText"
  - "CMFCMaskedEdit.SetWindowText"
  - "CMFCMaskedEdit::SetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowText method"
ms.assetid: eb16eb91-884a-4d12-baaa-f761e5741134
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit::SetWindowText
Displays a prompt in the masked edit control.  
  
## Syntax  
  
```  
void SetWindowText(  
   LPCTSTR lpszString   
);  
```  
  
#### Parameters  
 [in] `lpszString`  
 Points to a null-terminated string that will be used as a prompt.  
  
## Remarks  
 This method sets the control text.  
  
 This method redefines [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md).  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)