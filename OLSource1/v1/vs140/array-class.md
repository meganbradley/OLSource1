---
title: "array Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array class"
ms.assetid: 0832b6c1-40f0-421d-9104-6b1baa0c63a7
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array Class
Represents a data container used to move data to an accelerator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The element type of the data.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The rank of the array.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[array::array Constructor](#array__array_constructor)|Initializes a new instance of the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class.|  
|[array::~array Destructor](#array___dtorarray_destructor)|Destroys the                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[array::copy_to Method](#array__copy_to_method)|Copies the contents of the array to another array.|  
|[array::data Method](#array__data_method)|Returns a pointer to the raw data of the array.|  
|[array::get_accelerator_view Method](#array__get_accelerator_view_method)|Returns the                                         [accelerator_view](../vs140/accelerator_view-class.md) object that represents the location where the array is allocated. This property can be accessed only on the CPU.|  
|[array::get_associated_accelerator_view Method](#array__get_associated_accelerator_view_method)|Gets the second                                         [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the                                          [array](../vs140/array-class.md) object.|  
|[array::get_cpu_access_type Method](#array__get_cpu_access_type_method)|Returns the                                         [access_type](concurrency_namespace__c++_amp__Enumerations) of the array. This method can be accessed only on the CPU.|  
|[array::get_extent Method](#array__get_extent_method)|Returns the                                         [extent](../vs140/extent-class--c---amp-.md) object of the array.|  
|[array::reinterpret_as Method](#array__reinterpret_as_method)|Returns a one-dimensional array that contains all the elements in the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
|[array::section Method](#array__section_method)|Returns a subsection of the                                         [array](../vs140/array-class.md) object that is at the specified origin and, optionally, that has the specified extent.|  
|[array::view_as Method](#array__view_as_method)|Returns an                                         [array_view](../vs140/array_view-class.md) object that is constructed from the                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[array::operator std::vector\<_Value_type> Operator](#array__operator_std__vector_lt__value_type_gt__operator)|Uses                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to implicitly convert the array to a                                         [std::vector](../vs140/vector-class.md) object.|  
|[array::operator() Operator](#array__operator___operator)|Returns the element value that is specified by the parameters.|  
|[array::operator&#91;&#93; Operator](#array__operator_at_operator)|Returns the element that is at the specified index.|  
|[array::operator= Operator](#array__operator_eq_operator)|Copies the contents of the specified                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object into this one.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[array::rank Constant](#array__rank_constant)|Stores the rank of the array.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[array::accelerator_view Data Member](#array__accelerator_view_data_member)|Gets the                                         [accelerator_view](../vs140/accelerator_view-class.md) object that represents the location where the array is allocated. This property can be accessed only on the CPU.|  
|[array::associated_accelerator_view Data Member](#array__associated_accelerator_view_data_member)|Gets the second                                         [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the                                         [array](../vs140/array-class.md) object.|  
|[array::cpu_access_type Data Member](#array__cpu_access_type_data_member)|Gets the                                         [access_type](concurrency_namespace__c++_amp__Enumerations) that represents how the CPU can access the storage of the array.|  
|[array::extent Data Member](#array__extent_data_member)|Gets the extent that defines the shape of the array.|  
  
## Remarks  
 The type                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> represents a dense and regular (not jagged)                 *N*-dimensional array that is located in a specific location, such as an accelerator or the CPU. The data type of the elements in the array is                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, which must be of a type that is compatible with the target accelerator. Although the rank,                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, (of the array is determined statically and is part of the type, the extent of the array is determined by the runtime and is expressed by using class                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 An array can have any number of dimensions, although some functionality is specialized for                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects with rank one, two, and three. If you omit the dimension argument, the default is 1.  
  
 Array data is laid out contiguously in memory. Elements that differ by one in the least significant dimension are adjacent in memory.  
  
 Arrays are logically considered to be value types, because when an array is copied to another array, a deep copy is performed. Two arrays never point to the same data.  
  
 The                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> type is used in several scenarios:  
  
-   As a data container that can be used in computations on an accelerator.  
  
-   As a data container to hold memory on the host CPU (that can be used to copy to and from other arrays).  
  
-   As a staging object to act as a fast intermediary in host-to-device copies.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
##  \<a name="array___dtorarray_destructor">\</a>  array::~array Destructor  
 Destroys the                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="array__accelerator_view_data_member">\</a>  array::accelerator_view Data Member  
 Gets the                 [accelerator_view](../vs140/accelerator_view-class.md) object that represents the location where the array is allocated. This property can be accessed only on the CPU.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="array__array_constructor">\</a>  array::array Constructor  
 Initializes a new instance of the                 [array](../vs140/array-class.md) class. There is no default constructor for                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. All constructors are run on the CPU only. They cannot be executed on a Direct3D target.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An accelerator_view which specifies the preferred target location of the array.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 An                                 [accelerator_view](../vs140/accelerator_view-class.md) object that specifies the location of the array.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The desired                                 [access_type](concurrency_namespace__c++_amp__Enumerations) for the array on the CPU. This parameter has a default value of                                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> leaving the CPU                                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> determination to the runtime. The actual CPU                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for the array can be queried using the                                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The extent in each dimension of the array.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Other data source.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The rank of the section.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
##  \<a name="array__associated_accelerator_view_data_member">\</a>  array::associated_accelerator_view Data Member  
 Gets the second                 [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the                  [array](../vs140/array-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="array__copy_to_method">\</a>  array::copy_to Method  
 Copies the contents of the                 [array](../vs140/array-class.md) to another                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The                                 [array_view](../vs140/array_view-class.md) object to copy to.  
  
##  \<a name="array__cpu_access_type_data_member">\</a>  array::cpu_access_type Data Member  
 Gets the CPU access_type allowed for this array.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="array__data_method">\</a>  array::data Method  
 Returns a pointer to the raw data of the                 [array](../vs140/array-class.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the raw data of the array.  
  
##  \<a name="array__extent_data_member">\</a>  array::extent Data Member  
 Gets the                 [extent](../vs140/extent-class--c---amp-.md) object that defines the shape of the                 [array](../vs140/array-class.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="array__get_accelerator_view_method">\</a>  array::get_accelerator_view Method  
 Returns the                 [accelerator_view](../vs140/accelerator_view-class.md) object that represents the location where the                 [array](../vs140/array-class.md) object is allocated. This property can be accessed only on the CPU.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object that represents the location where the                         [array](../vs140/array-class.md) object is allocated.  
  
##  \<a name="array__get_associated_accelerator_view_method">\</a>  array::get_associated_accelerator_view Method  
 Gets the second                 [accelerator_view](../vs140/accelerator_view-class.md) object that is passed as a parameter when a staging constructor is called to instantiate the                  [array](../vs140/array-class.md) object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The second                         [accelerator_view](../vs140/accelerator_view-class.md) object passed to the staging constructor.  
  
##  \<a name="array__get_cpu_access_type_method">\</a>  array::get_cpu_access_type Method  
 Returns the CPU access_type that's allowed for this array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
##  \<a name="array__get_extent_method">\</a>  array::get_extent Method  
 Returns the                 [extent](../vs140/extent-class--c---amp-.md) object of the                 [array](../vs140/array-class.md).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object of the                         [array](../vs140/array-class.md).  
  
##  \<a name="array__operator_std__vector_lt__value_type_gt__operator">\</a>  array::operator std::vector&lt;_Value_type&gt; Operator  
 Uses                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to implicitly convert the array to a                 [std::vector](../vs140/vector-class.md) object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The data type of the elements of the vector.  
  
### Return Value  
 An object of type                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> that contains a copy of the data that is contained in the array.  
  
##  \<a name="array__operator___operator">\</a>  array::operator() Operator  
 Returns the element value that is specified by the parameters.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The location of the element.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The most significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The least significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The location of the element.  
  
### Return Value  
 The element value specified by the parameters.  
  
##  \<a name="array__operator_at_operator">\</a>  array::operator[] Operator  
 Returns the element that is at the specified index.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The index.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The index.  
  
### Return Value  
 The element that is at the specified index.  
  
##  \<a name="array__operator_eq_operator">\</a>  array::operator= Operator  
 Copies the contents of the specified                 [array](../vs140/array-class.md) object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object to copy from.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object to copy from.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
##  \<a name="array__rank_constant">\</a>  array::rank Constant  
 Stores the rank of the                 [array](../vs140/array-class.md).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="array__section_method">\</a>  array::section Method  
 Returns a subsection of the                 [array](../vs140/array-class.md) object that is at the specified origin and, optionally, that has the specified extent.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The                                 [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section. The origin is 0.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The                                 [index](../vs140/index-class.md) object that specifies the location of the origin. The subsection is the rest of the extent.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The most significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The least significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The rank of the section.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The                                 [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The                                 [index](../vs140/index-class.md) object that specifies the location of the origin.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
### Return Value  
 Returns a subsection of the                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object that is at the specified origin and, optionally, that has the specified extent. When only the                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object is specified, the subsection contains all elements in the associated grid that have indexes that are larger than the indexes of the elements in the                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
##  \<a name="array__view_as_method">\</a>  array::view_as Method  
 Reinterprets this array as an                 [array_view](../vs140/array_view-class.md) of a different rank.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The rank of the                                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object passed as a parameter.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The extent that is used to construct the new                                 [array_view](../vs140/array_view-class.md) object.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The data type of the elements in both the original                                 [array](../vs140/array-class.md) object and the returned                                 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The                         [array_view](../vs140/array_view-class.md) object that is constructed.  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)