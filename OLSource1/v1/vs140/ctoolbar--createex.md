---
title: "CToolBar::CreateEx"
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
  - "CToolBar::CreateEx"
  - "CToolBar.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbars [C++], creating"
  - "CreateEx method"
  - "CToolBarCtrl class, creation of"
ms.assetid: e4ee8f3a-a8dc-4577-a4fe-ac932c794c7b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::CreateEx
Call this function to create a Windows toolbar (a child window) and associate it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the window that is the toolbar's parent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Additional styles for the creation of the embedded [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object. By default, this value is set to **TBSTYLE_FLAT**. For a complete list of toolbar styles, see <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The toolbar style. See [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of appropriate styles.  
  
 *rcBorders*  
 A [CRect](../vs140/crect-class.md) object that defines the widths of the toolbar window borders. These borders are set to 0,0,0,0 by default, thereby resulting in a toolbar window with no borders.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The toolbar's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 It also sets the toolbar height to a default value.  
  
 Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, instead of [Create](../vs140/ctoolbar--create.md), when certain styles need to be present during the creation of the embedded tool bar control. For example, set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to **TBSTYLE_FLAT &#124; TBSTYLE_TRANSPARENT** to create a toolbar that resembles the Internet Explorer 4 toolbars.  
  
## Example  
 [!code[NVC_MFCDocView#180](../vs140/codesnippet/CPP/ctoolbar--createex_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)