---
title: "CAtlArray Class"
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
  - "ATL::CAtlArray"
  - "ATL.CAtlArray"
  - "CAtlArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlArray class"
ms.assetid: 0b503aa8-2357-40af-a326-6654bf1da098
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray Class
This class implements an array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *E*  
 The type of data to be stored in the array.  
  
 *ETraits*  
 The code used to copy or move elements.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Add](../vs140/catlarray--add.md)|Call this method to add an element to the array object.|  
|[Append](../vs140/catlarray--append.md)|Call this method to add the contents of one array to the end of another.|  
|[AssertValid](../vs140/catlarray--assertvalid.md)|Call this method to confirm that the array object is valid.|  
|[CAtlArray](../vs140/catlarray--catlarray.md)|The constructor.|  
|[~CAtlArray](../vs140/catlarray--~catlarray.md)|The destructor.|  
|[Copy](../vs140/catlarray--copy.md)|Call this method to copy the elements of one array to another.|  
|[FreeExtra](../vs140/catlarray--freeextra.md)|Call this method to remove any empty elements from the array.|  
|[GetAt](../vs140/catlarray--getat.md)|Call this method to retrieve a single element from the array object.|  
|[GetCount](../vs140/catlarray--getcount.md)|Call this method to return the number of elements stored in the array.|  
|[GetData](../vs140/catlarray--getdata.md)|Call this method to return a pointer to the first element in the array.|  
|[InsertArrayAt](../vs140/catlarray--insertarrayat.md)|Call this method to insert one array into another.|  
|[InsertAt](../vs140/catlarray--insertat.md)|Call this method to insert a new element (or multiple copies of an element) into the array object.|  
|[IsEmpty](../vs140/catlarray--isempty.md)|Call this method to test if the array is empty.|  
|[RemoveAll](../vs140/catlarray--removeall.md)|Call this method to remove all elements from the array object.|  
|[RemoveAt](../vs140/catlarray--removeat.md)|Call this method to remove one or more elements from the array.|  
|[SetAt](../vs140/catlarray--setat.md)|Call this method to set the value of an element in the array object.|  
|[SetAtGrow](../vs140/catlarray--setatgrow.md)|Call this method to set the value of an element in the array object, expanding the array as required.|  
|[SetCount](../vs140/catlarray--setcount.md)|Call this method to set the size of the array object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator &#91;&#93;](../vs140/catlarray--operator.md)|Call this operator to return a reference to an element in the array.|  
  
### Typedefs  
  
|||  
|-|-|  
|[INARGTYPE](../vs140/catlarray--inargtype.md)|The data type to use for adding elements to the array.|  
|[OUTARGTYPE](../vs140/catlarray--outargtype.md)|The data type to use for retrieving elements from the array.|  
  
## Remarks  
 **CAtlArray** provides methods for creating and managing an array of elements of a user-defined type. Although similar to standard C arrays, the **CAtlArray** object can dynamically shrink and grow as necessary. The array index always starts at position 0, and the upper bound can be fixed, or allowed to expand as new elements are added.  
  
 For arrays with a small number of elements, the ATL class [CSimpleArray](../vs140/csimplearray-class.md) can be used.  
  
 **CAtlArray** is closely related to MFC's **CArray** class and will work in an MFC project, albeit without serialization support.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="catlarray__add">\</a>  CAtlArray::Add  
 Call this method to add an element to the array object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The element to be added to the array.  
  
### Return Value  
 Returns the index of the added element.  
  
### Remarks  
 The new element is added to the end of the array. If no element is provided, an empty element is added; that is, the array is increased in size as though a real element has been added. If the operation fails, [AtlThrow](../vs140/atlthrow.md) is called with the argument E_OUTOFMEMORY.  
  
### Example  
 [!code[NVC_ATL_Utilities#1](../vs140/codesnippet/CPP/catlarray-class_1.cpp)]  
  
##  \<a name="catlarray__append">\</a>  CAtlArray::Append  
 Call this method to add the contents of one array to the end of another.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The array to append.  
  
### Return Value  
 Returns the index of the first appended element.  
  
### Remarks  
 The elements in the supplied array are added to the end of the existing array. If necessary, memory will be allocated to accommodate the new elements.  
  
 The arrays must be of the same type, and it is not possible to append an array to itself.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument is not a valid array or if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> refers to the same object. In release builds, invalid arguments may lead to unpredictable behavior.  
  
### Example  
 [!code[NVC_ATL_Utilities#2](../vs140/codesnippet/CPP/catlarray-class_2.cpp)]  
  
##  \<a name="catlarray__assertvalid">\</a>  CAtlArray::AssertValid  
 Call this method to confirm that the array object is valid.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the array object is not valid, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> will throw an assertion. This method is available only if _DEBUG is defined.  
  
### Example  
 [!code[NVC_ATL_Utilities#3](../vs140/codesnippet/CPP/catlarray-class_3.cpp)]  
  
##  \<a name="catlarray__catlarray">\</a>  CAtlArray::CAtlArray  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the array object.  
  
### Example  
 [!code[NVC_ATL_Utilities#4](../vs140/codesnippet/CPP/catlarray-class_4.cpp)]  
  
##  \<a name="catlarray___dtorcatlarray">\</a>  CAtlArray::~CAtlArray  
 The destructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Frees up any resources used by the array object.  
  
##  \<a name="catlarray__copy">\</a>  CAtlArray::Copy  
 Call this method to copy the elements of one array to another.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The source of the elements to copy to an array.  
  
### Remarks  
 Call this method to overwrite elements of one array with the elements of another array. If necessary, memory will be allocated to accommodate the new elements. It is not possible to copy elements of an array to itself.  
  
 If the existing contents of the array are to be retained, use [CAtlArray::Append](../vs140/catlarray--append.md) instead.  
  
 In debug builds, an ATLASSERT will be raised if the existing <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is not valid, or if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> refers to the same object. In release builds, invalid arguments may lead to unpredictable behavior.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> does not support arrays consisting of elements created with the [CAutoPtr](../vs140/cautoptr-class.md) class.  
  
### Example  
 [!code[NVC_ATL_Utilities#5](../vs140/codesnippet/CPP/catlarray-class_5.cpp)]  
  
##  \<a name="catlarray__freeextra">\</a>  CAtlArray::FreeExtra  
 Call this method to remove any empty elements from the array.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Any empty elements are removed, but the size and upper bound of the array remain unchanged.  
  
 In debug builds, an ATLASSERT will be raised if the CAtlArray object is not valid, or if the array would exceed its maximum size.  
  
##  \<a name="catlarray__getat">\</a>  CAtlArray::GetAt  
 Call this method to retrieves a single element from the array object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The index value of the array element to return.  
  
### Return Value  
 Returns a reference to the required array element.  
  
### Remarks  
 In debug builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> exceeds the number of elements in the array. In release builds, an invalid argument may lead to unpredictable behavior.  
  
### Example  
 [!code[NVC_ATL_Utilities#6](../vs140/codesnippet/CPP/catlarray-class_6.cpp)]  
  
##  \<a name="catlarray__getcount">\</a>  CAtlArray::GetCount  
 Call this method to return the number of elements stored in the array.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements stored in the array.  
  
### Remarks  
 As the first element in the array is at position 0, the value returned by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is always 1 greater than the largest index.  
  
### Example  
 See the example for [CAtlArray::GetAt](../vs140/catlarray--getat.md).  
  
##  \<a name="catlarray__getdata">\</a>  CAtlArray::GetData  
 Call this method to return a pointer to the first element in the array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the memory location storing the first element in the array. If no elements are available, NULL is returned.  
  
### Example  
 [!code[NVC_ATL_Utilities#7](../vs140/codesnippet/CPP/catlarray-class_7.cpp)]  
  
##  \<a name="catlarray__inargtype">\</a>  CAtlArray::INARGTYPE  
 The data type to use for adding elements to the array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="catlarray__insertarrayat">\</a>  CAtlArray::InsertArrayAt  
 Call this method to insert one array into another.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The index at which the array is to be inserted.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The array to be inserted.  
  
### Remarks  
 Elements from the array <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> are copied into the array object, beginning at element <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The existing array elements are moved to avoid being overwritten.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object is not valid, or if the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointer is NULL or invalid.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> does not support arrays consisting of elements created with the [CAutoPtr](../vs140/cautoptr-class.md) class.  
  
### Example  
 [!code[NVC_ATL_Utilities#8](../vs140/codesnippet/CPP/catlarray-class_8.cpp)]  
  
##  \<a name="catlarray__insertat">\</a>  CAtlArray::InsertAt  
 Call this method to insert a new element (or multiple copies of an element) into the array object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The index where the element or elements are to be inserted.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The value of the element or elements to be inserted.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The number of elements to add.  
  
### Remarks  
 Inserts one or more elements into the array, starting at index <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. Existing elements are moved to avoid being overwritten.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is invalid, the number of elements to be added is zero, or the combined number of elements is too large for the array to contain. In retail builds, passing invalid parameters may cause unpredictable results.  
  
### Example  
 [!code[NVC_ATL_Utilities#9](../vs140/codesnippet/CPP/catlarray-class_9.cpp)]  
  
##  \<a name="catlarray__isempty">\</a>  CAtlArray::IsEmpty  
 Call this method to test if the array is empty.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if the array is empty, false otherwise.  
  
### Remarks  
 The array is said to be empty if it contains no elements. Therefore, even if the array contains empty elements, it is not empty.  
  
### Example  
 [!code[NVC_ATL_Utilities#10](../vs140/codesnippet/CPP/catlarray-class_10.cpp)]  
  
##  \<a name="catlarray__operator__at">\</a>  CAtlArray::operator []  
 Call this operator to return a reference to an element in the array.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The index value of the array element to return.  
  
### Return Value  
 Returns a reference to the required array element.  
  
### Remarks  
 Performs a similar function to [CAtlArray::GetAt](../vs140/catlarray--getat.md). Unlike the MFC class [CArray](../vs140/carray-class.md), this operator cannot be used as a substitute for [CAtlArray::SetAt](../vs140/catlarray--setat.md).  
  
 In debug builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> exceeds the total number of elements in the array. In retail builds, an invalid parameter may cause unpredictable results.  
  
##  \<a name="catlarray__outargtype">\</a>  CAtlArray::OUTARGTYPE  
 The data type to use for retrieving elements from the array.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="catlarray__removeall">\</a>  CAtlArray::RemoveAll  
 Call this method to remove all elements from the array object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 Removes all of the elements from the array object.  
  
 This method calls [CAtlArray::SetCount](../vs140/catlarray--setcount.md) to resize the array and subsequently frees any allocated memory.  
  
### Example  
 See the example for [CAtlArray::IsEmpty](../vs140/catlarray--isempty.md).  
  
##  \<a name="catlarray__removeat">\</a>  CAtlArray::RemoveAt  
 Call this method to remove one or more elements from the array.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The index of the first element to remove.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The number of elements to remove.  
  
### Remarks  
 Removes one or more elements from the array. Any remaining elements are shifted down. The upper bound is decremented, but memory is not freed until a call to [CAtlArray::FreeExtra](../vs140/catlarray--freeextra.md) is made.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object is not valid, or if the combined total of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> exceeds the total number of elements in the array. In retail builds, invalid parameters may cause unpredictable results.  
  
### Example  
 [!code[NVC_ATL_Utilities#11](../vs140/codesnippet/CPP/catlarray-class_11.cpp)]  
  
##  \<a name="catlarray__setat">\</a>  CAtlArray::SetAt  
 Call this method to set the value of an element in the array object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The index pointing to the array element to set.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The new value of the specified element.  
  
### Remarks  
 In debug builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> exceeds the number of elements in the array. In retail builds, an invalid parameter may result in unpredictable results.  
  
### Example  
 See the example for [CAtlArray::GetAt](../vs140/catlarray--getat.md).  
  
##  \<a name="catlarray__setcount">\</a>  CAtlArray::SetCount  
 Call this method to set the size of the array object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The required size of the array.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A value used to determine how large to make the buffer. A value of -1 causes an internally calculated value to be used.  
  
### Return Value  
 Returns true if the array is successfully resized, false otherwise.  
  
### Remarks  
 The array can be increased or decreased in size. If increased, extra empty elements are added to the array. If decreased, the elements with the largest indices will be deleted and memory freed.  
  
 Use this method to set the size of the array before using it. If <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is not used, the process of adding elements — and the subsequent memory allocation performed — will reduce performance and fragment memory.  
  
### Example  
 See the example for [CAtlArray::GetData](../vs140/catlarray--getdata.md).  
  
##  \<a name="catlarray__setatgrow">\</a>  CAtlArray::SetAtGrow  
 Call this method to set the value of an element in the array object, expanding the array as required.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The index pointing to the array element to set.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The new value of the specified element.  
  
### Remarks  
 Replaces the value of the element pointed to by the index. If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is larger than the current size of the array, the array is automatically increased using a call to [CAtlArray::SetCount](../vs140/catlarray--setcount.md). In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object is not valid. In retail builds, invalid parameters may cause unpredictable results.  
  
### Example  
 [!code[NVC_ATL_Utilities#12](../vs140/codesnippet/CPP/catlarray-class_12.cpp)]  
  
## See Also  
 [MMXSwarm Sample](../vs140/visual-c---samples.md)   
 [DynamicConsumer Sample](../vs140/visual-c---samples.md)   
 [UpdatePV Sample](../vs140/visual-c---samples.md)   
 [Marquee Sample](../vs140/visual-c---samples.md)   
 [CArray Class](../vs140/carray-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)