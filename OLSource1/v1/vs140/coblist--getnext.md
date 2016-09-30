---
title: "CObList::GetNext"
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
  - "CObList::GetNext"
  - "CObList.GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, iteration"
  - "GetNext method"
ms.assetid: 0e556a22-cb5e-4f01-964f-eb44c9786ae6
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetNext
Gets the list element identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value of the next entry in the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value returned by a previous <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or other member function call.  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 You can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 You must ensure that your <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 It is possible to remove an element during an iteration. See the example for [RemoveAt](../vs140/coblist--removeat.md).  
  
> [!NOTE]
>  As of MFC 8.0 the const version of this method has changed to return <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  This change was made to bring the compiler into conformance with the C++ standard.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|[CStringList](../vs140/cstringlist-class.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#98](../vs140/codesnippet/CPP/coblist--getnext_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)