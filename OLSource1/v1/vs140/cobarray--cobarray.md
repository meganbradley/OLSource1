---
title: "CObArray::CObArray"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CObArray.CObArray
  - CObArray::CObArray
dev_langs: 
  - C++
helpviewer_keywords: 
  - CObArray class, constructor
ms.assetid: 3e1ee3a7-e7b3-41ee-bb91-2699e3522a63
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObArray::CObArray
Constructs an empty `CObject` pointer array.  
  
## Syntax  
  
```  
  
CObArray( );  
```  
  
## Remarks  
 The array grows one element at a time.  
  
 The following table shows other constructors that are similar to `CObArray::CObArray`.  
  
|Class|Constructor|  
|-----------|-----------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**CByteArray( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**CDWordArray( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**CPtrArray( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CStringArray( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**CUIntArray( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**CWordArray( );**|  
  
## Example  
 [!code[NVC_MFCCollections#78](../vs140/codesnippet/CPP/cobarray--cobarray_1.cpp)]
  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::CObList](../vs140/coblist--coblist.md)