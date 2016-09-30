---
title: "CArray::Append"
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
  - "CArray::Append"
  - "CArray.Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, growing the array"
  - "Append method"
ms.assetid: 6d596113-a5d2-4c29-9bd1-571a028ce162
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::Append
Call this member function to add the contents of one array to the end of another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *src*  
 Source of the elements to be appended to an array.  
  
## Return Value  
 The index of the first appended element.  
  
## Remarks  
 The arrays must be of the same type.  
  
 If necessary, **Append** may allocate extra memory to accommodate the elements appended to the array.  
  
## Example  
 [!code[NVC_MFCCollections#23](../vs140/codesnippet/CPP/carray--append_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::Copy](../vs140/carray--copy.md)