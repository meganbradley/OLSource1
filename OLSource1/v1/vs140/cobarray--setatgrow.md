---
title: "CObArray::SetAtGrow"
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
  - "CObArray.SetAtGrow"
  - "CObArray::SetAtGrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAtGrow method"
  - "CObArray class, growing the array"
ms.assetid: df6881c7-fc98-44e6-9301-4379def32c70
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::SetAtGrow
Sets the array element at the specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object pointer to be added to this array. A **NULL** value is allowed.  
  
## Remarks  
 The array grows automatically if necessary (that is, the upper bound is adjusted to accommodate the new element).  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#87](../vs140/codesnippet/CPP/cobarray--setatgrow_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetAt](../vs140/cobarray--getat.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::ElementAt](../vs140/cobarray--elementat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)