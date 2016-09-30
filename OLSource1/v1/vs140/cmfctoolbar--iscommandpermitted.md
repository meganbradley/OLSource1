---
title: "CMFCToolBar::IsCommandPermitted"
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
  - "CMFCToolBar.IsCommandPermitted"
  - "IsCommandPermitted"
  - "CMFCToolBar::IsCommandPermitted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsCommandPermitted method"
ms.assetid: a475875e-b778-4d0c-a179-ee8da552f1be
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsCommandPermitted
Determines whether a command is permitted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the command to check.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the specified command is permitted; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This static method determines whether the command specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> belongs to the global list of non-permitted commands.  
  
 You can change the list of non-permitted commands by calling [CMFCToolBar::SetNonPermittedCommands](../vs140/cmfctoolbar--setnonpermittedcommands.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)