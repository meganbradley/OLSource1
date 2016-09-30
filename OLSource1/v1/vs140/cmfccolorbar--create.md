---
title: "CMFCColorBar::Create"
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
  - "CMFCColorBar.Create"
  - "Create"
  - "CMFCColorBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: dc42b9e6-183f-460a-81e8-507579f451d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::Create
Creates a color bar control window and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of [window styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The command ID.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a palette of colors. The default is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The number of columns in the color bar control. The default is 0.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The number of rows in the color bar control when it is docked horizontally. The default is 0.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The number of columns in the color bar control when it is docked vertically. The default is 0.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 To construct a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, call the class constructor then this method. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method creates the Windows control and initializes a list of colors.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)