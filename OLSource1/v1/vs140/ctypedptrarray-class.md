---
title: "CTypedPtrArray Class"
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
  - "CTypedPtrArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer arrays"
  - "CTypedPtrArray class"
ms.assetid: e3ecdf1a-a889-4156-92dd-ddbd36ccd919
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray Class
Provides a type-safe "wrapper" for objects of class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Base class of the typed pointer array class; must be an array class ( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Type of the elements stored in the base-class array.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTypedPtrArray::Add](#ctypedptrarray__add)|Adds a new element to the end of an array. Grows the array if necessary|  
|[CTypedPtrArray::Append](#ctypedptrarray__append)|Adds the contents of one array to the end of another. Grows the array if necessary|  
|[CTypedPtrArray::Copy](#ctypedptrarray__copy)|Copies another array to the array; grows the array if necessary.|  
|[CTypedPtrArray::ElementAt](#ctypedptrarray__elementat)|Returns a temporary reference to the element pointer within the array.|  
|[CTypedPtrArray::GetAt](#ctypedptrarray__getat)|Returns the value at a given index.|  
|[CTypedPtrArray::InsertAt](#ctypedptrarray__insertat)|Inserts an element (or all the elements in another array) at a specified index.|  
|[CTypedPtrArray::SetAt](#ctypedptrarray__setat)|Sets the value for a given index; array not allowed to grow.|  
|[CTypedPtrArray::SetAtGrow](#ctypedptrarray__setatgrow)|Sets the value for a given index; grows the array if necessary.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CTypedPtrArray::operator &#91;&#93;](#ctypedptrarray__operator_at)|Sets or gets the element at the specified index.|  
  
## Remarks  
 When you use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the C++ type-checking facility helps eliminate errors caused by mismatched pointer types.  
  
 In addition, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> wrapper performs much of the casting that would be required if you used <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Because all <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions are inline, use of this template does not significantly affect the size or speed of your code.  
  
 For more information on using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, see the articles [Collections](../vs140/collections.md) and [Template-Based Classes](../vs140/template-based-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxtempl.h  
  
##  \<a name="ctypedptrarray__add">\</a>  CTypedPtrArray::Add  
 This member function calls <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>**::Add**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of element to be added to the array.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The element to be added to this array.  
  
### Return Value  
 The index of the added element.  
  
### Remarks  
 For more detailed remarks, see [CObArray::Add](../vs140/cobarray-class.md#cobarray__add).  
  
##  \<a name="ctypedptrarray__append">\</a>  CTypedPtrArray::Append  
 This member function calls <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>**::Append**.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Base class of the typed pointer array class; must be an array class ( [CObArray](../vs140/cobarray-class.md) or [CPtrArray](../vs140/cptrarray-class.md)).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 *src*  
 Source of the elements to be appended to an array.  
  
### Return Value  
 The index of the first appended element.  
  
### Remarks  
 For more detailed remarks, see [CObArray::Append](../vs140/cobarray-class.md#cobarray__append).  
  
##  \<a name="ctypedptrarray__copy">\</a>  CTypedPtrArray::Copy  
 This member function calls <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>**::Copy**.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Base class of the typed pointer array class; must be an array class ( [CObArray](../vs140/cobarray-class.md) or [CPtrArray](../vs140/cptrarray-class.md)).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 *src*  
 Source of the elements to be copied to an array.  
  
### Remarks  
 For more detailed remarks, see [CObArray::Copy](../vs140/cobarray-class.md#cobarray__copy).  
  
##  \<a name="ctypedptrarray__elementat">\</a>  CTypedPtrArray::ElementAt  
 This inline function calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>**::ElementAt**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in this array.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>**::GetUpperBound**.  
  
### Return Value  
 A temporary reference to the element at the location specified by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. This element is of the type specified by the template parameter                         *TYPE*.  
  
### Remarks  
 For more detailed remarks, see [CObArray::ElementAt](../vs140/cobarray-class.md#cobarray__elementat).  
  
##  \<a name="ctypedptrarray__getat">\</a>  CTypedPtrArray::GetAt  
 This inline function calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>**::GetAt**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the array.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>**::GetUpperBound**.  
  
### Return Value  
 A copy of the element at the location specified by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. This element is of the type specified by the template parameter                         *TYPE*.  
  
### Remarks  
 For more detailed remarks, see [CObArray::GetAt](../vs140/cobarray-class.md#cobarray__getat)  
  
##  \<a name="ctypedptrarray__insertat">\</a>  CTypedPtrArray::InsertAt  
 This member function calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>**::InsertAt**.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by [CObArray::GetUpperBound](../vs140/cobarray-class.md#cobarray__getupperbound).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The object pointer to be placed in this array. A <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> of value **NULL** is allowed.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Base class of the typed pointer array class; must be an array class ( [CObArray](../vs140/cobarray-class.md) or [CPtrArray](../vs140/cptrarray-class.md)).  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
### Remarks  
 For more detailed remarks, see [CObArray::InsertAt](../vs140/cobarray-class.md#cobarray__insertat).  
  
##  \<a name="ctypedptrarray__operator_at">\</a>  CTypedPtrArray::operator [ ]  
 These inline operators call <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>**::operator [ ]**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the array.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>**::GetUpperBound**.  
  
### Remarks  
 The first operator, called for arrays that are not **const**, can be used on either the right (r-value) or the left (l-value) of an assignment statement. The second, invoked for **const** arrays, can be used only on the right.  
  
 The Debug version of the library asserts if the subscript (either on the left or right side of an assignment statement) is out of bounds.  
  
##  \<a name="ctypedptrarray__setat">\</a>  CTypedPtrArray::SetAt  
 This member function calls <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>**::SetAt**.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [CObArray::GetUpperBound](../vs140/cobarray-class.md#cobarray__getupperbound).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 *ptr*  
 A pointer to the element to be inserted in the array at the nIndex. A NULL value is allowed.  
  
### Remarks  
 For more detailed remarks, see [CObArray::SetAt](../vs140/cobarray-class.md#cobarray__setat).  
  
##  \<a name="ctypedptrarray__setatgrow">\</a>  CTypedPtrArray::SetAtGrow  
 This member function calls <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>**::SetAtGrow**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0.  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The object pointer to be added to this array. A **NULL** value is allowed.  
  
### Remarks  
 For more detailed remarks, see [CObArray::SetAtGrow](../vs140/cobarray-class.md#cobarray__setatgrow).  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPtrArray](../vs140/cptrarray-class.md)   
 [CObArray](../vs140/cobarray-class.md)