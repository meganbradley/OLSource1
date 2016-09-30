---
title: "CMFCRibbonBar::AddContextCategory"
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
  - "AddContextCategory"
  - "CMFCRibbonBar.AddContextCategory"
  - "CMFCRibbonBar::AddContextCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddContextCategory method"
ms.assetid: 7ee02205-5f47-4ba5-aa16-589f73562518
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::AddContextCategory
Creates and initializes a new context category for the ribbon bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the category.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the context category caption.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Context ID.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Color of the context category caption.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Resource ID of the small image of a context category.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Resource ID of the large image of a context category.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Size of a small image.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Size of a large image.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to a runtime class.  
  
## Return Value  
 A pointer to the newly created category, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> cannot create the specified category.  
  
## Remarks  
 Use this function to add a context category. Context categories are a special type of category that can be shown or hidden at runtime, depending on the current application context. For example, when the user selects an object, you can display special tabs with context categories which you use to change the specific selected object.  
  
 The color of a context category can be one of the following values:  
  
-   AFX_CategoryColor_None  
  
-   AFX_CategoryColor_Red  
  
-   AFX_CategoryColor_Orange  
  
-   AFX_CategoryColor_Yellow  
  
-   AFX_CategoryColor_Green  
  
-   AFX_CategoryColor_Blue  
  
-   AFX_CategoryColor_Indigo  
  
-   AFX_CategoryColor_Violet  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)