---
title: "CEdit::Undo"
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
  - "CEdit::Undo"
  - "CEdit.Undo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Undo method"
  - "CEdit class, general operations"
ms.assetid: 42d938a4-1f03-4678-a972-fa599db21873
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Undo
Call this function to undo the last edit-control operation.  
  
## Syntax  
  
```  
  
BOOL Undo( );  
```  
  
## Return Value  
 For a single-line edit control, the return value is always nonzero. For a multiple-line edit control, the return value is nonzero if the undo operation is successful, or 0 if the undo operation fails.  
  
## Remarks  
 An undo operation can also be undone. For example, you can restore deleted text with the first call to **Undo**. As long as there is no intervening edit operation, you can remove the text again with a second call to **Undo**.  
  
 For more information, see [EM_UNDO](http://msdn.microsoft.com/library/windows/desktop/bb761670) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#25](../vs140/codesnippet/CPP/cedit--undo_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::CanUndo](../vs140/cedit--canundo.md)