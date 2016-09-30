---
title: "CAtlList Class"
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
  - "ATL.CAtlList"
  - "CAtlList"
  - "ATL::CAtlList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlList class"
ms.assetid: 09e98053-64b2-4efa-99ab-d0542caaf981
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList Class
This class provides methods for creating and managing a list object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The code used to copy or move elements. See [CElementTraits Class](../vs140/celementtraits-class.md) for more details.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlList::INARGTYPE](../vs140/catllist--inargtype.md)||  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlList::CAtlList](../vs140/catllist--catllist.md)|The constructor.|  
|[CAtlList::~CAtlList](../vs140/catllist--~catllist.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlList::AddHead](../vs140/catllist--addhead.md)|Call this method to add an element to the head of the list.|  
|[CAtlList::AddHeadList](../vs140/catllist--addheadlist.md)|Call this method to add an existing list to the head of the list.|  
|[CAtlList::AddTail](../vs140/catllist--addtail.md)|Call this method to add an element to the tail of this list.|  
|[CAtlList::AddTailList](../vs140/catllist--addtaillist.md)|Call this method to add an existing list to the tail of this list.|  
|[CAtlList::AssertValid](../vs140/catllist--assertvalid.md)|Call this method to confirm the list is valid.|  
|[CAtlList::Find](../vs140/catllist--find.md)|Call this method to search the list for the specified element.|  
|[CAtlList::FindIndex](../vs140/catllist--findindex.md)|Call this method to obtain the position of an element, given an index value.|  
|[CAtlList::GetAt](../vs140/catllist--getat.md)|Call this method to return the element at a specified position in the list.|  
|[CAtlList::GetCount](../vs140/catllist--getcount.md)|Call this method to return the number of objects in the list.|  
|[CAtlList::GetHead](../vs140/catllist--gethead.md)|Call this method to return the element at the head of the list.|  
|[CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md)|Call this method to obtain the position of the head of the list.|  
|[CAtlList::GetNext](../vs140/catllist--getnext.md)|Call this method to return the next element from the list.|  
|[CAtlList::GetPrev](../vs140/catllist--getprev.md)|Call this method to return the previous element from the list.|  
|[CAtlList::GetTail](../vs140/catllist--gettail.md)|Call this method to return the element at the tail of the list.|  
|[CAtlList::GetTailPosition](../vs140/catllist--gettailposition.md)|Call this method to obtain the position of the tail of the list.|  
|[CAtlList::InsertAfter](../vs140/catllist--insertafter.md)|Call this method to insert a new element into the list after the specified position.|  
|[CAtlList::InsertBefore](../vs140/catllist--insertbefore.md)|Call this method to insert a new element into the list before the specified position.|  
|[CAtlList::IsEmpty](../vs140/catllist--isempty.md)|Call this method to determine if the list is empty.|  
|[CAtlList::MoveToHead](../vs140/catllist--movetohead.md)|Call this method to move the specified element to the head of the list.|  
|[CAtlList::MoveToTail](../vs140/catllist--movetotail.md)|Call this method to move the specified element to the tail of the list.|  
|[CAtlList::RemoveAll](../vs140/catllist--removeall.md)|Call this method to remove all of the elements from the list.|  
|[CAtlList::RemoveAt](../vs140/catllist--removeat.md)|Call this method to remove a single element from the list.|  
|[CAtlList::RemoveHead](../vs140/catllist--removehead.md)|Call this method to remove the element at the head of the list.|  
|[CAtlList::RemoveHeadNoReturn](../vs140/catllist--removeheadnoreturn.md)|Call this method to remove the element at the head of the list without returning a value.|  
|[CAtlList::RemoveTail](../vs140/catllist--removetail.md)|Call this method to remove the element at the tail of the list.|  
|[CAtlList::RemoveTailNoReturn](../vs140/catllist--removetailnoreturn.md)|Call this method to remove the element at the tail of the list without returning a value.|  
|[CAtlList::SetAt](../vs140/catllist--setat.md)|Call this method to set the value of the element at a given position in the list.|  
|[CAtlList::SwapElements](../vs140/catllist--swapelements.md)|Call this method to swap elements in the list.|  
  
## Remarks  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class supports ordered lists of nonunique objects accessible sequentially or by value. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> lists behave like doubly linked lists. Each list has a head and a tail, and new elements (or lists in some cases) can be added to either end of the list, or inserted before or after specific elements.  
  
 Most of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> methods make use of a position value. This value is used by the methods to reference the actual memory location where the elements are stored, and should not be calculated or predicted directly. If it is necessary to access the *n*th element in the list, the method [CAtlList::FindIndex](../vs140/catllist--findindex.md) will return the corresponding position value for a given index. The methods [CAtlList::GetNext](../vs140/catllist--getnext.md) and [CAtlList::GetPrev](../vs140/catllist--getprev.md) can be used to iterate through the objects in the list.  
  
 For more information regarding the collection classes available with ATL, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="catllist__addhead">\</a>  CAtlList::AddHead  
 Call this method to add an element to the head of the list.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The new element.  
  
### Return Value  
 Returns the position of the newly added element.  
  
### Remarks  
 If the first version is used, an empty element is created using its default constructor, rather than its copy constructor.  
  
### Example  
 [!code[NVC_ATL_Utilities#13](../vs140/codesnippet/CPP/catllist-class_1.cpp)]  
  
##  \<a name="catllist__addheadlist">\</a>  CAtlList::AddHeadList  
 Call this method to add an existing list to the head of the list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The list to be added.  
  
### Remarks  
 The list pointed to by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is inserted at the start of the existing list. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#14](../vs140/codesnippet/CPP/catllist-class_2.cpp)]  
  
##  \<a name="catllist__addtail">\</a>  CAtlList::AddTail  
 Call this method to add an element to the tail of this list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The element to add.  
  
### Return Value  
 Returns the POSITION of the newly added element.  
  
### Remarks  
 If the first version is used, an empty element is created using its default constructor, rather than its copy constructor. The element is added to the end of the list, and so it now becomes the tail. This method can be used with an empty list.  
  
### Example  
 [!code[NVC_ATL_Utilities#15](../vs140/codesnippet/CPP/catllist-class_3.cpp)]  
  
##  \<a name="catllist__addtaillist">\</a>  CAtlList::AddTailList  
 Call this method to add an existing list to the tail of this list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The list to be added.  
  
### Remarks  
 The list pointed to by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is inserted after the last element (if any) in the list object. The last element in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> list therefore becomes the tail. In debug builds, an assertion failure will occur if *plNew* is equal to NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#16](../vs140/codesnippet/CPP/catllist-class_4.cpp)]  
  
##  \<a name="catllist__assertvalid">\</a>  CAtlList::AssertValid  
 Call this method to confirm the list is valid.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 In debug builds, an assertion failure will occur if the list object is not valid. To be valid, an empty list must have both the head and tail pointing to NULL, and a list that is not empty must have both the head and tail pointing to valid addresses.  
  
### Example  
 [!code[NVC_ATL_Utilities#17](../vs140/codesnippet/CPP/catllist-class_5.cpp)]  
  
##  \<a name="catllist__catllist">\</a>  CAtlList::CAtlList  
 The constructor.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The block size.  
  
### Remarks  
 The constructor for the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object. The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
### Example  
 [!code[NVC_ATL_Utilities#18](../vs140/codesnippet/CPP/catllist-class_6.cpp)]  
  
##  \<a name="catllist___dtorcatllist">\</a>  CAtlList::~CAtlList  
 The destructor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources, including a call to [CAtlList::RemoveAll](../vs140/catllist--removeall.md) to remove all elements from the list.  
  
 In debug builds, an assertion failure will occur if the list still contains some elements after the call to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
##  \<a name="catllist__find">\</a>  CAtlList::Find  
 Call this method to search the list for the specified element.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The element to be found in the list.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The start position for the search. If no value is specified, the search begins with the head element.  
  
### Return Value  
 Returns the POSITION value of the element if found, otherwise returns NULL.  
  
### Remarks  
 In debug builds, an assertion failure will occur if the list object is not valid, or if the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value is out of range.  
  
### Example  
 [!code[NVC_ATL_Utilities#19](../vs140/codesnippet/CPP/catllist-class_7.cpp)]  
  
##  \<a name="catllist__findindex">\</a>  CAtlList::FindIndex  
 Call this method to obtain the position of an element, given an index value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The zero-based index of the required list element.  
  
### Return Value  
 Returns the corresponding POSITION value, or NULL if <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is out of range.  
  
### Remarks  
 This method returns the POSITION corresponding to a given index value, allowing access to the *n*th element in the list.  
  
 In debug builds, an assertion failure will occur if the list object is not valid.  
  
### Example  
 [!code[NVC_ATL_Utilities#20](../vs140/codesnippet/CPP/catllist-class_8.cpp)]  
  
##  \<a name="catllist__getat">\</a>  CAtlList::GetAt  
 Call this method to return the element at a specified position in the list.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The POSITION value specifying a particular element.  
  
### Return Value  
 A reference to, or copy of, the element.  
  
### Remarks  
 If the list is **const**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> returns a copy of the element. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> returns a reference to the element. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
 In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 See the example for [CAtlList::FindIndex](../vs140/catllist--findindex.md).  
  
##  \<a name="catllist__getcount">\</a>  CAtlList::GetCount  
 Call this method to return the number of objects in the list.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements in the list.  
  
### Example  
 See the example for [CAtlList::Find](../vs140/catllist--find.md).  
  
##  \<a name="catllist__gethead">\</a>  CAtlList::GetHead  
 Call this method to return the element at the head of the list.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns a reference to, or a copy of, the element at the head of the list.  
  
### Remarks  
 If the list is **const**, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> returns a reference to the element at the head of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
 In debug builds, an assertion failure will occur if the head of the list points to NULL.  
  
### Example  
 See the example for [CAtlList::AddHead](../vs140/catllist--addhead.md).  
  
##  \<a name="catllist__getheadposition">\</a>  CAtlList::GetHeadPosition  
 Call this method to obtain the position of the head of the list.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Returns the POSITION value corresponding to the element at the head of the list.  
  
### Remarks  
 If the list is empty, the value returned is NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#21](../vs140/codesnippet/CPP/catllist-class_9.cpp)]  
  
##  \<a name="catllist__getnext">\</a>  CAtlList::GetNext  
 Call this method to return the next element from the list.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A POSITION value, returned by a previous call to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md), or other <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method.  
  
### Return Value  
 If the list is **const**, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns a copy of the next element of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> returns a reference to the next element of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 The POSITION counter, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, is updated to point to the next element in the list, or NULL if there are no more elements. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 See the example for [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md).  
  
##  \<a name="catllist__getprev">\</a>  CAtlList::GetPrev  
 Call this method to return the previous element from the list.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A POSITION value, returned by a previous call to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, [CAtlList::GetTailPosition](../vs140/catllist--gettailposition.md), or other <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> method.  
  
### Return Value  
 If the list is **const**, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> returns a copy of an element of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> returns a reference to an element of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 The POSITION counter, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, is updated to point to the previous element in the list, or NULL if there are no more elements. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 See the example for [CAtlList::GetTailPosition](../vs140/catllist--gettailposition.md).  
  
##  \<a name="catllist__gettail">\</a>  CAtlList::GetTail  
 Call this method to return the element at the tail of the list.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Returns a reference to, or a copy of, the element at the tail of the list.  
  
### Remarks  
 If the list is **const**, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> returns a reference to the element at the head of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
 In debug builds, an assertion failure will occur if the tail of the list points to NULL.  
  
### Example  
 See the example for [CAtlList::AddTail](../vs140/catllist--addtail.md).  
  
##  \<a name="catllist__gettailposition">\</a>  CAtlList::GetTailPosition  
 Call this method to obtain the position of the tail of the list.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns the POSITION value corresponding to the element at the tail of the list.  
  
### Remarks  
 If the list is empty, the value returned is NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#22](../vs140/codesnippet/CPP/catllist-class_10.cpp)]  
  
##  \<a name="catllist__inargtype">\</a>  CAtlList::INARGTYPE  
 Type used when an element is passed as an input argument.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="catllist__insertafter">\</a>  CAtlList::InsertAfter  
 Call this method to insert a new element into the list after the specified position.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The POSITION value after which the new element will be inserted.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The element to be inserted.  
  
### Return Value  
 Returns the POSITION value of the new element.  
  
### Remarks  
 In debug builds, an assertion failure will occur if the list isn't valid, if the insert fails, or if an attempt is made to insert the element after the tail.  
  
### Example  
 [!code[NVC_ATL_Utilities#23](../vs140/codesnippet/CPP/catllist-class_11.cpp)]  
  
##  \<a name="catllist__insertbefore">\</a>  CAtlList::InsertBefore  
 Call this method to insert a new element into the list before the specified position.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The new element will be inserted into the list before this POSITION value.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The element to be inserted.  
  
### Return Value  
 Returns the POSITION value of the new element.  
  
### Remarks  
 In debug builds, an assertion failure will occur if the list isn't valid, if the insert fails, or if an attempt is made to insert the element before the head.  
  
### Example  
 [!code[NVC_ATL_Utilities#24](../vs140/codesnippet/CPP/catllist-class_12.cpp)]  
  
##  \<a name="catllist__isempty">\</a>  CAtlList::IsEmpty  
 Call this method to determine if the list is empty.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the list contains no objects, otherwise false.  
  
### Example  
 [!code[NVC_ATL_Utilities#25](../vs140/codesnippet/CPP/catllist-class_13.cpp)]  
  
##  \<a name="catllist__movetohead">\</a>  CAtlList::MoveToHead  
 Call this method to move the specified element to the head of the list.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The POSITION value of the element to move.  
  
### Remarks  
 The specified element is moved from its current position to the head of the list. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#26](../vs140/codesnippet/CPP/catllist-class_14.cpp)]  
  
##  \<a name="catllist__movetotail">\</a>  CAtlList::MoveToTail  
 Call this method to move the specified element to the tail of the list.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The POSITION value of the element to move.  
  
### Remarks  
 The specified element is moved from its current position to the tail of the list. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 See the example for [CAtlList::MoveToHead](../vs140/catllist--movetohead.md).  
  
##  \<a name="catllist__removeall">\</a>  CAtlList::RemoveAll  
 Call this method to remove all of the elements from the list.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 This method removes all of the elements from the list and frees the allocated memory. In debugs builds, an ATLASSERT will be raised if all elements aren't deleted or if the list structure has become corrupted.  
  
### Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
##  \<a name="catllist__removeat">\</a>  CAtlList::RemoveAt  
 Call this method to remove a single element from the list.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The POSITION value of the element to remove.  
  
### Remarks  
 The element referenced by <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is removed, and memory is freed. It is acceptable to use <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to remove the head or tail of the list.  
  
 In debug builds, an assertion failure will occur if the list is not valid or if removing the element causes the list to access memory which isn't part of the list structure.  
  
### Example  
 [!code[NVC_ATL_Utilities#27](../vs140/codesnippet/CPP/catllist-class_15.cpp)]  
  
##  \<a name="catllist__removehead">\</a>  CAtlList::RemoveHead  
 Call this method to remove the element at the head of the list.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns the element at the head of the list.  
  
### Remarks  
 The head element is deleted from the list, and memory is freed. A copy of the element is returned. In debug builds, an assertion failure will occur if the list is empty.  
  
### Example  
 [!code[NVC_ATL_Utilities#28](../vs140/codesnippet/CPP/catllist-class_16.cpp)]  
  
##  \<a name="catllist__removeheadnoreturn">\</a>  CAtlList::RemoveHeadNoReturn  
 Call this method to remove the element at the head of the list without returning a value.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The head element is deleted from the list, and memory is freed. In debug builds, an assertion failure will occur if the list is empty.  
  
### Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
##  \<a name="catllist__removetail">\</a>  CAtlList::RemoveTail  
 Call this method to remove the element at the tail of the list.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Returns the element at the tail of the list.  
  
### Remarks  
 The tail element is deleted from the list, and memory is freed. A copy of the element is returned. In debug builds, an assertion failure will occur if the list is empty.  
  
### Example  
 [!code[NVC_ATL_Utilities#29](../vs140/codesnippet/CPP/catllist-class_17.cpp)]  
  
##  \<a name="catllist__removetailnoreturn">\</a>  CAtlList::RemoveTailNoReturn  
 Call this method to remove the element at the tail of the list without returning a value.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The tail element is deleted from the list, and memory is freed. In debug builds, an assertion failure will occur if the list is empty.  
  
### Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
##  \<a name="catllist__setat">\</a>  CAtlList::SetAt  
 Call this method to set the value of the element at a given position in the list.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The POSITION value corresponding to the element to change.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The new element value.  
  
### Remarks  
 Replaces the existing value with <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is equal to NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#30](../vs140/codesnippet/CPP/catllist-class_18.cpp)]  
  
##  \<a name="catllist__swapelements">\</a>  CAtlList::SwapElements  
 Call this method to swap elements in the list.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *pos1*  
 The first POSITION value.  
  
 *pos2*  
 The second POSITION value.  
  
### Remarks  
 Swaps the elements at the two positions specified. In debug builds, an assertion failure will occur if either position value is equal to NULL.  
  
### Example  
 [!code[NVC_ATL_Utilities#31](../vs140/codesnippet/CPP/catllist-class_19.cpp)]  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)