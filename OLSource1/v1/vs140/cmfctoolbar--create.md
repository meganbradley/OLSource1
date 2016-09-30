---
title: "CMFCToolBar::Create"
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
  - "CMFCToolBar.Create"
  - "CMFCToolBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 2998c9a3-5f27-4c1f-9bc6-4ff98d4a8b20
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::Create
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the parent window of the toolbar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The toolbar style. See [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for the list of styles.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ID of the child window of the toolbar.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method succeeds; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method creates a control bar and attaches it to the toolbar. It creates the control bar with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> style. Call [CMFCToolBar::CreateEx](../vs140/cmfctoolbar--createex.md) if you want a different control bar style.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::CreateEx](../vs140/cmfctoolbar--createex.md)