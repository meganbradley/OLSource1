---
title: "CMFCToolBar::ProcessCommand"
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
  - "ProcessCommand"
  - "CMFCToolBar.ProcessCommand"
  - "CMFCToolBar::ProcessCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessCommand method"
ms.assetid: b00af7c6-3112-4c17-861f-95c26efd1e71
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::ProcessCommand
Posts a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message to the window that owns the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a button on the toolbar.  
  
## Return Value  
 This method should always return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. MFC uses <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values internally.  
  
## Remarks  
 This method posts a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message to the window that owns the toolbar by calling [CWnd::PostMessage](../vs140/cwnd--postmessage.md) and passing the command ID of the specified button as the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
 Use the [ON_COMMAND](../vs140/on_command.md) macro to map the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message to a member function.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)