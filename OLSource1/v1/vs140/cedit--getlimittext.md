---
title: "CEdit::GetLimitText"
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
  - "CEdit::GetLimitText"
  - "CEdit.GetLimitText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLimitText method"
ms.assetid: 50192248-8d98-4aae-923d-4c8b1149563b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetLimitText
Call this member function to get the text limit for this `CEdit` object.  
  
## Syntax  
  
```  
  
UINT GetLimitText( ) const;  
  
```  
  
## Return Value  
 The current text limit, in bytes, for this `CEdit` object.  
  
## Remarks  
 The text limit is the maximum amount of text, in bytes, that the edit control can accept.  
  
> [!NOTE]
>  This member function is available beginning with Windows 95 and Windows NT 4.0.  
  
 For more information, see [EM_GETLIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761582) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#11](../vs140/codesnippet/CPP/cedit--getlimittext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetLimitText](../vs140/cedit--setlimittext.md)   
 [CEdit::LimitText](../vs140/cedit--limittext.md)