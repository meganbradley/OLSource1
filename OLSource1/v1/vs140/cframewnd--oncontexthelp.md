---
title: "CFrameWnd::OnContextHelp"
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
  - "CFrameWnd::OnContextHelp"
  - "CFrameWnd.OnContextHelp"
  - "OnContextHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnContextHelp method"
  - "CFrameWnd class, command handlers"
ms.assetid: 4be7bbf3-17ac-4bdb-a187-c598cbfece94
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::OnContextHelp
Handles SHIFT+F1 Help for in-place items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 To enable context-sensitive help, you must add an  
  
 [!code[NVC_MFCDocViewSDI#16](../vs140/codesnippet/CPP/cframewnd--oncontexthelp_1.cpp)]  
  
 statement to your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class message map and also add an accelerator-table entry, typically SHIFT+F1, to enable this member function.  
  
 If your application is an OLE Container, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> puts all in-place items contained within the frame window object into Help mode. The cursor changes to an arrow and a question mark, and the user can then move the mouse pointer and press the left mouse button to select a dialog box, window, menu, or command button. This member function calls the Windows function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with the Help context of the object under the cursor.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)