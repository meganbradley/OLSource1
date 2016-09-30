---
title: "COleSafeArray Class"
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
  - "COleSafeArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleSafeArray class"
  - "arrays [C++], safe"
  - "safe arrays"
  - "ODBC, safe arrays"
ms.assetid: f45a5224-5f48-40ec-9ddd-287ef9740150
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray Class
A class for working with arrays of arbitrary type and dimension.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleSafeArray::COleSafeArray](#colesafearray__colesafearray)|Constructs a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleSafeArray::AccessData](#colesafearray__accessdata)|Retrieves a pointer to the array data.|  
|[COleSafeArray::AllocData](#colesafearray__allocdata)|Allocates memory for the array.|  
|[COleSafeArray::AllocDescriptor](#colesafearray__allocdescriptor)|Allocates memory for the safe array descriptor.|  
|[COleSafeArray::Attach](#colesafearray__attach)|Gives control of the existing **VARIANT** array to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::Clear](#colesafearray__clear)|Frees all data in the underlying **VARIANT**.|  
|[COleSafeArray::Copy](#colesafearray__copy)|Creates a copy of an existing array.|  
|[COleSafeArray::Create](#colesafearray__create)|Creates a safe array.|  
|[COleSafeArray::CreateOneDim](#colesafearray__createonedim)|Creates a one-dimensional <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::Destroy](#colesafearray__destroy)|Destroys an existing array.|  
|[COleSafeArray::DestroyData](#colesafearray__destroydata)|Destroys data in a safe array.|  
|[COleSafeArray::DestroyDescriptor](#colesafearray__destroydescriptor)|Destroys a descriptor of a safe array.|  
|[COleSafeArray::Detach](#colesafearray__detach)|Detaches the **VARIANT** array from the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object (so that the data will not be freed).|  
|[COleSafeArray::GetByteArray](#colesafearray__getbytearray)|Copies the contents of the safe array into a [CByteArray](../vs140/cbytearray-class.md).|  
|[COleSafeArray::GetDim](#colesafearray__getdim)|Returns the number of dimensions in the array.|  
|[COleSafeArray::GetElement](#colesafearray__getelement)|Retrieves a single element of the safe array.|  
|[COleSafeArray::GetElemSize](#colesafearray__getelemsize)|Returns the size, in bytes, of one element in a safe array.|  
|[COleSafeArray::GetLBound](#colesafearray__getlbound)|Returns the lower bound for any dimension of a safe array.|  
|[COleSafeArray::GetOneDimSize](#colesafearray__getonedimsize)|Returns the number of elements in the one-dimensional <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::GetUBound](#colesafearray__getubound)|Returns the upper bound for any dimension of a safe array.|  
|[COleSafeArray::Lock](#colesafearray__lock)|Increments the lock count of an array and places a pointer to the array data in the array descriptor.|  
|[COleSafeArray::PtrOfIndex](#colesafearray__ptrofindex)|Returns a pointer to the indexed element.|  
|[COleSafeArray::PutElement](#colesafearray__putelement)|Assigns a single element into the array.|  
|[COleSafeArray::Redim](#colesafearray__redim)|Changes the least significant (rightmost) bound of a safe array.|  
|[COleSafeArray::ResizeOneDim](#colesafearray__resizeonedim)|Changes the number of elements in a one-dimensional <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::UnaccessData](#colesafearray__unaccessdata)|Decrements the lock count of an array and invalidates the pointer retrieved by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
|[COleSafeArray::Unlock](#colesafearray__unlock)|Decrements the lock count of an array so it can be freed or resized.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[COleSafeArray::operator LPCVARIANT](#colesafearray__operator_lpcvariant)|Accesses the underlying **VARIANT** structure of the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::operator LPVARIANT](#colesafearray__operator_lpvariant)|Accesses the underlying **VARIANT** structure of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[COleSafeArray::operator =](#colesafearray__operator__eq)|Copies values into a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object ( **SAFEARRAY**, **VARIANT**, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> array).|  
|[COleSafeArray::operator ==](#colesafearray__operator__eq_eq)|Compares two variant arrays ( **SAFEARRAY**, **VARIANT**, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> arrays).|  
|[COleSafeArray::operator <<](#colesafearray__operator__lt__lt_)|Outputs the contents of a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object to the dump context.|  
  
## Remarks  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> derives from the OLE **VARIANT** structure. The OLE **SAFEARRAY** member functions are available through <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, as well as a set of member functions specifically designed for one-dimensional arrays of bytes.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="colesafearray__accessdata">\</a>  COleSafeArray::AccessData  
 Retrieves a pointer to the array data.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A pointer to a pointer to the array data.  
  
### Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#26](../vs140/codesnippet/CPP/colesafearray-class_1.cpp)]  
  
##  \<a name="colesafearray__allocdata">\</a>  COleSafeArray::AllocData  
 Allocates memory for a safe array.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__allocdescriptor">\</a>  COleSafeArray::AllocDescriptor  
 Allocates memory for the descriptor of a safe array.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Number of dimensions in the safe array.  
  
### Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__attach">\</a>  COleSafeArray::Attach  
 Gives control of the data in an existing **VARIANT** array to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *varSrc*  
 A **VARIANT** object. The                                 *varSrc* parameter must have the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4)**VT_ARRAY**.  
  
### Remarks  
 The source **VARIANT**'s type is set to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. This function clears the current array data, if any.  
  
### Example  
  See the example for [COleSafeArray::AccessData](#colesafearray__accessdata).  
  
##  \<a name="colesafearray__clear">\</a>  COleSafeArray::Clear  
 Clears the safe array.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The function clears a safe array by setting the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> of the object to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. The current contents are released and the array is freed.  
  
##  \<a name="colesafearray__colesafearray">\</a>  COleSafeArray::COleSafeArray  
 Constructs a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object or **SAFEARRAY** to be copied into the new <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The **VARTYPE** of the new <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** to be copied into the new <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
 *varSrc*  
 An existing **VARIANT** or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to a **VARIANT** object to be copied into the new <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
### Remarks  
 All of these constructors create new <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> objects. If there is no parameter, an empty <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object is created ( <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>). If the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is copied from another array whose [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) is known implicitly (a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, or **VARIANT**), the **VARTYPE** of the source array is retained and need not be specified. If the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is copied from another array whose **VARTYPE** is not known ( **SAFEARRAY**), the **VARTYPE** must be specified in the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> parameter.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__copy">\</a>  COleSafeArray::Copy  
 Creates a copy of an existing safe array.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *ppsa*  
 Pointer to a location in which to return the new array descriptor.  
  
### Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__create">\</a>  COleSafeArray::Create  
 Allocates and initializes the data for the array.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The base type of the array (that is, the **VARTYPE** of each element of the array). The **VARTYPE** is restricted to a subset of the variant types. Neither the **VT_ARRAY** nor the **VT_BYREF** flag can be set. <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and **VT_NULL** are not valid base types for the array. All other types are legal.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Number of dimensions in the array. This can be changed after the array is created with [Redim](#colesafearray__redim).  
  
 *rgElements*  
 Pointer to an array of the number of elements for each dimension in the array.  
  
 *rgsabounds*  
 Pointer to a vector of bounds (one for each dimension) to allocate for the array.  
  
### Remarks  
 This function will clear the current array data if necessary. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#27](../vs140/codesnippet/CPP/colesafearray-class_2.cpp)]  
  
##  \<a name="colesafearray__createonedim">\</a>  COleSafeArray::CreateOneDim  
 Creates a new one-dimensional <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The base type of the array (that is, the **VARTYPE** of each element of the array).  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Number of elements in the array. This can be changed after the array is created with [ResizeOneDim](#colesafearray__resizeonedim).  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Pointer to the data to copy into the array.  
  
 *nLBound*  
 The lower bound of the array.  
  
### Remarks  
 The function allocates and initializes the data for the array, copying the specified data if the pointer <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is not **NULL**.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#28](../vs140/codesnippet/CPP/colesafearray-class_3.cpp)]  
  
##  \<a name="colesafearray__destroy">\</a>  COleSafeArray::Destroy  
 Destroys an existing array descriptor and all the data in the array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 If objects are stored in the array, each object is released. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__destroydata">\</a>  COleSafeArray::DestroyData  
 Destroys all the data in a safe array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 If objects are stored in the array, each object is released. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__destroydescriptor">\</a>  COleSafeArray::DestroyDescriptor  
 Destroys a descriptor of a safe array.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__detach">\</a>  COleSafeArray::Detach  
 Detaches the **VARIANT** data from the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The underlying **VARIANT** value in the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The function detaches the data in a safe array by setting the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) of the object to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. It is the caller's responsibility to free the array by calling the Windows function [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835).  
  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
  See the example for [COleSafeArray::PutElement](#colesafearray__putelement).  
  
##  \<a name="colesafearray__getbytearray">\</a>  COleSafeArray::GetByteArray  
 Copies the contents of the safe array into a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A reference to a [CByteArray](../vs140/cbytearray-class.md) object.  
  
##  \<a name="colesafearray__getdim">\</a>  COleSafeArray::GetDim  
 Returns the number of dimensions in the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The number of dimensions in the safe array.  
  
### Example  
 [!code[NVC_MFCOleContainer#27](../vs140/codesnippet/CPP/colesafearray-class_2.cpp)]  
  
##  \<a name="colesafearray__getelement">\</a>  COleSafeArray::GetElement  
 Retrieves a single element of the safe array.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Pointer to an array of indexes for each dimension of the array.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Pointer to the location to place the element of the array.  
  
### Remarks  
 This function automatically calls the windows functions <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> before and after retrieving the element. If the data element is a string, object, or variant, the function copies the element in the correct way. The parameter <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> should point to a large enough buffer to contain the element.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#29](../vs140/codesnippet/CPP/colesafearray-class_4.cpp)]  
  
##  \<a name="colesafearray__getelemsize">\</a>  COleSafeArray::GetElemSize  
 Retrieves the size of an element in a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The size, in bytes, of the elements of a safe array.  
  
##  \<a name="colesafearray__getlbound">\</a>  COleSafeArray::GetLBound  
 Returns the lower bound for any dimension of a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The array dimension for which to get the lower bound.  
  
 *pLBound*  
 Pointer to the location to return the lower bound.  
  
### Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#30](../vs140/codesnippet/CPP/colesafearray-class_5.cpp)]  
  
##  \<a name="colesafearray__getonedimsize">\</a>  COleSafeArray::GetOneDimSize  
 Returns the number of elements in the one-dimensional <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in the one-dimensional safe array.  
  
### Example  
  See the example for [COleSafeArray::CreateOneDim](#colesafearray__createonedim).  
  
##  \<a name="colesafearray__getubound">\</a>  COleSafeArray::GetUBound  
 Returns the upper bound for any dimension of a safe array.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The array dimension for which to get the upper bound.  
  
 *pUBound*  
 Pointer to the location to return the upper bound.  
  
### Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#31](../vs140/codesnippet/CPP/colesafearray-class_6.cpp)]  
  
##  \<a name="colesafearray__lock">\</a>  COleSafeArray::Lock  
 Increments the lock count of an array and place a pointer to the array data in the array descriptor.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 On error, it throws a [COleException](../vs140/coleexception-class.md).  
  
 The pointer in the array descriptor is valid until <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is called. Calls to <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> can be nested; an equal number of calls to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> are required.  
  
 An array cannot be deleted while it is locked.  
  
##  \<a name="colesafearray__operator_lpcvariant">\</a>  COleSafeArray::operator LPCVARIANT  
 Call this casting operator to access the underlying **VARIANT** structure for this <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
##  \<a name="colesafearray__operator_lpvariant">\</a>  COleSafeArray::operator LPVARIANT  
 Call this casting operator to access the underlying **VARIANT** structure for this <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 Note that changing the value in the **VARIANT** structure accessed by the pointer returned by this function will change the value of this <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
##  \<a name="colesafearray__operator__eq">\</a>  COleSafeArray::operator =  
 These overloaded assignment operators copy the source value into this <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 A brief description of each operator follows:  
  
-   **operator =(** *saSrc* **)** Copies an existing <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object into this object.  
  
-   **operator =(** *varSrc***)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> array into this object.  
  
-   **operator =(** <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> **)** Copies the **VARIANT** array object accessed by <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> into this object.  
  
##  \<a name="colesafearray__operator__eq_eq">\</a>  COleSafeArray::operator ==  
 This operator compares two arrays ( **SAFEARRAY**, **VARIANT**, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> arrays) and returns nonzero if they are equal; otherwise 0.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 Two arrays are equal if they have an equal number of dimensions, equal size in each dimension, and equal element values.  
  
##  \<a name="colesafearray__operator__lt__lt_">\</a>  COleSafeArray::operator &lt;&lt;  
 The <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> insertion (<<) operator supports diagnostic dumping and storing of a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object to an archive.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="colesafearray__ptrofindex">\</a>  COleSafeArray::PtrOfIndex  
 Returns a pointer to the element specified by the index values.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 An array of index values that identify an element of the array. All indexes for the element must be specified.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 On return, pointer to the element identified by the values in <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
##  \<a name="colesafearray__putelement">\</a>  COleSafeArray::PutElement  
 Assigns a single element into the array.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Pointer to an array of indexes for each dimension of the array.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to the data to assign to the array. **VT_DISPATCH**, **VT_UNKNOWN**, and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> variant types are pointers and do not require another level of indirection.  
  
### Remarks  
 This function automatically calls the Windows functions                         [SafeArrayLock](https://msdn.microsoft.com/library/windows/desktop/ms221492.aspx) and                         [SafeArrayUnlock](https://msdn.microsoft.com/library/windows/desktop/ms221246.aspx) before and after assigning the element. If the data element is a string, object, or variant, the function copies it correctly, and if the existing element is a string, object, or variant, it is cleared correctly.  
  
 Note that you can have multiple locks on an array, so you can put elements into an array while the array is locked by other operations.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#32](../vs140/codesnippet/CPP/colesafearray-class_7.cpp)]  
  
##  \<a name="colesafearray__redim">\</a>  COleSafeArray::Redim  
 Changes the least significant (rightmost) bound of a safe array.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *psaboundNew*  
 Pointer to a new safe array bound structure containing the new array bound. Only the least significant dimension of an array may be changed.  
  
### Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
##  \<a name="colesafearray__resizeonedim">\</a>  COleSafeArray::ResizeOneDim  
 Changes the number of elements in a one-dimensional <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Number of elements in the one-dimensional safe array.  
  
### Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
  See the example for [COleSafeArray::CreateOneDim](#colesafearray__createonedim).  
  
##  \<a name="colesafearray__unaccessdata">\</a>  COleSafeArray::UnaccessData  
 Decrements the lock count of an array and invalidates the pointer retrieved by <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
  See the example for [COleSafeArray::AccessData](#colesafearray__accessdata).  
  
##  \<a name="colesafearray__unlock">\</a>  COleSafeArray::Unlock  
 Decrements the lock count of an array so it can be freed or resized.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 This function is called after access to the data in an array is finished. On error, it throws a [COleException](../vs140/coleexception-class.md).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant](../vs140/colevariant-class.md)   
 [CRecordset](../vs140/crecordset-class.md)   
 [CDatabase](../vs140/cdatabase-class.md)