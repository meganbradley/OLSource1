---
title: "CArray Class"
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
  - "CArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class"
  - "arrays [C++], classes"
  - "templates, collection classes"
  - "collection classes, template-based"
ms.assetid: fead8b00-4cfd-4625-ad0e-251df62ba92f
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray Class
Supports arrays that are like C arrays, but can dynamically reduce and grow as necessary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Template parameter that specifies the type of objects stored in the array. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a parameter that is returned by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> *_* <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Template parameter that specifies the argument type that is used to access objects stored in the array. Often a reference to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a parameter that is passed to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CArray::CArray](#carray__carray)|Constructs an empty array.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CArray::Add](#carray__add)|Adds an element to the end of the array; grows the array if necessary.|  
|[CArray::Append](#carray__append)|Appends another array to the array; grows the array if necessary|  
|[CArray::Copy](#carray__copy)|Copies another array to the array; grows the array if necessary.|  
|[CArray::ElementAt](#carray__elementat)|Returns a temporary reference to the element pointer within the array.|  
|[CArray::FreeExtra](#carray__freeextra)|Frees all unused memory above the current upper bound.|  
|[CArray::GetAt](#carray__getat)|Returns the value at a given index.|  
|[CArray::GetCount](#carray__getcount)|Gets the number of elements in this array.|  
|[CArray::GetData](#carray__getdata)|Allows access to elements in the array. Can be **NULL**.|  
|[CArray::GetSize](#carray__getsize)|Gets the number of elements in this array.|  
|[CArray::GetUpperBound](#carray__getupperbound)|Returns the largest valid index.|  
|[CArray::InsertAt](#carray__insertat)|Inserts an element (or all the elements in another array) at a specified index.|  
|[CArray::IsEmpty](#carray__isempty)|Determines whether the array is empty.|  
|[CArray::RemoveAll](#carray__removeall)|Removes all the elements from this array.|  
|[CArray::RemoveAt](#carray__removeat)|Removes an element at a specific index.|  
|[CArray::SetAt](#carray__setat)|Sets the value for a given index; array not allowed to grow.|  
|[CArray::SetAtGrow](#carray__setatgrow)|Sets the value for a given index; grows the array if necessary.|  
|[CArray::SetSize](#carray__setsize)|Sets the number of elements to be contained in this array.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator&#91;&#93;](#carray__operator_[])|Sets or gets the element at the specified index.|  
  
## Remarks  
 Array indexes always start at position 0. You can decide whether to fix the upper bound or enable the array to expand when you add elements past the current bound. Memory is allocated contiguously to the upper bound, even if some elements are null.  
  
> [!NOTE]
>  Most methods that resize a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object or add elements to it use [memcpy_s](../vs140/memcpy_s--wmemcpy_s.md) to move elements. This is a problem because <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is not compatible with any objects that require the constructor to be called. If the items in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are not compatible with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, you must create a new <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> of the appropriate size. You must then use [CArray::Copy](#carray__copy) and [CArray::SetAt](#carray__setat) to populate the new array because those methods use an assignment operator instead of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 As with a C array, the access time for a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> indexed element is constant and is independent of the array size.  
  
> [!TIP]
>  Before using an array, use [SetSize](#carray__setsize) to establish its size and allocate memory for it. If you do not use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 If you need a dump of individual elements in an array, you must set the depth of the [CDumpContext](../vs140/cdumpcontext-class.md) object to 1 or larger.  
  
 Certain member functions of this class call global helper functions that must be customized for most uses of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class. See the topic [Collection Class Helpers](../vs140/collection-class-helpers.md) in the MFC Macros and Globals section.  
  
 Array class derivation is like list derivation.  
  
 For more information about how to use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
## Requirements  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> afxtempl.h  
  
##  \<a name="carray__add">\</a>  CArray::Add  
 Adds a new element to the end of an array, growing the array by 1.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Template parameter specifying the type of arguments referencing elements in this array.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The element to be added to this array.  
  
### Return Value  
 The index of the added element.  
  
### Remarks  
 If [SetSize](#carray__setsize) has been used with an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> value greater than 1, then extra memory may be allocated. However, the upper bound will increase by only 1.  
  
### Example  
 [!code[NVC_MFCCollections#22](../vs140/codesnippet/CPP/carray-class_1.cpp)]  
  
##  \<a name="carray__append">\</a>  CArray::Append  
 Call this member function to add the contents of one array to the end of another.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 Source of the elements to be appended to an array.  
  
### Return Value  
 The index of the first appended element.  
  
### Remarks  
 The arrays must be of the same type.  
  
 If necessary, **Append** may allocate extra memory to accommodate the elements appended to the array.  
  
### Example  
 [!code[NVC_MFCCollections#23](../vs140/codesnippet/CPP/carray-class_2.cpp)]  
  
##  \<a name="carray__carray">\</a>  CArray::CArray  
 Constructs an empty array.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The array grows one element at a time.  
  
### Example  
 [!code[NVC_MFCCollections#24](../vs140/codesnippet/CPP/carray-class_3.cpp)]  
  
##  \<a name="carray__copy">\</a>  CArray::Copy  
 Use this member function to copy the elements of one array to another.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 Source of the elements to be copied to an array.  
  
### Remarks  
 Call this member function to overwrite the elements of one array with the elements of another array.  
  
 **Copy** does not free memory; however, if necessary, **Copy** may allocate extra memory to accommodate the elements copied to the array.  
  
### Example  
 [!code[NVC_MFCCollections#25](../vs140/codesnippet/CPP/carray-class_4.cpp)]  
  
##  \<a name="carray__elementat">\</a>  CArray::ElementAt  
 Returns a temporary reference to the specified element within the array.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](#carray__getupperbound).  
  
### Return Value  
 A reference to an array element.  
  
### Remarks  
 It is used to implement the left-side assignment operator for arrays.  
  
### Example  
  See the example for [GetSize](#carray__getsize).  
  
##  \<a name="carray__freeextra">\</a>  CArray::FreeExtra  
 Frees any extra memory that was allocated while the array was grown.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This function has no effect on the size or upper bound of the array.  
  
### Example  
  See the example for [GetData](#carray__getdata).  
  
##  \<a name="carray__getat">\</a>  CArray::GetAt  
 Returns the array element at the specified index.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of the array elements.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](#carray__getupperbound).  
  
### Return Value  
 The array element currently at this index.  
  
### Remarks  
 Passing a negative value or a value greater than the value returned by <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> will result in a failed assertion.  
  
### Example  
 [!code[NVC_MFCCollections#26](../vs140/codesnippet/CPP/carray-class_5.cpp)]  
  
##  \<a name="carray__getcount">\</a>  CArray::GetCount  
 Returns the number of array elements.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the array.  
  
### Remarks  
 Call this method to retrieve the number of elements in the array. Because indexes are zero-based, the size is 1 greater than the largest index. Calling this method will generate the same result as the [CArray::GetSize](#carray__getsize) method.  
  
### Example  
 [!code[NVC_MFCCollections#27](../vs140/codesnippet/CPP/carray-class_6.cpp)]  
  
##  \<a name="carray__getdata">\</a>  CArray::GetData  
 Use this member function to gain direct access to the elements in an array.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of the array elements.  
  
### Return Value  
 A pointer to an array element.  
  
### Remarks  
 If no elements are available, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> returns a null value.  
  
 While direct access to the elements of an array can help you work more quickly, use caution when calling <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>; any errors you make directly affect the elements of your array.  
  
### Example  
 [!code[NVC_MFCCollections#28](../vs140/codesnippet/CPP/carray-class_7.cpp)]  
  
##  \<a name="carray__getsize">\</a>  CArray::GetSize  
 Returns the size of the array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Because indexes are zero-based, the size is 1 greater than the largest index. Calling this method will generate the same result as the [CArray::GetCount](#carray__getcount) method.  
  
### Example  
 [!code[NVC_MFCCollections#29](../vs140/codesnippet/CPP/carray-class_8.cpp)]  
  
##  \<a name="carray__getupperbound">\</a>  CArray::GetUpperBound  
 Returns the current upper bound of this array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Because array indexes are zero-based, this function returns a value 1 less than <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 The condition **GetUpperBound( )** = –1 indicates that the array contains no elements.  
  
### Example  
  See the example for [CArray::GetAt](#carray__getat).  
  
##  \<a name="carray__insertat">\</a>  CArray::InsertAt  
 The first version of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> inserts one element (or multiple copies of an element) at a specified index in an array.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Template parameter specifying the type of elements in this array.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The element to be placed in this array.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by [GetUpperBound](#carray__getupperbound).  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
### Remarks  
 In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> collection, starting at the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> position.  
  
 The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> function, in contrast, replaces one specified array element and does not shift any elements.  
  
### Example  
 [!code[NVC_MFCCollections#30](../vs140/codesnippet/CPP/carray-class_9.cpp)]  
  
##  \<a name="carray__isempty">\</a>  CArray::IsEmpty  
 Determines whether the array is empty.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the array contains no elements; otherwise 0.  
  
##  \<a name="carray__operator__at">\</a>  CArray::operator []  
 These subscript operators are a convenient substitute for the [SetAt](#carray__setat) and [GetAt](#carray__getat) functions.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in this array.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Index of the element to be accessed.  
  
### Remarks  
 The first operator, called for arrays that are not **const**, may be used on either the right (r-value) or the left (l-value) of an assignment statement. The second, called for **const** arrays, may be used only on the right.  
  
 The Debug version of the library asserts if the subscript (either on the left or right side of an assignment statement) is out of bounds.  
  
### Example  
 [!code[NVC_MFCCollections#34](../vs140/codesnippet/CPP/carray-class_10.cpp)]  
  
##  \<a name="carray__relocateelements">\</a>  CArray::RelocateElements  
 Relocates data to a new buffer when the array should grow or shrink.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A new buffer for the array of elements.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The old array of elements.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Number of elements in the old array.  
  
### Remarks  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is always large enough to hold all the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> elements.  
  
 The [CArray](../vs140/carray-class.md) implementation uses this method to copy the old data to a new buffer when the array should grow or shrink (when [SetSize](#carray__setsize) or [FreeExtra](#carray__freeextra) are called). The default implementation just copies the data.  
  
 For arrays in which an element contains a pointer to one of its own members, or another structure contains a pointer to one of the array elements, the pointers are not updated in plain copy. In this case, you can correct pointers by implementing a specialization of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> with the relevant types. You are also responsible for data copying.  
  
##  \<a name="carray__removeall">\</a>  CArray::RemoveAll  
 Removes all the elements from this array.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 If the array is already empty, the function still works.  
  
### Example  
 [!code[NVC_MFCCollections#31](../vs140/codesnippet/CPP/carray-class_11.cpp)]  
  
##  \<a name="carray__removeat">\</a>  CArray::RemoveAt  
 Removes one or more elements starting at a specified index in an array.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](#carray__getupperbound).  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The number of elements to remove.  
  
### Remarks  
 In the process, it shifts down all the elements above the removed element(s). It decrements the upper bound of the array but does not free memory.  
  
 If you try to remove more elements than are contained in the array above the removal point, then the Debug version of the library asserts.  
  
### Example  
 [!code[NVC_MFCCollections#32](../vs140/codesnippet/CPP/carray-class_12.cpp)]  
  
##  \<a name="carray__setat">\</a>  CArray::SetAt  
 Sets the array element at the specified index.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](#carray__getupperbound).  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Template parameter specifying the type of arguments used for referencing array elements.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The new element value to be stored at the specified position.  
  
### Remarks  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> will not cause the array to grow. Use [SetAtGrow](#carray__setatgrow) if you want the array to grow automatically.  
  
 You must ensure that your index value represents a valid position in the array. If it is out of bounds, then the Debug version of the library asserts.  
  
### Example  
  See the example for [GetAt](#carray__getat).  
  
##  \<a name="carray__setatgrow">\</a>  CArray::SetAtGrow  
 Sets the array element at the specified index.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Template parameter specifying the type of elements in the array.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The element to be added to this array. A **NULL** value is allowed.  
  
### Remarks  
 The array grows automatically if necessary (that is, the upper bound is adjusted to accommodate the new element).  
  
### Example  
 [!code[NVC_MFCCollections#33](../vs140/codesnippet/CPP/carray-class_13.cpp)]  
  
##  \<a name="carray__setsize">\</a>  CArray::SetSize  
 Establishes the size of an empty or existing array; allocates memory if necessary.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The new array size (number of elements). Must be greater than or equal to 0.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
### Remarks  
 If the new size is smaller than the old size, then the array is truncated and all unused memory is released.  
  
 Use this function to set the size of your array before you begin using the array. If you do not use <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 The <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> parameter affects internal memory allocation while the array is growing. Its use never affects the array size as reported by [GetSize](#carray__getsize) and [GetUpperBound](#carray__getupperbound). If the default value is used, MFC allocates memory in a way calculated to avoid memory fragmentation and optimize efficiency for most cases.  
  
### Example  
  See the example for [GetData](#carray__getdata).  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray](../vs140/cobarray-class.md)   
 [Collection Class Helpers](../vs140/collection-class-helpers.md)