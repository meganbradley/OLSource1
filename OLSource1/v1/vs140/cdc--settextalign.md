---
title: "CDC::SetTextAlign"
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
  - "SetTextAlign"
  - "CDC::SetTextAlign"
  - "CDC.SetTextAlign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextAlign method"
  - "CDC class, text functions"
ms.assetid: b5f47e43-0f47-4dde-a959-892e9cc733d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetTextAlign
Sets the text-alignment flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies text-alignment flags. The flags specify the relationship between a point and a rectangle that bounds the text. The point can be either the current position or coordinates specified by a text-output function. The rectangle that bounds the text is defined by the adjacent character cells in the text string. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter can be one or more flags from the following three categories. Choose only one flag from each category. The first category affects text alignment in the x-direction:  
  
-   **TA_CENTER** Aligns the point with the horizontal center of the bounding rectangle.  
  
-   **TA_LEFT** Aligns the point with the left side of the bounding rectangle. This is the default setting.  
  
-   **TA_RIGHT** Aligns the point with the right side of the bounding rectangle.  
  
 The second category affects text alignment in the y-direction:  
  
-   **TA_BASELINE** Aligns the point with the base line of the chosen font.  
  
-   **TA_BOTTOM** Aligns the point with the bottom of the bounding rectangle.  
  
-   **TA_TOP** Aligns the point with the top of the bounding rectangle. This is the default setting.  
  
 The third category determines whether the current position is updated when text is written:  
  
-   **TA_NOUPDATECP** Does not update the current position after each call to a text-output function. This is the default setting.  
  
-   **TA_UPDATECP** Updates the current x-position after each call to a text-output function. The new position is at the right side of the bounding rectangle for the text. When this flag is set, the coordinates specified in calls to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function are ignored.  
  
## Return Value  
 The previous text-alignment setting, if successful. The low-order byte contains the horizontal setting and the high-order byte contains the vertical setting; otherwise 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member functions use these flags when positioning a string of text on a display or device. The flags specify the relationship between a specific point and a rectangle that bounds the text. The coordinates of this point are passed as parameters to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function. The rectangle that bounds the text is formed by the adjacent character cells in the text string.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExtTextOut](../vs140/cdc--exttextout.md)   
 [CDC::GetTextAlign](../vs140/cdc--gettextalign.md)   
 [CDC::TabbedTextOut](../vs140/cdc--tabbedtextout.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [SetTextAlign](http://msdn.microsoft.com/library/windows/desktop/dd145091)