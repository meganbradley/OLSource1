---
title: "CObArray::RemoveAt"
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
  - "CObArray::RemoveAt"
  - "CObArray.RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, insertion/removal"
  - "RemoveAt method"
ms.assetid: 77597227-03e5-462b-b828-e2a9278f5345
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::RemoveAt
Removes one or more elements starting at a specified index in an array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of elements to remove.  
  
## Remarks  
 In the process, it shifts down all the elements above the removed element(s). It decrements the upper bound of the array but does not free memory.  
  
 If you try to remove more elements than are contained in the array above the removal point, then the Debug version of the library asserts.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function removes the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer from the array, but it does not delete the object itself.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **= 1 );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **= 1 );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  **= 1 );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  **= 1 );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  **= 1 );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void RemoveAt( INT_PTR** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **, INT_PTR**  *nCount*  **= 1 );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#112](../vs140/codesnippet/CPP/cobarray--removeat_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md)   
 [CObArray::InsertAt](../vs140/cobarray--insertat.md)