---
title: "CArray::GetData"
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
  - "CArray::GetData"
  - "CArray.GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetData method [MFC]"
ms.assetid: 2bc7347a-943a-470f-81bd-6cb400572353
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::GetData
Use this member function to gain direct access to the elements in an array.  
  
## Syntax  
  
```  
  
      const   
      TYPE  
      * GetData( ) const;  
TYPE* GetData( );  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of the array elements.  
  
## Return Value  
 A pointer to an array element.  
  
## Remarks  
 If no elements are available, `GetData` returns a null value.  
  
 While direct access to the elements of an array can help you work more quickly, use caution when calling `GetData`; any errors you make directly affect the elements of your array.  
  
## Example  
 [!code[NVC_MFCCollections#28](../vs140/codesnippet/CPP/carray--getdata_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetAt](../vs140/carray--getat.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::ElementAt](../vs140/carray--elementat.md)