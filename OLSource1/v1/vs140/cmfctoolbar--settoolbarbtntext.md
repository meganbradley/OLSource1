---
title: "CMFCToolBar::SetToolBarBtnText"
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
  - "CMFCToolBar::SetToolBarBtnText"
  - "CMFCToolBar.SetToolBarBtnText"
  - "SetToolBarBtnText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetToolBarBtnText method"
ms.assetid: ac59f487-1db5-4502-b6df-5379903c6045
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetToolBarBtnText
Specifies properties of a button on the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the toolbar button in the list of toolbar buttons.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the text label of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the framework shows the text label. Otherwise, the framework hides the text label.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the framework shows the toolbar button image. Otherwise, the framework hides the toolbar button image.  
  
## Remarks  
 By default, the framework shows the images of toolbar buttons but does not show the text label of toolbar buttons.  
  
 In Debug builds, this method generates an assertion failure if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not refer to a valid toolbar button or the toolbar button is a separator.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)