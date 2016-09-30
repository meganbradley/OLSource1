---
title: "CObList::AddTail"
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
  - "CObList::AddTail"
  - "CObList.AddTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, operations"
  - "AddTail method"
ms.assetid: 2653bf9e-0957-4870-bc4d-2279237acba1
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::AddTail
Adds a new element or list of elements to the tail of this list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer to be added to this list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The list can be empty before the operation.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION AddTail( void\***  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddTail( CPtrList\***  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION AddTail( const CString&**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION AddTail( LPCTSTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddTail( CStringList\***  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#90](../vs140/codesnippet/CPP/coblist--addtail_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::RemoveTail](../vs140/coblist--removetail.md)