---
title: "CMFCMenuBar::CreateEx"
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
  - "CreateEx"
  - "CMFCMenuBar::CreateEx"
  - "CMFCMenuBar.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: a6f7b8fd-1f3d-4e8b-a336-c92d33acd671
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::CreateEx
Creates a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object with specified extended styles.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the parent window of the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Additional styles for the new menu bar.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The main style of the new menu bar.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter that specifies the sizes for the borders of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The ID for the child window of the menu bar.  
  
## Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
## Remarks  
 You should use this function instead of [CMFCMenuBar::Create](../vs140/cmfcmenubar--create.md) when you want to specify styles in addition to the toolbar style. Some frequently used additional styles are <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For lists of additional styles, see [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439), [common control styles](http://msdn.microsoft.com/library/windows/desktop/bb775498), and [common window styles](http://msdn.microsoft.com/library/windows/desktop/ms632600).  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#1](../vs140/codesnippet/CPP/cmfcmenubar--createex_1.h)]  
[!code[NVC_MFC_IEDemo#2](../vs140/codesnippet/CPP/cmfcmenubar--createex_2.cpp)]  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)