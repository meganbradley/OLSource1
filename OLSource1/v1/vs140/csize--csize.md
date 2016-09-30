---
title: "CSize::CSize"
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
  - "CSize::CSize"
  - "CSize.CSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSize class, constructor"
  - "CSize class, construction/destruction"
ms.assetid: 85e88e37-259c-4858-823f-98d545c7c51e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSize::CSize
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *initCX*  
 Sets the **cx** member for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 *initCY*  
 Sets the **cy** member for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object used to initialize <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [POINT](../vs140/point-structure.md) structure or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object used to initialize <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> used to initialize <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The low-order word is the **cx** member and the high-order word is the **cy** member.  
  
## Remarks  
 If no arguments are given, **cx** and **cy** are initialized to zero.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#97](../vs140/codesnippet/CPP/csize--csize_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CSize Class](../vs140/csize-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)