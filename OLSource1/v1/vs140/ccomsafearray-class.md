---
title: "CComSafeArray Class"
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
  - "CComSafeArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeArray class"
ms.assetid: ee349aef-33db-4c85-bd08-5d86a3c9d53a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray Class
This class is a wrapper for the **SAFEARRAY** structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of data to be stored in the array.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeArray::CComSafeArray](../vs140/ccomsafearray--ccomsafearray.md)|The constructor.|  
|[CComSafeArray::~CComSafeArray](../vs140/ccomsafearray--~ccomsafearray.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeArray::Add](../vs140/ccomsafearray--add.md)|Adds one or more elements, or a **SAFEARRAY** structure, to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[CComSafeArray::Attach](../vs140/ccomsafearray--attach.md)|Attaches a **SAFEARRAY** structure to a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::CopyFrom](../vs140/ccomsafearray--copyfrom.md)|Copies the contents of a **SAFEARRAY** structure into the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::CopyTo](../vs140/ccomsafearray--copyto.md)|Creates a copy of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::Create](../vs140/ccomsafearray--create.md)|Creates a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::Destroy](../vs140/ccomsafearray--destroy.md)|Destroys a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::Detach](../vs140/ccomsafearray--detach.md)|Detaches a **SAFEARRAY** from a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md)|Retrieves a single element from a single-dimensional array.|  
|[CComSafeArray::GetCount](../vs140/ccomsafearray--getcount.md)|Returns the number of elements in the array.|  
|[CComSafeArray::GetDimensions](../vs140/ccomsafearray--getdimensions.md)|Returns the number of dimensions in the array.|  
|[CComSafeArray::GetLowerBound](../vs140/ccomsafearray--getlowerbound.md)|Returns the lower bound for a given dimension of the array.|  
|[CComSafeArray::GetSafeArrayPtr](../vs140/ccomsafearray--getsafearrayptr.md)|Returns the address of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> data member.|  
|[CComSafeArray::GetType](../vs140/ccomsafearray--gettype.md)|Returns the type of data stored in the array.|  
|[CComSafeArray::GetUpperBound](../vs140/ccomsafearray--getupperbound.md)|Returns the upper bound for any dimension of the array.|  
|[CComSafeArray::IsSizable](../vs140/ccomsafearray--issizable.md)|Tests if a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object can be resized.|  
|[CComSafeArray::MultiDimGetAt](../vs140/ccomsafearray--multidimgetat.md)|Retrieves a single element from a multidimensional array.|  
|[CComSafeArray::MultiDimSetAt](../vs140/ccomsafearray--multidimsetat.md)|Sets the value of an element in a multidimensional array.|  
|[CComSafeArray::Resize](../vs140/ccomsafearray--resize.md)|Resizes a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md)|Sets the value of an element in a single-dimensional array.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeArray::operator LPSAFEARRAY](../vs140/ccomsafearray--operator-lpsafearray.md)|Casts a value to a **SAFEARRAY** pointer.|  
|[CComSafeArray::operator &#91;&#93;](../vs140/ccomsafearray--operator.md)|Retrieves an element from the array.|  
|[CComSafeArray::operator =](../vs140/ccomsafearray--operator-=.md)|Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeArray::m_psa](../vs140/ccomsafearray--m_psa.md)|This data member holds the address of the **SAFEARRAY** structure.|  
  
## Remarks  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> provides a wrapper for the [SAFEARRAY Data Type](assetId:///9ec8025b-4763-4526-ab45-390c5d8b3b1e) class, making it a simple matter to create and manage single- and multidimensional arrays of almost any of the VARIANT-supported types.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> simplifies passing arrays between processes, and in addition provides extra security by checking array index values against upper and lower bounds.  
  
 The lower bound of a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can start at any user-defined value; however, arrays that are accessed through C++ should use a lower bound of 0. Other languages such as Visual Basic may use other bounding values (for example, -10 to 10).  
  
 Use [CComSafeArray::Create](../vs140/ccomsafearray--create.md) to create a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object, and [CComSafeArray::Destroy](../vs140/ccomsafearray--destroy.md) to delete it.  
  
 A <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> can contain the following subset of VARIANT data types:  
  
|VARTYPE|Description|  
|-------------|-----------------|  
|VT_I1|char|  
|VT_I2|short|  
|VT_I4|int|  
|VT_I4|long|  
|VT_I8|longlong|  
|VT_UI1|byte|  
|VT_UI2|ushort|  
|VT_UI4|uint|  
|VT_UI4|ulong|  
|VT_UI8|ulonglong|  
|VT_R4|float|  
|VT_R8|double|  
|VT_DECIMAL|decimal pointer|  
|VT_VARIANT|variant pointer|  
|VT_CY|Currency data type|  
  
## Requirements  
 **Header:** atlsafe.h  
  
## Example  
 [!code[NVC_ATL_Utilities#75](../vs140/codesnippet/CPP/ccomsafearray-class_1.cpp)]  
  
##  \<a name="ccomsafearray__add">\</a>  CComSafeArray::Add  
 Adds one or more elements, or a **SAFEARRAY** structure, to a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** object.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The number of objects to add to the array.  
  
 *pT*  
 A pointer to one or more objects to be added to the array.  
  
 *t*  
 A reference to the object to be added to the array.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Indicates whether a copy of the data should be created. The default value is **TRUE**.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The new objects are appended to the end of the existing **SAFEARRAY** object. Adding an object to a multidimensional **SAFEARRAY** object is not supported. When adding an existing array of objects, both arrays must contain elements of the same type.  
  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> flag is taken into account when elements of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or **VARIANT** are added to an array. The default value of **TRUE** ensures that a new copy is made of the data when the element is added to the array.  
  
##  \<a name="ccomsafearray__attach">\</a>  CComSafeArray::Attach  
 Attaches a **SAFEARRAY** structure to a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to the **SAFEARRAY** structure.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Attaches a **SAFEARRAY** structure to a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object, making the existing <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> methods available.  
  
##  \<a name="ccomsafearray__ccomsafearray">\</a>  CComSafeArray::CComSafeArray  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A **SAFEARRAYBOUND** structure.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The lower bound value; that is, the index of the first element in the array.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAYBOUND** structure.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The count of dimensions in the array.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A reference to a **SAFEARRAY** structure or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object. In either case the constructor uses this reference to make a copy of the array, so the array is not referenced after construction.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** structure. The constructor uses this address to make a copy of the array, so the array is not referenced after construction.  
  
### Remarks  
 Creates a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
##  \<a name="ccomsafearray___dtorccomsafearray">\</a>  CComSafeArray::~CComSafeArray  
 The destructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="ccomsafearray__copyfrom">\</a>  CComSafeArray::CopyFrom  
 Copies the contents of a **SAFEARRAY** structure into the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Pointer to the **SAFEARRAY** to copy.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method copies the contents of a **SAFEARRAY** into the current <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object. The existing contents of the array are replaced.  
  
##  \<a name="ccomsafearray__copyto">\</a>  CComSafeArray::CopyTo  
 Creates a copy of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A pointer to a location in which to create the new **SAFEARRAY**.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method copies the contents of a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object into a **SAFEARRAY** structure.  
  
##  \<a name="ccomsafearray__create">\</a>  CComSafeArray::Create  
 Creates a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAYBOUND** object.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The number of dimensions in the array.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The lower bound value; that is, the index of the first element in the array.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 A <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object can be created from an existing **SAFEARRAYBOUND** structure and the number of dimensions, or by specifying the number of elements in the array and the lower bound. If the array is to be accessed from Visual C++, the lower bound should be 0. Other languages may allow other values for the lower bound (for example, Visual Basic supports arrays with elements with a range such as -10 to 10).  
  
##  \<a name="ccomsafearray__destroy">\</a>  CComSafeArray::Destroy  
 Destroys a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Destroys an existing <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object and all of the data it contains.  
  
##  \<a name="ccomsafearray__detach">\</a>  CComSafeArray::Detach  
 Detaches a **SAFEARRAY** from a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to a **SAFEARRAY** object.  
  
### Remarks  
 This method detaches the **SAFEARRAY** object from the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object.  
  
##  \<a name="ccomsafearray__getat">\</a>  CComSafeArray::GetAt  
 Retrieves a single element from a single-dimensional array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The index number of the value in the array to return.  
  
### Return Value  
 Returns a reference to the required array element.  
  
##  \<a name="ccomsafearray__getcount">\</a>  CComSafeArray::GetCount  
 Returns the number of elements in the array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The array dimension.  
  
### Return Value  
 Returns the number of elements in the array.  
  
### Remarks  
 When used with a multidimensional array, this method will return the number of elements in a specific dimension only.  
  
##  \<a name="ccomsafearray__getdimensions">\</a>  CComSafeArray::GetDimensions  
 Returns the number of dimensions in the array.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of dimensions in the array.  
  
##  \<a name="ccomsafearray__getlowerbound">\</a>  CComSafeArray::GetLowerBound  
 Returns the lower bound for a given dimension of the array.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The array dimension for which to get the lower bound. If omitted, the default is 0.  
  
### Return Value  
 Returns the lower bound.  
  
### Remarks  
 If the lower bound is 0, this indicates a C-like array whose first element is element number 0. In the event of an error, for example, an invalid dimension argument, this method calls <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
##  \<a name="ccomsafearray__getsafearrayptr">\</a>  CComSafeArray::GetSafeArrayPtr  
 Returns the address of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the [CComSafeArray::m_psa](../vs140/ccomsafearray--m_psa.md) data member.  
  
##  \<a name="ccomsafearray__gettype">\</a>  CComSafeArray::GetType  
 Returns the type of data stored in the array.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the type of data stored in the array, which could be any of the following types:  
  
|VARTYPE|Description|  
|-------------|-----------------|  
|VT_I1|char|  
|VT_I2|short|  
|VT_I4|int|  
|VT_I4|long|  
|VT_I8|longlong|  
|VT_UI1|byte|  
|VT_UI2|ushort|  
|VT_UI4|uint|  
|VT_UI4|ulong|  
|VT_UI8|ulonglong|  
|VT_R4|float|  
|VT_R8|double|  
|VT_DECIMAL|decimal pointer|  
|VT_VARIANT|variant pointer|  
|VT_CY|Currency data type|  
  
##  \<a name="ccomsafearray__getupperbound">\</a>  CComSafeArray::GetUpperBound  
 Returns the upper bound for any dimension of the array.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The array dimension for which to get the upper bound. If omitted, the default is 0.  
  
### Return Value  
 Returns the upper bound. This value is inclusive, the maximum valid index for this dimension.  
  
### Remarks  
 In the event of an error, for example, an invalid dimension argument, this method calls <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
##  \<a name="ccomsafearray__issizable">\</a>  CComSafeArray::IsSizable  
 Tests if a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object can be resized.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> can be resized,                         **false** if it cannot.  
  
##  \<a name="ccomsafearray__m_psa">\</a>  CComSafeArray::m_psa  
 Holds the address of the **SAFEARRAY** structure accessed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="ccomsafearray__multidimgetat">\</a>  CComSafeArray::MultiDimGetAt  
 Retrieves a single element from a multidimensional array.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Pointer to a vector of indexes for each dimension in the array. The leftmost (most significant) dimension is <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>[0] *.*  
  
 *t*  
 A reference to the data returned.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="ccomsafearray__multidimsetat">\</a>  CComSafeArray::MultiDimSetAt  
 Sets the value of an element in a multidimensional array.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Pointer to a vector of indexes for each dimension in the array. The rightmost (least significant) dimension is <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>[0].  
  
 *T*  
 Specifies the value of the new element.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This is a multidimensional version of [CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md).  
  
##  \<a name="ccomsafearray__operator__at">\</a>  CComSafeArray::operator []  
 Retrieves an element from the array.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *lIndex, nIndex*  
 The index number of the required element in the array.  
  
### Return Value  
 Returns the appropriate array element.  
  
### Remarks  
 Performs a similar function to [CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md), however this operator only works with single-dimensional arrays.  
  
##  \<a name="ccomsafearray__operator__eq">\</a>  CComSafeArray::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** object.  
  
### Return Value  
 Returns the type of data stored in the array.  
  
##  \<a name="ccomsafearray__operator_lpsafearray">\</a>  CComSafeArray::operator LPSAFEARRAY  
 Casts a value to a **SAFEARRAY** pointer.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Casts a value to a **SAFEARRAY** pointer.  
  
##  \<a name="ccomsafearray__resize">\</a>  CComSafeArray::Resize  
 Resizes a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAYBOUND** structure that contains information on the number of elements and the lower bound of an array.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The requested number of objects in the resized array.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The lower bound.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method only resizes the rightmost dimension. It will not resize arrays that return **IsResizable** as **false**.  
  
##  \<a name="ccomsafearray__setat">\</a>  CComSafeArray::SetAt  
 Sets the value of an element in a single-dimensional array.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The index number of the array element to set.  
  
 *t*  
 The new value of the specified element.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Indicates whether a copy of the data should be created. The default value is **TRUE**.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> flag is taken into account when elements of type <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> or **VARIANT** are added to an array. The default value of **TRUE** ensures that a new copy is made of the data when the element is added to the array.  
  
## See Also  
 [SAFEARRAY Data Type](assetId:///9ec8025b-4763-4526-ab45-390c5d8b3b1e)   
 [CComSafeArray::Create](../vs140/ccomsafearray--create.md)   
 [CComSafeArray::Destroy](../vs140/ccomsafearray--destroy.md)   
 [Class Overview](../vs140/atl-class-overview.md)