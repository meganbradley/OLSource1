---
title: "CToolBar::GetToolBarCtrl"
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
  - "GetToolBarCtrl"
  - "CToolBar::GetToolBarCtrl"
  - "CToolBar.GetToolBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolBarCtrl method"
  - "CToolBar class, attributes"
ms.assetid: 34cea1c6-ffcd-4dbc-b072-a3faaf0beeaa
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::GetToolBarCtrl
This member function allows direct access to the underlying common control.  
  
## Syntax  
  
```  
  
CToolBarCtrl& GetToolBarCtrl( ) const;  
  
```  
  
## Return Value  
 A reference to a `CToolBarCtrl` object.  
  
## Remarks  
 Use `GetToolBarCtrl` to take advantage of the functionality of the Windows toolbar common control, and to take advantage of the support [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) provides for toolbar customization.  
  
 For more information about using common controls, see the article [Controls](../vs140/controls--mfc-.md) and [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocViewSDI#15](../vs140/codesnippet/CPP/ctoolbar--gettoolbarctrl_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)