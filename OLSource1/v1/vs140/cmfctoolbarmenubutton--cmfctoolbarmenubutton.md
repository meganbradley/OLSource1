---
title: "CMFCToolBarMenuButton::CMFCToolBarMenuButton"
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
  - "CMFCToolBarMenuButton::CMFCToolBarMenuButton"
  - "CMFCToolBarMenuButton.CMFCToolBarMenuButton"
  - "CMFCToolBarMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarMenuButton class, constructor"
ms.assetid: 65199590-87e0-4bc8-a79b-70b94c44b007
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::CMFCToolBarMenuButton
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be copied into this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The ID of the command to execute when a user clicks the button; or (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>)-1 for a menu button that does not directly execute a command.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A handle to a menu; or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the button does not have a menu.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Index of the image for the button; or -1 if this button does not have an icon or uses the icon for the command specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The index is the same for each <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object in your application.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The text of the toolbar menu button.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the button displays a user-defined image; <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the button displays a predefined image associated with the command specified by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a valid command ID, the button performs that command when the user clicks it. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a valid menu handle, the button provides a drop-down menu when it appears in a toolbar or a submenu when it appears in a menu. If both <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are valid, the button is a split-button with a portion that will perform the command when the user clicks on it and a portion with a down arrow that will drop-down a menu when the user clicks on it. However, if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is valid, a user will not be able to click the button to perform a command when the button is inserted into a menu.  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#9](../vs140/codesnippet/CPP/cmfctoolbarmenubutton--cmfctoolbarmenubutton_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)