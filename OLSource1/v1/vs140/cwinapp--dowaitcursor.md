---
title: "CWinApp::DoWaitCursor"
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
  - "CWinApp::DoWaitCursor"
  - "DoWaitCursor"
  - "CWinApp.DoWaitCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoWaitCursor method"
  - "CWinApp class, overridables"
  - "wait cursors"
ms.assetid: 15697c83-a43d-4f22-a710-08e0d63e1b6b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::DoWaitCursor
This member function is called by the framework to implement [CWaitCursor](../vs140/cwaitcursor-class.md), [CCmdTarget::BeginWaitCursor](../vs140/ccmdtarget--beginwaitcursor.md), [CCmdTarget::EndWaitCursor](../vs140/ccmdtarget--endwaitcursor.md), and [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If this parameter is 1, a wait cursor appears. If 0, the wait cursor is restored without incrementing the reference count. If –1, the wait cursor ends.  
  
## Remarks  
 The default implements an hourglass cursor. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> maintains a reference count. When positive, the hourglass cursor is displayed.  
  
 While you would not normally call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directly, you could override this member function to change the wait cursor or to do additional processing while the wait cursor is displayed.  
  
 For an easier, more streamlined way to implement a wait cursor, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCWindowing#37](../vs140/codesnippet/CPP/cwinapp--dowaitcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::BeginWaitCursor](../vs140/ccmdtarget--beginwaitcursor.md)   
 [CCmdTarget::EndWaitCursor](../vs140/ccmdtarget--endwaitcursor.md)   
 [CCmdTarget::RestoreWaitCursor](../vs140/ccmdtarget--restorewaitcursor.md)   
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)