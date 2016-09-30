---
title: "CMFCToolBar::CreateEx"
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
  - "CMFCToolBar::CreateEx"
  - "CreateEx"
  - "CMFCToolBar.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: b348ea2e-68ae-47d2-8919-767c2b3f4749
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CreateEx
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that uses additional style options, such as large icons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the parent window of the toolbar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Additional styles for creating the embedded control bar object.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The toolbar style. See [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) for a list of appropriate styles.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that specifies the widths of the toolbar window borders.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The ID of the child window of the toolbar.  
  
## Return Value  
 Nonzero if this method succeeds; otherwise 0.  
  
## Remarks  
 This method creates a control bar and attaches it to the toolbar.  
  
 Call this method instead of [CMFCToolBar::Create](../vs140/cmfctoolbar--create.md) when you want to provide specific styles. For example, set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to create a toolbar that resembles the toolbars that are used by Internet Explorer 4.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar--createex_1.h)]  
[!code[NVC_MFC_IEDemo#7](../vs140/codesnippet/CPP/cmfctoolbar--createex_2.cpp)]  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::Create](../vs140/cmfctoolbar--create.md)