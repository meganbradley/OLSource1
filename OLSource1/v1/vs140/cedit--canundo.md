---
title: "CEdit::CanUndo"
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
  - CEdit.CanUndo
  - CanUndo
  - CEdit::CanUndo
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanUndo method
  - CEdit class, general operations
ms.assetid: f8372005-7360-45aa-ad18-60ec2ce3b774
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEdit::CanUndo
Call this function to determine if the last edit operation can be undone.  
  
## Syntax  
  
```  
  
BOOL CanUndo( ) const;  
```  
  
## Return Value  
 Nonzero if the last edit operation can be undone by a call to the **Undo** member function; 0 if it cannot be undone.  
  
## Remarks  
 For more information, see [EM_CANUNDO](http://msdn.microsoft.com/library/windows/desktop/bb775468) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::Undo](../vs140/cedit--undo.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::Undo](../vs140/cedit--undo.md)   
 [CEdit::EmptyUndoBuffer](../vs140/cedit--emptyundobuffer.md)