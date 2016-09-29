---
title: "CCmdTarget::EndWaitCursor"
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
  - "EndWaitCursor"
  - "CCmdTarget.EndWaitCursor"
  - "CCmdTarget::EndWaitCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, operations"
  - "EndWaitCursor method"
ms.assetid: 9e0b8fe7-33d6-4b85-9b32-a8c7fdc2f7ab
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::EndWaitCursor
Call this function after you have called the `BeginWaitCursor` member function to return from the hourglass cursor to the previous cursor.  
  
## Syntax  
  
```  
  
void EndWaitCursor( );  
```  
  
## Remarks  
 The framework also calls this member function after it has called the hourglass cursor.  
  
## Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget--endwaitcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)   
 [CCmdTarget::BeginWaitCursor](../vs140/ccmdtarget--beginwaitcursor.md)   
 [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md)   
 [CWinApp::DoWaitCursor](../vs140/cwinapp--dowaitcursor.md)