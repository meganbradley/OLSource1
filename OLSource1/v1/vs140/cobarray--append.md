---
title: "CObArray::Append"
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
  - "CObArray::Append"
  - "CObArray.Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, growing the array"
  - "Append method"
ms.assetid: f2716ed0-d0b4-449a-b234-e6a4f9619934
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::Append
Call this member function to add the contents of another array to the end of the given array.  
  
## Syntax  
  
```  
  
      INT_PTR Append(  
   const CObArray& src   
);  
```  
  
#### Parameters  
 *src*  
 Source of the elements to be appended to the array.  
  
## Return Value  
 The index of the first appended element.  
  
## Remarks  
 The arrays must be of the same type.  
  
 If necessary, **Append** may allocate extra memory to accommodate the elements appended to the array.  
  
 The following table shows other member functions that are similar to `CObArray::Append`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR Append( const CByteArray&**  *src*  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR Append( const CDWordArray&**  *src*  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR Append( const CPtrArray&**  *src*  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR Append( const CStringArray&**  *src*  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR Append( const CUIntArray&**  *src*  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR Append( const CWordArray&**  *src*  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#76](../vs140/codesnippet/CPP/cobarray--append_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::Copy](../vs140/cobarray--copy.md)