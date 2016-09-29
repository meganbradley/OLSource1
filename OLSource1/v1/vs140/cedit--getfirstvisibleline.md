---
title: "CEdit::GetFirstVisibleLine"
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
  - "CEdit.GetFirstVisibleLine"
  - "CEdit::GetFirstVisibleLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFirstVisibleLine method"
  - "CEdit class, general operations"
ms.assetid: 8b3fb9d0-7647-42db-bfa2-00ea9d70d574
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetFirstVisibleLine
Call this function to determine the topmost visible line in an edit control.  
  
## Syntax  
  
```  
  
int GetFirstVisibleLine( ) const;  
```  
  
## Return Value  
 The zero-based index of the topmost visible line. For single-line edit controls, the return value is 0.  
  
## Remarks  
 For more information, see [EM_GETFIRSTVISIBLELINE](http://msdn.microsoft.com/library/windows/desktop/bb761574) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#9](../vs140/codesnippet/CPP/cedit--getfirstvisibleline_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::GetLine](../vs140/cedit--getline.md)