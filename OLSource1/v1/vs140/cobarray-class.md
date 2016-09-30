---
title: "CObArray Class"
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
  - "CObArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++], pointers"
  - "CObArray class"
  - "arrays [C++], Object type"
  - "object arrays, CObArray class"
ms.assetid: 27894efd-2370-4776-9ed9-24a98492af17
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray Class
Supports arrays of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObArray::CObArray](#cobarray__cobarray)|Constructs an empty array for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pointers.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObArray::Add](#cobarray__add)|Adds an element to the end of the array; grows the array if necessary.|  
|[CObArray::Append](#cobarray__append)|Appends another array to the array; grows the array if necessary.|  
|[CObArray::Copy](#cobarray__copy)|Copies another array to the array; grows the array if necessary.|  
|[CObArray::ElementAt](#cobarray__elementat)|Returns a temporary reference to the element pointer within the array.|  
|[CObArray::FreeExtra](#cobarray__freeextra)|Frees all unused memory above the current upper bound.|  
|[CObArray::GetAt](#cobarray__getat)|Returns the value at a given index.|  
|[CObArray::GetCount](#cobarray__getcount)|Gets the number of elements in this array.|  
|[CObArray::GetData](#cobarray__getdata)|Allows access to elements in the array. Can be **NULL**.|  
|[CObArray::GetSize](#cobarray__getsize)|Gets the number of elements in this array.|  
|[CObArray::GetUpperBound](#cobarray__getupperbound)|Returns the largest valid index.|  
|[CObArray::InsertAt](#cobarray__insertat)|Inserts an element (or all the elements in another array) at a specified index.|  
|[CObArray::IsEmpty](#cobarray__isempty)|Determines if the array is empty.|  
|[CObArray::RemoveAll](#cobarray__removeall)|Removes all the elements from this array.|  
|[CObArray::RemoveAt](#cobarray__removeat)|Removes an element at a specific index.|  
|[CObArray::SetAt](#cobarray__setat)|Sets the value for a given index; array not allowed to grow.|  
|[CObArray::SetAtGrow](#cobarray__setatgrow)|Sets the value for a given index; grows the array if necessary.|  
|[CObArray::SetSize](#cobarray__setsize)|Sets the number of elements to be contained in this array.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CObArray::operator &#91;&#93;](#cobarray__operator_at)|Sets or gets the element at the specified index.|  
  
## Remarks  
 These object arrays are similar to C arrays, but they can dynamically shrink and grow as necessary.  
  
 Array indexes always start at position 0. You can decide whether to fix the upper bound or allow the array to expand when you add elements past the current bound. Memory is allocated contiguously to the upper bound, even if some elements are null.  
  
 Under Win32, the size of a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object is limited only to available memory.  
  
 As with a C array, the access time for a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> indexed element is constant and is independent of the array size.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> macro to support serialization and dumping of its elements. If an array of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> pointers is stored to an archive, either with the overloaded insertion operator or with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function, each <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element is, in turn, serialized along with its array index.  
  
 If you need a dump of individual <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> elements in an array, you must set the depth of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object to 1 or greater.  
  
 When a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, only the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> pointers are removed, not the objects they reference.  
  
> [!NOTE]
>  Before using an array, use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to establish its size and allocate memory for it. If you do not use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 Array class derivation is similar to list derivation. For details on the derivation of a special-purpose list class, see the article [Collections](../vs140/collections.md).  
  
> [!NOTE]
>  You must use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> macro in the implementation of your derived class if you intend to serialize the array.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
##  \<a name="cobarray__add">\</a>  CObArray::Add  
 Adds a new element to the end of an array, growing the array by 1.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> pointer to be added to this array.  
  
### Return Value  
 The index of the added element.  
  
### Remarks  
 If [SetSize](#cobarray__setsize) has been used with an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value greater than 1, then extra memory may be allocated. However, the upper bound will increase by only 1.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR Add( BYTE**  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR Add( DWORD**  <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR Add( void\***  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR Add( LPCTSTR**  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  **); throw( CMemoryException\* );**\<br />\<br /> **INT_PTR Add(const CString&**  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR Add( UINT**  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR Add( WORD**  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
### Example  
  See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#75](../vs140/codesnippet/CPP/cobarray-class_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
##  \<a name="cobarray__append">\</a>  CObArray::Append  
 Call this member function to add the contents of another array to the end of the given array.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 Source of the elements to be appended to the array.  
  
### Return Value  
 The index of the first appended element.  
  
### Remarks  
 The arrays must be of the same type.  
  
 If necessary, **Append** may allocate extra memory to accommodate the elements appended to the array.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR Append( const CByteArray&**  *src*  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR Append( const CDWordArray&**  *src*  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR Append( const CPtrArray&**  *src*  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR Append( const CStringArray&**  *src*  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR Append( const CUIntArray&**  *src*  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR Append( const CWordArray&**  *src*  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#76](../vs140/codesnippet/CPP/cobarray-class_2.cpp)]  
  
##  \<a name="cobarray__copy">\</a>  CObArray::Copy  
 Call this member function to overwrite the elements of the given array with the elements of another array of the same type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 Source of the elements to be copied to the array.  
  
### Remarks  
 **Copy** does not free memory; however, if necessary, **Copy** may allocate extra memory to accommodate the elements copied to the array.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void Copy( const CByteArray&**  *src*  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void Copy( const CDWordArray&**  *src*  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void Copy( const CPtrArray&**  *src*  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void Copy( const CStringArray&**  *src*  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void Copy( const CUIntArray&**  *src*  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void Copy( const CWordArray&**  *src*  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#77](../vs140/codesnippet/CPP/cobarray-class_3.cpp)]  
  
##  \<a name="cobarray__cobarray">\</a>  CObArray::CObArray  
 Constructs an empty <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> pointer array.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The array grows one element at a time.  
  
 The following table shows other constructors that are similar to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
|Class|Constructor|  
|-----------|-----------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**CByteArray( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**CDWordArray( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**CPtrArray( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CStringArray( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**CUIntArray( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**CWordArray( );**|  
  
### Example  
 [!code[NVC_MFCCollections#78](../vs140/codesnippet/CPP/cobarray-class_4.cpp)]  
  
##  \<a name="cobarray__elementat">\</a>  CObArray::ElementAt  
 Returns a temporary reference to the element pointer within the array.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> pointer.  
  
### Remarks  
 It is used to implement the left-side assignment operator for arrays. Note that this is an advanced function that should be used only to implement special array operators.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**BYTE& ElementAt( INT_PTR** <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**DWORD& ElementAt( INT_PTR** <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void\*& ElementAt( INT_PTR** <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CString& ElementAt( INT_PTR** <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**UINT& ElementAt( INT_PTR** <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**WORD& ElementAt( INT_PTR** <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  **);**|  
  
### Example  
  See the example for [CObArray::GetSize](#cobarray__getsize).  
  
##  \<a name="cobarray__freeextra">\</a>  CObArray::FreeExtra  
 Frees any extra memory that was allocated while the array was grown.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This function has no effect on the size or upper bound of the array.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void FreeExtra( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void FreeExtra( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void FreeExtra( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void FreeExtra( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void FreeExtra( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void FreeExtra( );**|  
  
### Example  
  See the example for [CObArray::GetData](#cobarray__getdata).  
  
##  \<a name="cobarray__getat">\</a>  CObArray::GetAt  
 Returns the array element at the specified index.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Return Value  
 The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> pointer element currently at this index.  
  
### Remarks  
  
> [!NOTE]
>  Passing a negative value or a value greater than the value returned by <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> will result in a failed assertion.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**BYTE GetAt( INT_PTR** <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  **) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**DWORD GetAt( INT_PTR** <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  **) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void\* GetAt( INT_PTR** <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  **) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CString GetAt( INT_PTR** <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  **) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**UINT GetAt( INT_PTR** <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  **) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**WORD GetAt( INT_PTR** <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  **) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#79](../vs140/codesnippet/CPP/cobarray-class_5.cpp)]  
  
##  \<a name="cobarray__getcount">\</a>  CObArray::GetCount  
 Returns the number of array elements.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the array.  
  
### Remarks  
 Call this method to retrieve the number of elements in the array. Because indexes are zero-based, the size is 1 greater than the largest index.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetCount( ) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#80](../vs140/codesnippet/CPP/cobarray-class_6.cpp)]  
  
##  \<a name="cobarray__getdata">\</a>  CObArray::GetData  
 Use this member function to gain direct access to the elements in the array.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the array of <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> pointers.  
  
### Remarks  
 If no elements are available, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> returns a null value.  
  
 While direct access to the elements of an array can help you work more quickly, use caution when calling <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>; any errors you make directly affect the elements of your array.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**const BYTE\* GetData( ) const;BYTE\* GetData( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**const DWORD\* GetData( ) const;DWORD\* GetData( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**const void\*\* GetData( ) const;void\*\* GetData( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**const CString\* GetData( ) const;CString\* GetData( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**const UINT\* GetData( ) const;UINT\* GetData( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**const WORD\* GetData( ) const;WORD\* GetData( );**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#81](../vs140/codesnippet/CPP/cobarray-class_7.cpp)]  
  
##  \<a name="cobarray__getsize">\</a>  CObArray::GetSize  
 Returns the size of the array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Since indexes are zero-based, the size is 1 greater than the largest index.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetSize( ) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#82](../vs140/codesnippet/CPP/cobarray-class_8.cpp)]  
  
##  \<a name="cobarray__getupperbound">\</a>  CObArray::GetUpperBound  
 Returns the current upper bound of this array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The index of the upper bound (zero-based).  
  
### Remarks  
 Because array indexes are zero-based, this function returns a value 1 less than <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
 The condition **GetUpperBound( )** = –1 indicates that the array contains no elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#83](../vs140/codesnippet/CPP/cobarray-class_9.cpp)]  
  
##  \<a name="cobarray__insertat">\</a>  CObArray::InsertAt  
 Inserts an element (or all the elements in another array) at a specified index.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> pointer to be placed in this array. A <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> of value **NULL** is allowed.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
### Remarks  
 The first version of <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> inserts one element (or multiple copies of an element) at a specified index in an array. In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> collection, starting at the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> position.  
  
 The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> function, in contrast, replaces one specified array element and does not shift any elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> **, CByteArray\***  <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> **, CDWordArray\***  <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> **, CPtrArray\***  <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> **, CStringArray\***  <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> **, CUIntArray\***  <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void InsertAt( INT_PTR**  <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> **= 1 );**\<br />\<br /> **throw( CMemoryException\* );**\<br />\<br /> **void InsertAt( INT_PTR**  <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> **, CWordArray\***  <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
### Example  
  See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#84](../vs140/codesnippet/CPP/cobarray-class_10.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
  
##  \<a name="cobarray__isempty">\</a>  CObArray::IsEmpty  
 Determines if the array is empty.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the array is empty; otherwise 0.  
  
##  \<a name="cobarray__operator_at">\</a>  CObArray::operator [ ]  
 These subscript operators are a convenient substitute for the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> functions.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The first operator, called for arrays that are not **const**, may be used on either the right (r-value) or the left (l-value) of an assignment statement. The second, called for **const** arrays, may be used only on the right.  
  
 The Debug version of the library asserts if the subscript (either on the left or right side of an assignment statement) is out of bounds.  
  
 The following table shows other operators that are similar to **CObArray::operator []**.  
  
|Class|Operator|  
|-----------|--------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**BYTE& operator [](INT_PTR** <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **BYTE operator [](INT_PTR**  <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  **\) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**DWORD& operator [](INT_PTR**  <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **DWORD operator [](INT_PTR**  <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  **\) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void\*& operator [](INT_PTR**  <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **void\* operator [](INT_PTR**  <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  **\) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CString& operator [](INT_PTR**  <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **CString operator [](INT_PTR**  <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  **\) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**UINT& operator [](INT_PTR**  <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **UINT operator [](INT_PTR**  <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  **\) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**WORD& operator [](INT_PTR**  <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  **\);**\<br />\<br /> **WORD operator [](INT_PTR**  <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  **\) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#88](../vs140/codesnippet/CPP/cobarray-class_11.cpp)]  
  
##  \<a name="cobarray__removeall">\</a>  CObArray::RemoveAll  
 Removes all the pointers from this array but does not actually delete the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 If the array is already empty, the function still works.  
  
 The <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> function frees all memory used for pointer storage.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void RemoveAll( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void RemoveAll( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void RemoveAll( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void RemoveAll( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void RemoveAll( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void RemoveAll( );**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#85](../vs140/codesnippet/CPP/cobarray-class_12.cpp)]  
  
##  \<a name="cobarray__removeat">\</a>  CObArray::RemoveAt  
 Removes one or more elements starting at a specified index in an array.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The number of elements to remove.  
  
### Remarks  
 In the process, it shifts down all the elements above the removed element(s). It decrements the upper bound of the array but does not free memory.  
  
 If you try to remove more elements than are contained in the array above the removal point, then the Debug version of the library asserts.  
  
 The <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> function removes the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> pointer from the array, but it does not delete the object itself.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  **= 1 );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  **= 1 );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  **= 1 );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  **= 1 );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void RemoveAt( INT_PTR**  <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> **, INT_PTR**  <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  **= 1 );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void RemoveAt( INT_PTR** <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> **, INT_PTR**  *nCount*  **= 1 );**|  
  
### Example  
  See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#112](../vs140/codesnippet/CPP/cobarray-class_13.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  
##  \<a name="cobarray__setat">\</a>  CObArray::SetAt  
 Sets the array element at the specified index.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 The object pointer to be inserted in this array. A **NULL** value is allowed.  
  
### Remarks  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> will not cause the array to grow. Use <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> if you want the array to grow automatically.  
  
 You must ensure that your index value represents a valid position in the array. If it is out of bounds, then the Debug version of the library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  **);**|  
  
### Example  
  See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#86](../vs140/codesnippet/CPP/cobarray-class_14.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
  
##  \<a name="cobarray__setatgrow">\</a>  CObArray::SetAtGrow  
 Sets the array element at the specified index.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 The object pointer to be added to this array. A **NULL** value is allowed.  
  
### Remarks  
 The array grows automatically if necessary (that is, the upper bound is adjusted to accommodate the new element).  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetAtGrow( INT_PTR**  <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  **);**\<br />\<br /> **throw( CMemoryException\* );**|  
  
### Example  
  See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#87](../vs140/codesnippet/CPP/cobarray-class_15.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
  
##  \<a name="cobarray__setsize">\</a>  CObArray::SetSize  
 Establishes the size of an empty or existing array; allocates memory if necessary.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 The new array size (number of elements). Must be greater than or equal to 0.  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
### Remarks  
 If the new size is smaller than the old size, then the array is truncated and all unused memory is released. For efficiency, call <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> to set the size of the array before using it. This prevents the need to reallocate and copy the array each time an item is added.  
  
 The <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> parameter affects internal memory allocation while the array is growing. Its use never affects the array size as reported by <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
 If the size of the array has grown, all newly allocated **CObject \*** pointers are set to NULL.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetSize( INT_PTR**  <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  **= -1 );**\<br />\<br /> **throw( CMemoryException\* );**|  
  
### Example  
  See the example for [CObArray::GetData](#cobarray__getdata).  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStringArray](../vs140/cstringarray-class.md)   
 [CPtrArray](../vs140/cptrarray-class.md)   
 [CByteArray](../vs140/cbytearray-class.md)   
 [CWordArray](../vs140/cwordarray-class.md)   
 [CDWordArray](../vs140/cdwordarray-class.md)