---
title: "CObArray::Copy"
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
  - "CObArray::Copy"
  - "CObArray.Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Copy method"
  - "CObArray class, growing the array"
ms.assetid: 6e0f3e2e-2c36-464b-a8a3-4dc28442ae4d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::Copy
Call this member function to overwrite the elements of the given array with the elements of another array of the same type.  
  
## Syntax  
  
```  
  
      void Copy(  
   const CObArray& src   
);  
```  
  
#### Parameters  
 *src*  
 Source of the elements to be copied to the array.  
  
## Remarks  
 **Copy** does not free memory; however, if necessary, **Copy** may allocate extra memory to accommodate the elements copied to the array.  
  
 The following table shows other member functions that are similar to `CObArray::Copy`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void Copy( const CByteArray&**  *src*  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void Copy( const CDWordArray&**  *src*  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void Copy( const CPtrArray&**  *src*  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void Copy( const CStringArray&**  *src*  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void Copy( const CUIntArray&**  *src*  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void Copy( const CWordArray&**  *src*  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#77](../vs140/codesnippet/CPP/cobarray--copy_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::Append](../vs140/cobarray--append.md)