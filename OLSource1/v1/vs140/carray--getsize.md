---
title: "CArray::GetSize"
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
  - "CArray::GetSize"
  - "CArray.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, attributes"
  - "GetSize method"
ms.assetid: a8b8c484-a66c-48bf-9cc3-c177a2525734
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::GetSize
Returns the size of the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Because indexes are zero-based, the size is 1 greater than the largest index. Calling this method will generate the same result as the [CArray::GetCount](../vs140/carray--getcount.md) method.  
  
## Example  
 [!code[NVC_MFCCollections#29](../vs140/codesnippet/CPP/carray--getsize_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetUpperBound](../vs140/carray--getupperbound.md)   
 [CArray::GetCount](../vs140/carray--getcount.md)