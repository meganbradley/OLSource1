---
title: "CMFCPopupMenu::Create"
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
  - "Create"
  - "CMFCPopupMenu::Create"
  - "CMFCPopupMenu.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: f3c387e1-2027-4519-b55d-781a321ac602
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::Create
Creates a pop-up menu and attaches it to a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The parent window for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The horizontal screen coordinate for the location of the pop-up menu  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The vertical screen coordinate for the location of the pop-menu.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A handle to a menu resource.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the menu is customizable. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> indicates that the pop-up menu is customizable.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the framework routes the menu messages. See the Remarks section for more details.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the framework routes any menu messages to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must not be <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the framework routes the menu messages to the parent pop-up menu.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#1](../vs140/codesnippet/CPP/cmfcpopupmenu--create_1.cpp)]  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)