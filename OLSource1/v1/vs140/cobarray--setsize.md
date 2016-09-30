---
title: "CObArray::SetSize"
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
  - "CObArray.SetSize"
  - "CObArray::SetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSize method"
  - "CObArray class, bounds"
ms.assetid: 4091cbd3-0a78-46a3-a1c1-83cc3b2c9ed6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::SetSize
Establishes the size of an empty or existing array; allocates memory if necessary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new array size (number of elements). Must be greater than or equal to 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
## Remarks  
 If the new size is smaller than the old size, then the array is truncated and all unused memory is released. For efficiency, call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to set the size of the array before using it. This prevents the need to reallocate and copy the array each time an item is added.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter affects internal memory allocation while the array is growing. Its use never affects the array size as reported by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 If the size of the array has grown, all newly allocated **CObject \*** pointers are set to NULL.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
  
## Example  
 See the example for [CObArray::GetData](../vs140/cobarray--getdata.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)