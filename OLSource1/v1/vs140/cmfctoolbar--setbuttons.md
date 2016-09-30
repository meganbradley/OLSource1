---
title: "CMFCToolBar::SetButtons"
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
  - "CMFCToolBar::SetButtons"
  - "SetButtons"
  - "CMFCToolBar.SetButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtons method"
ms.assetid: 08e97608-1652-4777-bd63-6dba16ec1597
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetButtons
Sets the buttons for the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the array of command IDs of the buttons to insert.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of items in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to associate the existing button images with the inserted buttons. If this parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the images are remapped.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 Call this method to remove existing buttons from a toolbar and insert a collection of new buttons.  
  
 This method adds the **Customize** button to the toolbar and sends the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message to the parent window of the toolbar. For more information about the **Customize** button, see [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md)