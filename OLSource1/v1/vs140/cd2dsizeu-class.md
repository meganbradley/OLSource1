---
title: "CD2DSizeU Class"
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
  - "CD2DSizeU"
  - "afxrendertarget/CD2DSizeU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DSizeU class"
ms.assetid: 6e679ba8-2112-43c3-8275-70b660856f02
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DSizeU Class
A wrapper for D2D1_SIZE_U.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSizeU::CD2DSizeU](#cd2dsizeu__cd2dsizeu)|Overloaded. Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSizeU::IsNull](#cd2dsizeu__isnull)|Returns a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value that indicates whether an expression contains no valid data ( <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSizeU::operator CSize](#cd2dsizeu__operator_csize)|Converts <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 [CD2DSizeU](../vs140/cd2dsizeu-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dsizeu__cd2dsizeu">\</a>  CD2DSizeU::CD2DSizeU  
 Constructs a CD2DSizeU object from CSize object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 source size  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 source width  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 source height  
  
##  \<a name="cd2dsizeu__isnull">\</a>  CD2DSizeU::IsNull  
 Returns a Boolean value that indicates whether an expression contains no valid data (Null).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if width and height are empty; otherwise FALSE.  
  
##  \<a name="cd2dsizeu__operator_csize">\</a>  CD2DSizeU::operator CSize  
 Converts CD2DSizeU to CSize object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Current value of D2D size.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)