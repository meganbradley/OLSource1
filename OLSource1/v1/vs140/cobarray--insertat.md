---
title: "CObArray::InsertAt"
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
  - "CObArray.InsertAt"
  - "CObArray::InsertAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAt method"
  - "CObArray class, insertion/removal"
ms.assetid: dab9c3d4-baaf-44e7-b406-1c9eb7799a1b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::InsertAt
Inserts an element (or all the elements in another array) at a specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer to be placed in this array. A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of value **NULL** is allowed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
## Remarks  
 The first version of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> inserts one element (or multiple copies of an element) at a specified index in an array. In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> collection, starting at the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> position.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function, in contrast, replaces one specified array element and does not shift any elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **, CByteArray\***  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> **, CDWordArray\***  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> **, CPtrArray\***  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> **, CStringArray\***  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> **, CUIntArray\***  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> **, CWordArray\***  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#84](../vs140/codesnippet/CPP/cobarray--insertat_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::RemoveAt](../vs140/cobarray--removeat.md)