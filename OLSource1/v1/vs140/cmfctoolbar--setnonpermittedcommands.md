---
title: "CMFCToolBar::SetNonPermittedCommands"
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
  - "CMFCToolBar.SetNonPermittedCommands"
  - "SetNonPermittedCommands"
  - "CMFCToolBar::SetNonPermittedCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetNonPermittedCommands method"
ms.assetid: 3e95179f-a7ca-4c09-aa87-b47d44e15ad1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetNonPermittedCommands
Sets the list of commands that cannot be executed by the user.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that contains the commands that cannot be executed by the user.  
  
## Remarks  
 Call this method to prevent the user from selecting certain commands. For example, you might want to prevent the user from selecting certain commands for security reasons. See the MDITabsDemo and MenuSubSet samples for examples that use this method.  
  
 This method clears the previous list of non-permitted commands. By default, the list of non-permitted commands is empty.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)