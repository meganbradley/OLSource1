---
title: "CWnd::RunModalLoop"
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
  - "CWnd::RunModalLoop"
  - "RunModalLoop"
  - "CWnd.RunModalLoop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RunModalLoop method"
  - "modal loop functions"
  - "loop structures, modal loops"
  - "dialog box functions"
  - "messages, control functions"
ms.assetid: 20563fad-e9d3-4b35-9d70-65918f44c6e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::RunModalLoop
Call this member function to retrieve, translate, or dispatch messages until [ContinueModal](../vs140/cwnd--continuemodal.md) returns **FALSE**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the Windows message to be sent. Can be one of the following values:  
  
-   **MLF_NOIDLEMSG** Don't send [WM_ENTERIDLE](http://msdn.microsoft.com/library/windows/desktop/ms645422) messages to the parent.  
  
-   **MLF_NOKICKIDLE** Don't send **WM_KICKIDLE** messages to the window.  
  
-   **MLF_SHOWONIDLE** Show the window when message queue goes idle.  
  
## Return Value  
 Specifies the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter passed to the [EndModalLoop](../vs140/cwnd--endmodalloop.md) member function, which is then used to end the modal loop.  
  
## Remarks  
 By default, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns **FALSE** after <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called. Returns the value provided as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EndModalLoop](../vs140/cwnd--endmodalloop.md)   
 [WM_ENTERIDLE](http://msdn.microsoft.com/library/windows/desktop/ms645422)