---
title: "CEdit::SetReadOnly"
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
  - "CEdit.SetReadOnly"
  - "SetReadOnly"
  - "CEdit::SetReadOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetReadOnly method"
  - "CEdit class, general operations"
ms.assetid: 88d3547e-f4aa-4ec7-b41c-54f132fa5b05
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetReadOnly
Calls this function to set the read-only state of an edit control.  
  
## Syntax  
  
```  
  
      BOOL SetReadOnly(  
   BOOL bReadOnly = TRUE   
);  
```  
  
#### Parameters  
 `bReadOnly`  
 Specifies whether to set or remove the read-only state of the edit control. A value of **TRUE** sets the state to read-only; a value of **FALSE** sets the state to read/write.  
  
## Return Value  
 Nonzero if the operation is successful, or 0 if an error occurs.  
  
## Remarks  
 The current setting can be found by testing the [ES_READONLY](../vs140/edit-styles.md) flag in the return value of [CWnd::GetStyle](../vs140/cwnd--getstyle.md).  
  
 For more information, see [EM_SETREADONLY](http://msdn.microsoft.com/library/windows/desktop/bb761655) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#23](../vs140/codesnippet/CPP/cedit--setreadonly_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetStyle](../vs140/cwnd--getstyle.md)