---
title: "COleCmdUI::COleCmdUI"
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
  - "COleCmdUI"
  - "COleCmdUI::COleCmdUI"
  - "COleCmdUI.COleCmdUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleCmdUI class, constructor"
  - "COleCmdUI constructor"
ms.assetid: 8776462c-72c8-4dfa-ac41-eba13544af13
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCmdUI::COleCmdUI
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object associated with a particular user-interface command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A list of supported commands associated with the given GUID. The **OLECMD** structure associates commands with command flags.  
  
 *cCmds*  
 The count of commands in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a GUID that identifies a set of commands.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object provides a programmatic interface for updating DocObject user-interface objects such as menu items or control-bar buttons. The user-interface objects can be enabled, disabled, checked, and/or cleared through the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [COleCmdUI Class](../vs140/colecmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)