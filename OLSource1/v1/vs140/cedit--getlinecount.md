---
title: "CEdit::GetLineCount"
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
  - "CEdit.GetLineCount"
  - "CEdit::GetLineCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, multiple-line operations"
  - "GetLineCount method"
ms.assetid: d892c86d-deb0-416d-beec-45694911dae9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetLineCount
Call this function to retrieve the number of lines in a multiple-line edit control.  
  
## Syntax  
  
```  
  
int GetLineCount( ) const;  
```  
  
## Return Value  
 An integer containing the number of lines in the multiple-line edit control. If no text has been entered into the edit control, the return value is 1.  
  
## Remarks  
 `GetLineCount` is only processed by multiple-line edit controls.  
  
 For more information, see [EM_GETLINECOUNT](http://msdn.microsoft.com/library/windows/desktop/bb761586) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#12](../vs140/codesnippet/CPP/cedit--getlinecount_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)