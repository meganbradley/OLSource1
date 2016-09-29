---
title: "CCmdTarget::BeginWaitCursor"
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
  - "CCmdTarget.BeginWaitCursor"
  - "CCmdTarget::BeginWaitCursor"
  - "BeginWaitCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, operations"
  - "BeginWaitCursor method"
ms.assetid: 48736a92-53cf-4b00-a581-7986e81208f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::BeginWaitCursor
Call this function to display the cursor as an hourglass when you expect a command to take a noticeable time interval to execute.  
  
## Syntax  
  
```  
  
void BeginWaitCursor( );  
```  
  
## Remarks  
 The framework calls this function to show the user that it is busy, such as when a **CDocument** object loads or saves itself to a file.  
  
 The actions of `BeginWaitCursor` are not always effective outside of a single message handler as other actions, such as `OnSetCursor` handling, could change the cursor.  
  
 Call `EndWaitCursor` to restore the previous cursor.  
  
## Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget--beginwaitcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)   
 [CCmdTarget::EndWaitCursor](../vs140/ccmdtarget--endwaitcursor.md)   
 [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md)   
 [CWinApp::DoWaitCursor](../vs140/cwinapp--dowaitcursor.md)