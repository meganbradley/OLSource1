---
title: "CObArray::RemoveAll"
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
  - "CObArray::RemoveAll"
  - "CObArray.RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, operations"
  - "RemoveAll method"
ms.assetid: 2e45ab17-92cd-4a42-9fc5-d0507a825617
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::RemoveAll
Removes all the pointers from this array but does not actually delete the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the array is already empty, the function still works.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function frees all memory used for pointer storage.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void RemoveAll( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void RemoveAll( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void RemoveAll( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void RemoveAll( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void RemoveAll( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void RemoveAll( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#85](../vs140/codesnippet/CPP/cobarray--removeall_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)