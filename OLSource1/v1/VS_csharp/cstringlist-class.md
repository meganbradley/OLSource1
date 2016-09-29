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
Supports lists of `CString` objects.  
  
## Syntax  
  
```  
class CStringList : public CObject  
```  
  
## Members  
 The member functions of `CStringList` are similar to the member functions of class [CObList](../VS_csharp/coblist-class.md). Because of this similarity, you can use the `CObList` reference documentation for member function specifics. Wherever you see a `CObject` pointer as a return value, substitute a `CString` (not a `CString` pointer). Wherever you see a `CObject` pointer as a function parameter, substitute an `LPCTSTR`.  
  
 `CObject*& CObList::GetHead() const;`  
  
 for example, translates to  
  
 `CString& CStringList::GetHead() const;`  
  
 and  
  
 `POSITION AddHead( CObject* <newElement> );`  
  
 translates to  
  
 `POSITION AddHead( LPCTSTR <newElement> );`  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::CObList](../VS_csharp/coblist-class.md#coblist__coblist)|Constructs an empty list.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::AddHead](../VS_csharp/coblist-class.md#coblist__addhead)|Adds an element (or all the elements in another list) to the head of the list (makes a new head).|  
|[CObList::AddTail](../VS_csharp/coblist-class.md#coblist__addtail)|Adds an element (or all the elements in another list) to the tail of the list (makes a new tail).|  
|[CObList::Find](../VS_csharp/coblist-class.md#coblist__find)|Gets the position of an element specified by pointer value.|  
|[CObList::FindIndex](../VS_csharp/coblist-class.md#coblist__findindex)|Gets the position of an element specified by a zero-based index.|  
|[CObList::GetAt](../VS_csharp/coblist-class.md#coblist__getat)|Gets the element at a given position.|  
|[CObList::GetCount](../VS_csharp/coblist-class.md#coblist__getcount)|Returns the number of elements in this list.|  
|[CObList::GetHead](../VS_csharp/coblist-class.md#coblist__gethead)|Returns the head element of the list (cannot be empty).|  
|[CObList::GetHeadPosition](../VS_csharp/coblist-class.md#coblist__getheadposition)|Returns the position of the head element of the list.|  
|[CObList::GetNext](../VS_csharp/coblist-class.md#coblist__getnext)|Gets the next element for iterating.|  
|[CObList::GetPrev](../VS_csharp/coblist-class.md#coblist__getprev)|Gets the previous element for iterating.|  
|[CObList::GetSize](../VS_csharp/coblist-class.md#coblist__getsize)|Returns the number of elements in this list.|  
|[CObList::GetTail](../VS_csharp/coblist-class.md#coblist__gettail)|Returns the tail element of the list (cannot be empty).|  
|[CObList::GetTailPosition](../VS_csharp/coblist-class.md#coblist__gettailposition)|Returns the position of the tail element of the list.|  
|[CObList::InsertAfter](../VS_csharp/coblist-class.md#coblist__insertafter)|Inserts a new element after a given position.|  
|[CObList::InsertBefore](../VS_csharp/coblist-class.md#coblist__insertbefore)|Inserts a new element before a given position.|  
|[CObList::IsEmpty](../VS_csharp/coblist-class.md#coblist__isempty)|Tests for the empty list condition (no elements).|  
|[CObList::RemoveAll](../VS_csharp/coblist-class.md#coblist__removeall)|Removes all the elements from this list.|  
|[CObList::RemoveAt](../VS_csharp/coblist-class.md#coblist__removeat)|Removes an element from this list, specified by position.|  
|[CObList::RemoveHead](../VS_csharp/coblist-class.md#coblist__removehead)|Removes the element from the head of the list.|  
|[CObList::RemoveTail](../VS_csharp/coblist-class.md#coblist__removetail)|Removes the element from the tail of the list.|  
|[CObList::SetAt](../VS_csharp/coblist-class.md#coblist__setat)|Sets the element at a given position.|  
  
## Remarks  
 All comparisons are done by value, meaning that the characters in the string are compared instead of the addresses of the strings.  
  
 `CStringList` incorporates the `IMPLEMENT_SERIAL` macro to support serialization and dumping of its elements. If a list of `CString` objects is stored to an archive, either with an overloaded insertion operator or with the `Serialize` member function, each `CString` element is serialized in turn.  
  
 If you need a dump of individual `CString` elements, you must set the depth of the dump context to 1 or greater.  
  
 For more information on using `CStringList`, see the article [Collections](../VS_csharp/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 `CStringList`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [MFC Sample COLLECT](../VS_csharp/visual-c---samples.md)   
 [Base Class](../VS_csharp/cobject-class.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)