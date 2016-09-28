---
title: "CMFCToolBarMenuButton::GetCommands"
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
  - "GetCommands"
  - "CMFCToolBarMenuButton::GetCommands"
  - "CMFCToolBarMenuButton.GetCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCommands method"
ms.assetid: d3db98d0-bd69-47a9-b73a-e140d4a5b2eb
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::GetCommands
Gives read-only access to the list of commands in the toolbar menu.  
  
## Syntax  
  
```  
const CObList& GetCommands() const;  
```  
  
## Return Value  
 A const reference to a [CObList](../vs140/coblist-class.md) object, which contains a collection of [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md) objects.  
  
## Remarks  
 A toolbar menu button can display a submenu. You can provide the list of commands in the submenu in the constructor or in [CMFCToolBarMenuButton::CreateFromMenu](../vs140/cmfctoolbarmenubutton--createfrommenu.md) as a handle to a menu (`HMENU`). The menu is converted to a list of objects that are derived from [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md) and stored in the internal `CObList` object. You can access this list by calling this method.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)