---
title: "CMFCMaskedEdit::GetWindowText"
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
  - "GetWindowText"
  - "CMFCMaskedEdit.GetWindowText"
  - "CMFCMaskedEdit::GetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowText method"
ms.assetid: d8b07704-8dda-4021-a91f-4de611a7f2a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit::GetWindowText
Retrieves validated text from the masked edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives the text from the edit control.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The maximum number of characters to receive.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to the string object that receives the text from the edit control.  
  
## Return Value  
 The first method overload returns the number of bytes of the string that is copied to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter buffer; 0 if the masked edit control has no text.  
  
## Remarks  
 This method copies the text from the masked edit control to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> buffer or the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> string.  
  
 This method redefines [CWnd::GetWindowText](../vs140/cwnd--getwindowtext.md).  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)