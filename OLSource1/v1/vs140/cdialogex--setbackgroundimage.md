---
title: "CDialogEx::SetBackgroundImage"
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
  - "SetBackgroundImage"
  - "CDialogEx.SetBackgroundImage"
  - "CDialogEx::SetBackgroundImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBackgroundImage method"
ms.assetid: a20173b4-3a54-4679-8361-174dc86b0b0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogEx::SetBackgroundImage
Sets the background image of the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to the background image.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the background image.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 One of the  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values that specify the location of the image. Valid values include BACKGR_TILE, BACKGR_TOPLEFT, BACKGR_TOPRIGHT, BACKGR_BOTTOMLEFT, and BACKGR_BOTTOMRIGHT. The default value is BACKGR_TILE.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to automatically destroy the background image; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to immediately redraw the dialog box; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 In the second method overload syntax, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the method is successful; otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The image that you specify is not stretched to fit the dialog box client area.  
  
## Requirements  
 **Header:** afxdialogex.h  
  
## See Also  
 [CDialogEx Class](../vs140/cdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)