---
title: "CD2DRectU Class"
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
  - "CD2DRectU"
  - "afxrendertarget/CD2DRectU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRectU class"
ms.assetid: a62f17d1-011d-4867-8f51-fd7e7c00561d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRectU Class
A wrapper for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::CD2DRectU](#cd2drectu__cd2drectu)|Overloaded. Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::IsNull](#cd2drectu__isnull)|Returns a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value that indicates whether an expression contains no valid data ( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::operator CRect](#cd2drectu__operator_crect)|Converts <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 [CD2DRectU](../vs140/cd2drectu-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2drectu__cd2drectu">\</a>  CD2DRectU::CD2DRectU  
 Constructs a CD2DRectU object from CRect object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 source rectangle  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 source left coordinate  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 source top coordinate  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 source right coordinate  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 source bottom coordinate  
  
##  \<a name="cd2drectu__isnull">\</a>  CD2DRectU::IsNull  
 Returns a Boolean value that indicates whether an expression contains no valid data (Null).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.  
  
##  \<a name="cd2drectu__operator_crect">\</a>  CD2DRectU::operator CRect  
 Converts CD2DRectU to CRect object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Current value of D2D rectangle.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)