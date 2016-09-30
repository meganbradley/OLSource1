---
title: "CMenu::SetDefaultItem"
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
  - "CMenu.SetDefaultItem"
  - "SetDefaultItem"
  - "CMenu::SetDefaultItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultItem method"
ms.assetid: db995d2e-eaaa-48e1-b4eb-e67ff5071082
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::SetDefaultItem
Sets the default menu item for the specified menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifier or position of the new default menu item or - 1 for no default item. The meaning of this parameter depends on the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Value specifying the meaning of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If this parameter is **FALSE**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a menu item identifier. Otherwise, it is a menu item position.  
  
## Return Value  
 If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, use the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function implements the behavior of the Win32 function [SetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647996), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::GetDefaultItem](../vs140/cmenu--getdefaultitem.md)