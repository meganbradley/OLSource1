---
title: "CMFCToolBarButton::SetProtectedCommands"
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
  - "SetProtectedCommands"
  - "CMFCToolBarButton.SetProtectedCommands"
  - "CMFCToolBarButton::SetProtectedCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProtectedCommands method"
ms.assetid: 2d8cfdf6-262d-45eb-9c6c-8f1b31116e57
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetProtectedCommands
Sets the list of commands that the user cannot customize.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The list of protected commands.  
  
## Remarks  
 In customization mode, the framework disables toolbar button commands that are protected. The user cannot perform drag-and-drop and edit operations on disabled toolbar buttons.  
  
 Use the [CMFCToolBarButton::GetProtectedCommands](../vs140/cmfctoolbarbutton--getprotectedcommands.md) method to retrieve the list of protected commands.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetProtectedCommands](../vs140/cmfctoolbarbutton--getprotectedcommands.md)