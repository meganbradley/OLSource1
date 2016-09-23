---
title: "CWaitCursor::Restore"
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
  - Restore
  - CWaitCursor.Restore
  - CWaitCursor::Restore
dev_langs: 
  - C++
helpviewer_keywords: 
  - Restore method
ms.assetid: 2326c592-5ceb-47c4-9f3c-d3d97eed9cf8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWaitCursor::Restore
To restore the wait cursor, call this function after performing an operation, such as displaying a message box or dialog box, which might change the wait cursor to another cursor.  
  
## Syntax  
  
```  
  
void Restore( );  
  
```  
  
## Remarks  
 It is OK to call **Restore** even when the wait cursor is currently displayed.  
  
 If you need to restore the wait cursor while in a function other than the one in which the `CWaitCursor` object is declared, you can call [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md).  
  
## Example  
 [!code[NVC_MFCWindowing#64](../vs140/codesnippet/CPP/cwaitcursor--restore_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md)