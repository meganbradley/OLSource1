---
title: "CCmdTarget::RestoreWaitCursor"
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
  - "CCmdTarget.RestoreWaitCursor"
  - "CCmdTarget::RestoreWaitCursor"
  - "RestoreWaitCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, operations"
  - "RestoreWaitCursor method"
ms.assetid: ed4afeae-1b68-4123-a65c-5a8361340be0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::RestoreWaitCursor
Call this function to restore the appropriate hourglass cursor after the system cursor has changed (for example, after a message box has opened and then closed while in the middle of a lengthy operation).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget--restorewaitcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)   
 [CCmdTarget::EndWaitCursor](../vs140/ccmdtarget--endwaitcursor.md)   
 [CCmdTarget::BeginWaitCursor](../vs140/ccmdtarget--beginwaitcursor.md)   
 [CWinApp::DoWaitCursor](../vs140/cwinapp--dowaitcursor.md)