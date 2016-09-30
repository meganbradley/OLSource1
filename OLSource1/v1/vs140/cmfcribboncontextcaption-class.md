---
title: "CMFCRibbonContextCaption Class"
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
  - "CMFCRibbonContextCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonContextCaption class"
ms.assetid: cce2c0a2-8370-4266-997e-f8d0eeb3d616
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonContextCaption Class
Implements a colored caption that appears at the top of a ribbon category or a context category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCRibbonContextCaption::GetColor](#cmfcribboncontextcaption__getcolor)|Returns the color of the caption.|  
|[CMFCRibbonContextCaption::GetRightTabX](#cmfcribboncontextcaption__getrighttabx)||  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
  
## Remarks  
 This class cannot be directly instantiated. The [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) class uses this class internally to add color to ribbon categories.  
  
 To set the color for ribbon categories, call [CMFCRibbonCategory::SetTabColor](../vs140/cmfcribboncategory-class.md#cmfcribboncategory__settabcolor). To set the color for context categories, call [CMFCRibbonBar::AddContextCategory](../vs140/cmfcribbonbar-class.md#cmfcribbonbar__addcontextcategory).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonContextCaption](../vs140/cmfcribboncontextcaption-class.md)  
  
## Requirements  
 **Header:** afxRibbonBar.h  
  
##  \<a name="cmfcribboncontextcaption__getcolor">\</a>  CMFCRibbonContextCaption::GetColor  
 Returns the background color of the caption.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The returned value can be one of the following enumerated values:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
### Remarks  
 The color of the caption can be set by calling [CMFCRibbonCategory::SetTabColor](../vs140/cmfcribboncategory-class.md#cmfcribboncategory__settabcolor) or [CMFCRibbonBar::AddContextCategory](../vs140/cmfcribbonbar-class.md#cmfcribbonbar__addcontextcategory).  
  
##  \<a name="cmfcribboncontextcaption__getrighttabx">\</a>  CMFCRibbonContextCaption::GetRightTabX  
 Retrieves the position of the right-hand edge of the category’s ribbon tab.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns the right-hand X-value of the enclosing rectangle of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object’s ribbon tab, or a value of -1 if the tab is truncated.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md)   
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)