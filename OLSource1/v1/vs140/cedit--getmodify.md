---
title: "CEdit::GetModify"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetModify
  - CEdit.GetModify
  - CEdit::GetModify
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetModify method
  - CEdit class, general operations
ms.assetid: e6925dcd-71ed-47bc-9133-502c49e43dd9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEdit::GetModify
Call this function to determine whether the contents of an edit control have been modified.  
  
## Syntax  
  
```  
  
BOOL GetModify( ) const;  
```  
  
## Return Value  
 Nonzero if the edit-control contents have been modified; 0 if they have remained unchanged.  
  
## Remarks  
 Windows maintains an internal flag indicating whether the contents of the edit control have been changed. This flag is cleared when the edit control is first created and may also be cleared by calling the [SetModify](../vs140/cedit--setmodify.md) member function.  
  
 For more information, see [EM_GETMODIFY](http://msdn.microsoft.com/library/windows/desktop/bb761592) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#13](../vs140/codesnippet/CPP/cedit--getmodify_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetModify](../vs140/cedit--setmodify.md)