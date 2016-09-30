---
title: "CStringList Class"
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
  - "CStringList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], lists"
  - "lists, string"
  - "CStringList class"
  - "strings [C++], collections"
ms.assetid: 310a7edb-263c-4bd2-ac43-0bfbfddc5a33
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringList Class
Supports lists of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 The member functions of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are similar to the member functions of class [CObList](../vs140/coblist-class.md). Because of this similarity, you can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> reference documentation for member function specifics. Wherever you see a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer as a return value, substitute a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (not a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer). Wherever you see a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer as a function parameter, substitute an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 for example, translates to  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 and  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 translates to  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::CObList](../vs140/coblist-class.md#coblist__coblist)|Constructs an empty list.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::AddHead](../vs140/coblist-class.md#coblist__addhead)|Adds an element (or all the elements in another list) to the head of the list (makes a new head).|  
|[CObList::AddTail](../vs140/coblist-class.md#coblist__addtail)|Adds an element (or all the elements in another list) to the tail of the list (makes a new tail).|  
|[CObList::Find](../vs140/coblist-class.md#coblist__find)|Gets the position of an element specified by pointer value.|  
|[CObList::FindIndex](../vs140/coblist-class.md#coblist__findindex)|Gets the position of an element specified by a zero-based index.|  
|[CObList::GetAt](../vs140/coblist-class.md#coblist__getat)|Gets the element at a given position.|  
|[CObList::GetCount](../vs140/coblist-class.md#coblist__getcount)|Returns the number of elements in this list.|  
|[CObList::GetHead](../vs140/coblist-class.md#coblist__gethead)|Returns the head element of the list (cannot be empty).|  
|[CObList::GetHeadPosition](../vs140/coblist-class.md#coblist__getheadposition)|Returns the position of the head element of the list.|  
|[CObList::GetNext](../vs140/coblist-class.md#coblist__getnext)|Gets the next element for iterating.|  
|[CObList::GetPrev](../vs140/coblist-class.md#coblist__getprev)|Gets the previous element for iterating.|  
|[CObList::GetSize](../vs140/coblist-class.md#coblist__getsize)|Returns the number of elements in this list.|  
|[CObList::GetTail](../vs140/coblist-class.md#coblist__gettail)|Returns the tail element of the list (cannot be empty).|  
|[CObList::GetTailPosition](../vs140/coblist-class.md#coblist__gettailposition)|Returns the position of the tail element of the list.|  
|[CObList::InsertAfter](../vs140/coblist-class.md#coblist__insertafter)|Inserts a new element after a given position.|  
|[CObList::InsertBefore](../vs140/coblist-class.md#coblist__insertbefore)|Inserts a new element before a given position.|  
|[CObList::IsEmpty](../vs140/coblist-class.md#coblist__isempty)|Tests for the empty list condition (no elements).|  
|[CObList::RemoveAll](../vs140/coblist-class.md#coblist__removeall)|Removes all the elements from this list.|  
|[CObList::RemoveAt](../vs140/coblist-class.md#coblist__removeat)|Removes an element from this list, specified by position.|  
|[CObList::RemoveHead](../vs140/coblist-class.md#coblist__removehead)|Removes the element from the head of the list.|  
|[CObList::RemoveTail](../vs140/coblist-class.md#coblist__removetail)|Removes the element from the tail of the list.|  
|[CObList::SetAt](../vs140/coblist-class.md#coblist__setat)|Sets the element at a given position.|  
  
## Remarks  
 All comparisons are done by value, meaning that the characters in the string are compared instead of the addresses of the strings.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> macro to support serialization and dumping of its elements. If a list of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects is stored to an archive, either with an overloaded insertion operator or with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function, each <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element is serialized in turn.  
  
 If you need a dump of individual <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements, you must set the depth of the dump context to 1 or greater.  
  
 For more information on using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)