---
title: "CMFCColorBar::CreateControl"
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
  - "CMFCColorBar::CreateControl"
  - "CMFCColorBar.CreateControl"
  - "CreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControl method"
ms.assetid: efd84d0d-43c8-46c1-b54c-f56acac87a61
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::CreateControl
Creates a color bar control window, attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, and resizes the control window to contain the specified palette of colors.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the parent window. Cannot be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the color bar control.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The ideal number of columns in the color bar control. This method modifies that number to fit the specified palette of colors. The default is -1, which means this parameter is not specified.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to a palette of colors, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If this parameter is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, this method calculates the size of the color bar control as if 20 colors were specified. The default is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if this method succeeds; otherwise <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters to calculate the appropriate number or rows and columns in the color bar control, and then calls the [CMFCColorBar::Create](../vs140/cmfccolorbar--create.md) method.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorBar::Create](../vs140/cmfccolorbar--create.md)