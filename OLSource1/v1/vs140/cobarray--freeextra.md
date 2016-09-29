---
title: "CObArray::FreeExtra"
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
  - "CObArray::FreeExtra"
  - "CObArray.FreeExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FreeExtra method"
  - "CObArray class, operations"
ms.assetid: 2d9f19cb-9a3b-4da4-9a74-8e7149e56e36
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::FreeExtra
Frees any extra memory that was allocated while the array was grown.  
  
## Syntax  
  
```  
  
void FreeExtra( );  
```  
  
## Remarks  
 This function has no effect on the size or upper bound of the array.  
  
 The following table shows other member functions that are similar to `CObArray::FreeExtra`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void FreeExtra( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void FreeExtra( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void FreeExtra( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void FreeExtra( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void FreeExtra( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void FreeExtra( );**|  
  
## Example  
 See the example for [CObArray::GetData](../vs140/cobarray--getdata.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)