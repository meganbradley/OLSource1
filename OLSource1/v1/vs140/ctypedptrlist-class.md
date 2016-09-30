---
title: "CTypedPtrList Class"
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
  - "CTypedPtrList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTypedPtrList class"
  - "type-safe collections"
  - "lists [C++]"
  - "template classes, CTypedPtrList class"
  - "linked lists [C++]"
  - "pointer lists"
ms.assetid: c273096e-1756-4340-864b-4a08b674a65e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList Class
Provides a type-safe "wrapper" for objects of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Base class of the typed pointer list class; must be a pointer list class ( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Type of the elements stored in the base-class list.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTypedPtrList::AddHead](#ctypedptrlist__addhead)|Adds an element (or all the elements in another list) to the head of the list (makes a new head).|  
|[CTypedPtrList::AddTail](#ctypedptrlist__addtail)|Adds an element (or all the elements in another list) to the tail of the list (makes a new tail).|  
|[CTypedPtrList::GetAt](#ctypedptrlist__getat)|Gets the element at a given position.|  
|[CTypedPtrList::GetHead](#ctypedptrlist__gethead)|Returns the head element of the list (cannot be empty).|  
|[CTypedPtrList::GetNext](#ctypedptrlist__getnext)|Gets the next element for iterating.|  
|[CTypedPtrList::GetPrev](#ctypedptrlist__getprev)|Gets the previous element for iterating.|  
|[CTypedPtrList::GetTail](#ctypedptrlist__gettail)|Returns the tail element of the list (cannot be empty).|  
|[CTypedPtrList::RemoveHead](#ctypedptrlist__removehead)|Removes the element from the head of the list.|  
|[CTypedPtrList::RemoveTail](#ctypedptrlist__removetail)|Removes the element from the tail of the list.|  
|[CTypedPtrList::SetAt](#ctypedptrlist__setat)|Sets the element at a given position.|  
  
## Remarks  
 When you use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the C++ type-checking facility helps eliminate errors caused by mismatched pointer types.  
  
 In addition, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> wrapper performs much of the casting that would be required if you used <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Because all <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions are inline, use of this template does not significantly affect the size or speed of your code.  
  
 Lists derived from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be serialized, but those derived from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> cannot.  
  
 When a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, only the pointers are removed, not the entities they reference.  
  
 For more information on using <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, see the articles [Collections](../vs140/collections.md) and [Template-Based Classes](../vs140/template-based-classes.md).  
  
## Example  
 This example creates an instance of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, adds one object, serializes the list to disk, and then deletes the object:  
  
 [!code[NVC_MFCCollections#110](../vs140/codesnippet/CPP/ctypedptrlist-class_1.cpp)]  
  
 [!code[NVC_MFCCollections#111](../vs140/codesnippet/CPP/ctypedptrlist-class_2.cpp)]  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxtempl.h  
  
##  \<a name="ctypedptrlist__addhead">\</a>  CTypedPtrList::AddHead  
 This member function calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>**::AddHead**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The object pointer to be added to this list. A **NULL** value is allowed.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Base class of the typed pointer list class; must be a pointer list class ( [CObList](../vs140/coblist-class.md) or [CPtrList](../vs140/cptrlist-class.md)).  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to another [CTypedPtrList](../vs140/ctypedptrlist-class.md) object. The elements in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
### Remarks  
 The first version adds a new element before the head of the list. The second version adds another list of elements before the head.  
  
##  \<a name="ctypedptrlist__addtail">\</a>  CTypedPtrList::AddTail  
 This member function calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>**::AddTail**.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The object pointer to be added to this list. A **NULL** value is allowed.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Base class of the typed pointer list class; must be a pointer list class ( [CObList](../vs140/coblist-class.md) or [CPtrList](../vs140/cptrlist-class.md)).  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to another [CTypedPtrList](../vs140/ctypedptrlist-class.md) object. The elements in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
### Remarks  
 The first version adds a new element after the tail of the list. The second version adds another list of elements after the tail of the list.  
  
##  \<a name="ctypedptrlist__getat">\</a>  CTypedPtrList::GetAt  
 A variable of type **POSITION** is a key for the list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or **Find** member function call.  
  
### Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> retrieves the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> pointer associated with a given position.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 This inline function calls <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>**::GetAt**.  
  
##  \<a name="ctypedptrlist__gethead">\</a>  CTypedPtrList::GetHead  
 Gets the pointer that represents the head element of this list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
### Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist-class.md#coblist__isempty) to verify that the list contains elements.  
  
##  \<a name="ctypedptrlist__getnext">\</a>  CTypedPtrList::GetNext  
 Gets the list element identified by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to the **POSITION** value of the next entry in the list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements contained in this list.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, or other member function call.  
  
### Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You can use <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or [CPtrList::Find](../vs140/coblist-class.md#coblist__find).  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is set to **NULL**.  
  
 It is possible to remove an element during an iteration. See the example for [CObList::RemoveAt](../vs140/coblist-class.md#coblist__removeat).  
  
##  \<a name="ctypedptrlist__getprev">\</a>  CTypedPtrList::GetPrev  
 Gets the list element identified by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to the **POSITION** value of the previous entry in the list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements contained in this list.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or other member function call.  
  
### Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You can use <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> in a reverse iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or **Find**.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the first in the list, then the new value of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is set to **NULL**.  
  
##  \<a name="ctypedptrlist__gettail">\</a>  CTypedPtrList::GetTail  
 Gets the pointer that represents the head element of this list.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
### Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter                         *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist-class.md#coblist__isempty) to verify that the list contains elements.  
  
##  \<a name="ctypedptrlist__removehead">\</a>  CTypedPtrList::RemoveHead  
 Removes the element from the head of the list and returns it.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
### Return Value  
 The pointer previously at the head of the list. This pointer is of the type specified by the template parameter                         *TYPE*.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist-class.md#coblist__isempty) to verify that the list contains elements.  
  
##  \<a name="ctypedptrlist__removetail">\</a>  CTypedPtrList::RemoveTail  
 Removes the element from the tail of the list and returns it.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
### Return Value  
 The pointer previously at the tail of the list. This pointer is of the type specified by the template parameter                         *TYPE*.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist-class.md#coblist__isempty) to verify that the list contains elements.  
  
##  \<a name="ctypedptrlist__setat">\</a>  CTypedPtrList::SetAt  
 This member function calls <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>**::SetAt**.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The **POSITION** of the element to be set.  
  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The object pointer to be written to the list.  
  
### Remarks  
 A variable of type **POSITION** is a key for the list. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> writes the object pointer to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 For more detailed remarks, see [CObList::SetAt](../vs140/coblist-class.md#coblist__setat).  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPtrList](../vs140/cptrlist-class.md)   
 [CObList](../vs140/coblist-class.md)