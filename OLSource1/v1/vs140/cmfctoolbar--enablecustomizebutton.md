---
title: "CMFCToolBar::EnableCustomizeButton"
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
  - "EnableCustomizeButton"
  - "CMFCToolBar.EnableCustomizeButton"
  - "CMFCToolBar::EnableCustomizeButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableCustomizeButton method"
ms.assetid: 1ab6c056-55c5-4b02-a755-ae89feeca04b
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::EnableCustomizeButton
Enables or disables the Customize button that appears on the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Enables or disables the Customize button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command ID of the Customize button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The text label of the Customize button.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The resource string ID of the Customize button label.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Enables or disables the **Add or Remove Buttons** option on the menu that drops down from the button.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is -1, the framework displays the Customize button when multiple toolbar buttons do not fit in the toolbar area. The button displays a double left-pointing arrow, or chevron, which indicates that there are more buttons.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> specifies a valid command ID, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the Customize button is always displayed. The button has a small down arrow and opens a menu that contains a command. This command uses the text label specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is also <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the menu displays the **Add or Remove Buttons** option.  
  
 The framework dynamically adds to the menu any buttons that do not fit in the toolbar area before the item that is specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The chevron is displayed next to the down arrow.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)