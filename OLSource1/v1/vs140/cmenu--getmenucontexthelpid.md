---
title: "CMenu::GetMenuContextHelpId"
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
  - "CMenu.GetMenuContextHelpId"
  - "GetMenuContextHelpId"
  - "CMenu::GetMenuContextHelpId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuContextHelpId method"
  - "CMenu class, menu item operations"
ms.assetid: 7004a0ab-1657-464d-bef5-7eb870401af6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetMenuContextHelpId
Retrieves the context help ID associated with `CMenu`.  
  
## Syntax  
  
```  
  
DWORD GetMenuContextHelpId( ) const;  
  
```  
  
## Return Value  
 The context help ID currently associated with `CMenu` if it has one; zero otherwise.  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::SetMenuContextHelpId](../vs140/cmenu--setmenucontexthelpid.md)   
 [GetMenuContextHelpId](http://msdn.microsoft.com/library/windows/desktop/bb776428)