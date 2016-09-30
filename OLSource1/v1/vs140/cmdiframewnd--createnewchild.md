---
title: "CMDIFrameWnd::CreateNewChild"
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
  - "CreateNewChild"
  - "CMDIFrameWnd::CreateNewChild"
  - "CMDIFrameWnd.CreateNewChild"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateNewChild method"
ms.assetid: 71e4096a-ac0b-4685-9724-2741652c2afd
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWnd::CreateNewChild
Creates a new child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The run-time class of the child window to be created.  
  
 *nResource*  
 The ID of shared resources associated with the child window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The child window's menu.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The child window's accelerator.  
  
## Remarks  
 Use this function to create child windows of an MDI frame window.  
  
## Example  
 [!code[NVC_MFCWindowing#15](../vs140/codesnippet/CPP/cmdiframewnd--createnewchild_1.cpp)]  
  
 This example is an excerpt from Knowledge Base article Q201045, "HOWTO: Add Multiple Window Types to a Non-Document/View MDI App." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)