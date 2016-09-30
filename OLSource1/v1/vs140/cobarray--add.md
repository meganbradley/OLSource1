---
title: "CObArray::Add"
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
  - "CObArray::Add"
  - "CObArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, growing the array"
  - "Add method [MFC]"
ms.assetid: e17b99be-c6c2-4eb5-b7b7-f7c73cd014c4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::Add
Adds a new element to the end of an array, growing the array by 1.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer to be added to this array.  
  
## Return Value  
 The index of the added element.  
  
## Remarks  
 If [SetSize](../vs140/cobarray--setsize.md) has been used with an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value greater than 1, then extra memory may be allocated. However, the upper bound will increase by only 1.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR Add( BYTE**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR Add( DWORD**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR Add( void\***  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR Add( LPCTSTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **); throw( CMemoryException\* );**\<br />\<br /> **INT_PTR Add(const CString&**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR Add( UINT**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR Add( WORD**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#75](../vs140/codesnippet/CPP/cobarray--add_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md)   
 [CObArray::InsertAt](../vs140/cobarray--insertat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)