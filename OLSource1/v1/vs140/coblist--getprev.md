---
title: "CObList::GetPrev"
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
  - "CObList::GetPrev"
  - "CObList.GetPrev"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, iteration"
  - "GetPrev method"
ms.assetid: 674a4712-d3b4-4bae-8fc4-9e6ec4c47981
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetPrev
Gets the list element identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value of the previous entry in the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value returned by a previous <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or other member function call.  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 You can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in a reverse iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 You must ensure that your <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the first in the list, then the new value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  As of MFC 8.0 the const version of this method has changed to return <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  This change was made to bring the compiler into conformance with the C++ standard.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|[CStringList](../vs140/cstringlist-class.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#99](../vs140/codesnippet/CPP/coblist--getprev_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CObList::GetNext](../vs140/coblist--getnext.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)