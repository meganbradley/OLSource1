---
title: "CList Class"
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
  - "CList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lists"
  - "lists, base class for"
  - "CList class"
ms.assetid: 6f6273c3-c8f6-47f5-ac2a-0a950379ae5d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList Class
Supports ordered lists of nonunique objects accessible sequentially or by value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CList::CList](#clist__clist)|Constructs an empty ordered list.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CList::AddHead](#clist__addhead)|Adds an element (or all the elements in another list) to the head of the list (makes a new head).|  
|[CList::AddTail](#clist__addtail)|Adds an element (or all the elements in another list) to the tail of the list (makes a new tail).|  
|[CList::Find](#clist__find)|Gets the position of an element specified by pointer value.|  
|[CList::FindIndex](#clist__findindex)|Gets the position of an element specified by a zero-based index.|  
|[CList::GetAt](#clist__getat)|Gets the element at a given position.|  
|[CList::GetCount](#clist__getcount)|Returns the number of elements in this list.|  
|[CList::GetHead](#clist__gethead)|Returns the head element of the list (cannot be empty).|  
|[CList::GetHeadPosition](#clist__getheadposition)|Returns the position of the head element of the list.|  
|[CList::GetNext](#clist__getnext)|Gets the next element for iterating.|  
|[CList::GetPrev](#clist__getprev)|Gets the previous element for iterating.|  
|[CList::GetSize](#clist__getsize)|Returns the number of elements in this list.|  
|[CList::GetTail](#clist__gettail)|Returns the tail element of the list (cannot be empty).|  
|[CList::GetTailPosition](#clist__gettailposition)|Returns the position of the tail element of the list.|  
|[CList::InsertAfter](#clist__insertafter)|Inserts a new element after a given position.|  
|[CList::InsertBefore](#clist__insertbefore)|Inserts a new element before a given position.|  
|[CList::IsEmpty](#clist__isempty)|Tests for the empty list condition (no elements).|  
|[CList::RemoveAll](#clist__removeall)|Removes all the elements from this list.|  
|[CList::RemoveAt](#clist__removeat)|Removes an element from this list, specified by position.|  
|[CList::RemoveHead](#clist__removehead)|Removes the element from the head of the list.|  
|[CList::RemoveTail](#clist__removetail)|Removes the element from the tail of the list.|  
|[CList::SetAt](#clist__setat)|Sets the element at a given position.|  
  
#### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Type of object stored in the list.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> *_* <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Type used to reference objects stored in the list. Can be a reference.  
  
## Remarks  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> lists behave like doubly-linked lists.  
  
 A variable of type **POSITION** is a key for the list. You can use a **POSITION** variable as an iterator to traverse a list sequentially and as a bookmark to hold a place. A position is not the same as an index, however.  
  
 Element insertion is very fast at the list head, at the tail, and at a known **POSITION**. A sequential search is necessary to look up an element by value or index. This search can be slow if the list is long.  
  
 If you need a dump of individual elements in the list, you must set the depth of the dump context to 1 or greater.  
  
 Certain member functions of this class call global helper functions that must be customized for most uses of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class. See [Collection Class Helpers](../vs140/collection-class-helpers.md) in the "Macros and Globals" section.  
  
 For more information on using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Example  
 [!code[NVC_MFCCollections#35](../vs140/codesnippet/CPP/clist-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxtempl.h  
  
##  \<a name="clist__addhead">\</a>  CList::AddHead  
 Adds a new element or list of elements to the head of this list.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The new element.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
### Remarks  
 The list can be empty before the operation.  
  
### Example  
 [!code[NVC_MFCCollections#36](../vs140/codesnippet/CPP/clist-class_2.cpp)]  
  
##  \<a name="clist__addtail">\</a>  CList::AddTail  
 Adds a new element or list of elements to the tail of this list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The element to be added to this list.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
### Remarks  
 The list can be empty before the operation.  
  
### Example  
 [!code[NVC_MFCCollections#37](../vs140/codesnippet/CPP/clist-class_3.cpp)]  
  
##  \<a name="clist__clist">\</a>  CList::CList  
 Constructs an empty ordered list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The memory-allocation granularity for extending the list.  
  
### Remarks  
 As the list grows, memory is allocated in units of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> entries.  
  
### Example  
 [!code[NVC_MFCCollections#38](../vs140/codesnippet/CPP/clist-class_4.cpp)]  
  
##  \<a name="clist__find">\</a>  CList::Find  
 Searches the list sequentially to find the first element matching the specified <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The value to be found in the list.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The start position for the search. If no value is specified, the search begins with the head element.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the object is not found.  
  
### Example  
 [!code[NVC_MFCCollections#39](../vs140/codesnippet/CPP/clist-class_5.cpp)]  
  
##  \<a name="clist__findindex">\</a>  CList::FindIndex  
 Uses the value of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> as an index into the list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The zero-based index of the list element to be found.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is negative or too large.  
  
### Remarks  
 It starts a sequential scan from the head of the list, stopping on the                         *n*th element.  
  
### Example  
 [!code[NVC_MFCCollections#40](../vs140/codesnippet/CPP/clist-class_6.cpp)]  
  
##  \<a name="clist__getat">\</a>  CList::GetAt  
 Gets the list element at a given position.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of object in the list.  
  
 *position*  
 The position in the list of the element to get.  
  
### Return Value  
 See the return value description for <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns the element (or a reference to the element) associated with a given position. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. A variable of type **POSITION** is a key for the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
### Example  
  See the example for [CList::GetHeadPosition](#clist__getheadposition).  
  
##  \<a name="clist__getcount">\</a>  CList::GetCount  
 Gets the number of elements in this list.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An integer value containing the element count.  
  
### Remarks  
 Calling this method will generate the same result as the [CList::GetSize](#clist__getsize) method.  
  
### Example  
  See the example for [CList::RemoveHead](#clist__removehead).  
  
##  \<a name="clist__gethead">\</a>  CList::GetHead  
 Gets the head element (or a reference to the head element) of this list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of object in the list.  
  
### Return Value  
 If the list is **const**, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> returns a reference to the element at the head of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#clist__isempty) to verify that the list contains elements.  
  
### Example  
 [!code[NVC_MFCCollections#41](../vs140/codesnippet/CPP/clist-class_7.cpp)]  
  
##  \<a name="clist__getheadposition">\</a>  CList::GetHeadPosition  
 Gets the position of the head element of this list.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
### Example  
 [!code[NVC_MFCCollections#42](../vs140/codesnippet/CPP/clist-class_8.cpp)]  
  
##  \<a name="clist__getnext">\</a>  CList::GetNext  
 Gets the list element identified by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to the **POSITION** value of the next entry in the list.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of the elements in the list.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, [GetHeadPosition](#clist__getheadposition), or other member function call.  
  
### Return Value  
 If the list is **const**, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> returns a copy of an element of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> returns a reference to an element of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You can use <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or **Find**.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Example  
 [!code[NVC_MFCCollections#43](../vs140/codesnippet/CPP/clist-class_9.cpp)]  
  
##  \<a name="clist__getprev">\</a>  CList::GetPrev  
 Gets the list element identified by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to the **POSITION** value of the previous entry in the list.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of the elements in the list.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or other member function call.  
  
### Return Value  
 If the list is **const**, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> returns a reference to an element of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You can use <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> in a reverse iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or **Find**.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the first in the list, then the new value of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Example  
 [!code[NVC_MFCCollections#44](../vs140/codesnippet/CPP/clist-class_10.cpp)]  
  
##  \<a name="clist__getsize">\</a>  CList::GetSize  
 Returns the number of list elements.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the list.  
  
### Remarks  
 Call this method to retrieve the number of elements in the list.  Calling this method will generate the same result as the [CList::GetCount](#clist__getcount) method.  
  
### Example  
 [!code[NVC_MFCCollections#45](../vs140/codesnippet/CPP/clist-class_11.cpp)]  
  
##  \<a name="clist__gettail">\</a>  CList::GetTail  
 Gets the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> pointer that represents the tail element of this list.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
### Return Value  
 See the return value description for [GetHead](../vs140/coblist-class.md#coblist__gethead).  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist-class.md#coblist__isempty) to verify that the list contains elements.  
  
### Example  
 [!code[NVC_MFCCollections#46](../vs140/codesnippet/CPP/clist-class_12.cpp)]  
  
##  \<a name="clist__gettailposition">\</a>  CList::GetTailPosition  
 Gets the position of the tail element of this list; **NULL** if the list is empty.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
### Example  
 [!code[NVC_MFCCollections#47](../vs140/codesnippet/CPP/clist-class_13.cpp)]  
  
##  \<a name="clist__insertafter">\</a>  CList::InsertAfter  
 Adds an element to this list after the element at the specified position.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The element to be added to this list.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or list element retrieval.  
  
### Example  
 [!code[NVC_MFCCollections#48](../vs140/codesnippet/CPP/clist-class_14.cpp)]  
  
##  \<a name="clist__insertbefore">\</a>  CList::InsertBefore  
 Adds an element to this list before the element at the specified position.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The element to be added to this list.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or list element retrieval.  
  
### Remarks  
 If                         *position* is **NULL**, the element is inserted at the head of the list.  
  
### Example  
 [!code[NVC_MFCCollections#49](../vs140/codesnippet/CPP/clist-class_15.cpp)]  
  
##  \<a name="clist__isempty">\</a>  CList::IsEmpty  
 Indicates whether this list contains no elements.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if this list is empty; otherwise 0.  
  
### Example  
 [!code[NVC_MFCCollections#50](../vs140/codesnippet/CPP/clist-class_16.cpp)]  
  
##  \<a name="clist__removeall">\</a>  CList::RemoveAll  
 Removes all the elements from this list and frees the associated memory.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 No error is generated if the list is already empty.  
  
### Example  
 [!code[NVC_MFCCollections#51](../vs140/codesnippet/CPP/clist-class_17.cpp)]  
  
##  \<a name="clist__removeat">\</a>  CList::RemoveAt  
 Removes the specified element from this list.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 The position of the element to be removed from the list.  
  
### Remarks  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
### Example  
 [!code[NVC_MFCCollections#52](../vs140/codesnippet/CPP/clist-class_18.cpp)]  
  
##  \<a name="clist__removehead">\</a>  CList::RemoveHead  
 Removes the element from the head of the list and returns a pointer to it.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
### Return Value  
 The element previously at the head of the list.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#clist__isempty) to verify that the list contains elements.  
  
### Example  
 [!code[NVC_MFCCollections#53](../vs140/codesnippet/CPP/clist-class_19.cpp)]  
  
##  \<a name="clist__removetail">\</a>  CList::RemoveTail  
 Removes the element from the tail of the list and returns a pointer to it.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
### Return Value  
 The element that was at the tail of the list.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#clist__isempty) to verify that the list contains elements.  
  
### Example  
 [!code[NVC_MFCCollections#54](../vs140/codesnippet/CPP/clist-class_20.cpp)]  
  
##  \<a name="clist__setat">\</a>  CList::SetAt  
 A variable of type **POSITION** is a key for the list.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The **POSITION** of the element to be set.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The element to be added to the list.  
  
### Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> writes the element to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
### Example  
 [!code[NVC_MFCCollections#55](../vs140/codesnippet/CPP/clist-class_21.cpp)]  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap](../vs140/cmap-class.md)   
 [CArray](../vs140/carray-class.md)