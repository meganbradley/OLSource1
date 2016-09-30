---
title: "array_view Class"
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
  - "amp/Concurrency::array_view"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array_view class"
ms.assetid: 7e7ec9bc-05a2-4372-b05d-752b50006c5a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view Class
Represents an N-dimensional view over the data held in another container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The data type of the elements in the                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The rank of the                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[array_view::array_view Constructor](#array_view__array_view_constructor)|Initializes a new instance of the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class. There is no default constructor for                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. All constructors are restricted to run on the CPU only and cannot be executed on a Direct3D target.|  
|[array_view::~array_view Destructor](#array_view___dtorarray_view_destructor)|Destroys the                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[array_view::copy_to Method](#array_view__copy_to_method)|Copies the contents of the                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object to the specified destination by calling                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|[array_view::data Method](#array_view__data_method)|Returns a pointer to the raw data of the                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
|[array_view::discard_data](#array_view__discard_data_method)|Discards the current data underlying this view.|  
|[array_view::get_extent Method](#array_view__get_extent_method)|Returns the extent object of the array_view object.|  
|[array_view::get_ref Method](#array_view__get_ref_method)|Returns a reference to the indexed element.|  
|[Array_view::get_source_accelerator_view Method](#array_view__get_source_accelerator_view_method)|Returns the                                         [accelerator_view](../vs140/accelerator_view-class.md) where the data source of the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is located.|  
|[array_view::refresh Method](#array_view__refresh_method)|Notifies the                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object that its bound memory has been modified outside the                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> interface. A call to this method renders all cached information stale.|  
|[array_view::reinterpret_as Method](#array_view__reinterpret_as_method)|Returns a one-dimensional array that contains all the elements in the                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[array_view::section Method](#array_view__section_method)|Returns a subsection of the                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object that's at the specified origin and, optionally, that has the specified extent.|  
|[array_view::synchronize Method](#array_view__synchronize_method)|Synchronizes any modifications made to the                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object back to its source data.|  
|[array_view::synchronize_async Method](#array_view__synchronize_async_method)|Asynchronously synchronizes any modifications made to the                                         [array_view](../vs140/array_view-class.md) object back to its source data.|  
|[array_view::synchronize_to Method](#array_view__synchronize_to_method)|Synchronizes any modifications made to the                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to the specified                                         [accelerator_view](../vs140/accelerator_view-class.md).|  
|[Array_view::synchronize_to_async Method](#array_view__synchronize_to_async_method)|Asynchronously synchronizes any modifications made to the                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object to the specified                                         [accelerator_view](../vs140/accelerator_view-class.md).|  
|[array_view::view_as Method](#array_view__view_as_method)|Produces an                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object of a different rank using this                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object’s data.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[array_view::operator() Operator](#array_view__operator___operator)|Returns the value of the element that is specified by the parameter or parameters.|  
|[array_view::operator&#91;&#93; Operator](#array_view__operator_at_operator)|Returns the element that is specified by the parameters.|  
|[array_view::operator= Operator](#array_view__operator_eq_operator)|Copies the contents of the specified                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object into this one.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[array_view::rank Constant](#array_view__rank_constant)|Stores the rank of the                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[array_view::extent Data Member](#array_view__extent_data_member)|Gets the                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object that defines the shape of the                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.|  
|[array_view::source_accelerator_view Data Member](#array_view__source_accelerator_view_data_member)|Gets the                                         [accelerator_view](../vs140/accelerator_view-class.md) where the data source of the                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is located|  
|[array_view::value_type Data Member](#array_view__value_type_data_member)|The value type of the                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and the bound array.|  
  
## Remarks  
 The                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> class represents a view into the data that is contained in an                 [array](../vs140/array-class.md) object or a subsection of an                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
 You can access the                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object where the source data is located (locally) or on a different accelerator or a coherence domain (remotely). When you access the object remotely, views are copied and cached as necessary. Except for the effects of automatic caching,                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> objects have a performance profile similar to that of                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> objects. There is a small performance penalty when you access the data through views.  
  
 There are three remote usage scenarios:  
  
-   A view to a system memory pointer is passed by means of a                         [parallel_for_each](concurrency_namespace__c++_amp__Functions) call to an accelerator and accessed on the accelerator.  
  
-   A view to an array located on an accelerator is passed by means of a                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> call to another accelerator and is accessed there.  
  
-   A view to an array located on an accelerator is accessed on the CPU.  
  
 In any one of these scenarios, the referenced views are copied by the runtime to the remote location and, if modified by the calls to the                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object, are copied back to the local location. The runtime might optimize the process of copying changes back, might copy only changed elements, or might copy unchanged portions also. Overlapping                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> objects on one data source are not guaranteed to maintain referential integrity in a remote location.  
  
 You must synchronize any multithreaded access to the same data source.  
  
 The runtime makes the following guarantees regarding the caching of data in                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> objects:  
  
-   All well-synchronized accesses to an                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object and an                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object on it in program order obey a serial happens-before relationship.  
  
-   All well-synchronized accesses to overlapping                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects on the same accelerator on a single                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object are aliased through the                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object. They induce a total occurs-before relationship which obeys program order. There is no caching. If the                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> objects are executing on different accelerators, the order of access is undefined, creating a race condition.  
  
 When you create an                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object using a pointer in system memory, you must change the view                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object only through the                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> pointer. Alternatively, you must call                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> on one of the                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> objects that are attached to the system pointer, if the underlying native memory is changed directly, instead of through the                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
 Either action notifies the                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object that the underlying native memory is changed and that any copies that are located on an accelerator are outdated. If you follow these guidelines, the pointer-based views are identical to those provided to views of data-parallel arrays.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
##  \<a name="array_view___dtorarray_view_destructor">\</a>  array_view::~array_view Destructor  
 Destroys the                 [array_view](../vs140/array_view-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="array_view__array_view_constructor">\</a>  array_view::array_view Constructor  
 Initializes a new instance of the                 [array_view](../vs140/array_view-class.md) class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The element type of a C-style array from which data is supplied.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A template argument that must specify a linear container that supports                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> members.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The extent in each dimension of this                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> from which to initialize the new                                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The size of a C-style array from which data is supplied.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to the source data that will be copied into the new array.  
  
##  \<a name="array_view__copy_to_method">\</a>  array_view::copy_to Method  
 Copies the contents of the                 [array_view](../vs140/array_view-class.md) object to the specified destination object by calling                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The object to copy to.  
  
##  \<a name="array_view__data_method">\</a>  array_view::data Method  
 Returns a pointer to the raw data of the                 [array_view](../vs140/array_view-class.md).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the raw data of the                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
##  \<a name="array_view__discard_data_method">\</a>  array_view::discard_data Method  
 Discards the current data underlying this view. This is an optimization hint to the runtime used to avoid copying the current contents of the view to a target                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> that it is accessed on, and its use is recommended if the existing content is not needed. This method is a no-op when used in a restrict(amp) context  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="array_view__extent_data_member">\</a>  array_view::extent Data Member  
 Gets the                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object that defines the shape of the                 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="array_view__get_extent_method">\</a>  array_view::get_extent Method  
 Returns the                 [extent](../vs140/extent-class--c---amp-.md) object of the                 [array_view](../vs140/array_view-class.md) object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object of the                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object  
  
##  \<a name="array_view__get_ref_method">\</a>  array_view::get_ref Method  
 Get a reference to the element indexed by _Index. Unlike the other indexing operators for accessing the array_view on the CPU, this method does not implicitly synchronize this array_view's contents to the CPU. After accessing the array_view on a remote location or performing a copy operation involving this array_view users are responsible to explicitly synchronize the array_view to the CPU before calling this method. Failure to do so results in undefined behavior.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The index.  
  
### Return Value  
 Reference to the element indexed by _Index  
  
##  \<a name="array_view__get_source_accelerator_view_method">\</a>  array_view::get_source_accelerator_view Method  
 Returns the accelerator_view where the data source of the array_view is located. If the array_view does not have a data source, this API throws a runtime_exception  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
  
##  \<a name="array_view__operator___operator">\</a>  array_view::operator() Operator  
 Returns the value of the element that is specified by the parameter or parameters.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The location of the element.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The index in the first dimension.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The index in the second dimension.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The index in the third dimension.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The location of the element.  
  
### Return Value  
 The value of the element that is specified by the parameter or parameters.  
  
##  \<a name="array_view__operator_at_operator">\</a>  array_view::operator[] Operator  
 Returns the element that is specified by the parameters.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The index.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The index.  
  
### Return Value  
 The value of the element at the index, or an                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> projected on the most-significant dimension.  
  
##  \<a name="array_view__operator_eq_operator">\</a>  array_view::operator= Operator  
 Copies the contents of the specified                 [array_view](../vs140/array_view-class.md) object to this one.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object to copy from.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
##  \<a name="array_view__rank_constant">\</a>  array_view::rank Constant  
 Stores the rank of the                 [array_view](../vs140/array_view-class.md) object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="array_view__refresh_method">\</a>  array_view::refresh Method  
 Notifies the                 [array_view](../vs140/array_view-class.md) object that its bound memory has been modified outside the                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> interface. A call to this method renders all cached information stale.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="array_view__section_method">\</a>  array_view::section Method  
 Returns a subsection of the                 [array_view](../vs140/array_view-class.md) object that's at the specified origin and, optionally, that has the specified extent.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The                                 [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section. The origin is 0.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The                                 [index](../vs140/index-class.md) object that specifies the location of the origin. The subsection is the rest of the extent.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The most significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The least significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The rank of the section.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The                                 [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The                                 [index](../vs140/index-class.md) object that specifies the location of the origin.  
  
### Return Value  
 A subsection of the                         <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object that's at the specified origin and, optionally, that has the specified extent. When only the                         <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object is specified, the subsection contains all elements in the associated extent that have indexes that are larger than the indexes of the elements in the                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
##  \<a name="array_view__source_accelerator_view_data_member">\</a>  array_view::source_accelerator_view Data Member  
 Gets the source accelerator_view that this array_view is associated with.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="array_view__synchronize_method">\</a>  array_view::synchronize Method  
 Synchronizes any modifications made to the                 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> object back to its source data.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The intended                                 [access_type](concurrency_namespace__c++_amp__Enumerations) on the target                                 [accelerator_view](../vs140/accelerator_view-class.md). This parameter has a default value of                                 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
##  \<a name="array_view__synchronize_async_method">\</a>  array_view::synchronize_async Method  
 Asynchronously synchronizes any modifications made to the                 [array_view](../vs140/array_view-class.md) object back to its source data.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The intended                                 [access_type](concurrency_namespace__c++_amp__Enumerations) on the target                                 [accelerator_view](../vs140/accelerator_view-class.md). This parameter has a default value of                                 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Return Value  
 A future upon which to wait for the operation to complete.  
  
##  \<a name="array_view__synchronize_to_method">\</a>  array_view::synchronize_to Method  
 Synchronizes any modifications made to this array_view to the specified accelerator_view.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The target accelerator_view to synchronize to.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The desired access_type on the target accelerator_view. This parameter has a default value of access_type_read.  
  
##  \<a name="array_view__synchronize_to_async_method">\</a>  array_view::synchronize_to_async Method  
 Asynchronously synchronizes any modifications made to this array_view to the specified accelerator_view.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The target accelerator_view to synchronize to.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The desired access_type on the target accelerator_view. This parameter has a default value of access_type_read.  
  
### Return Value  
 A future upon which to wait for the operation to complete.  
  
##  \<a name="array_view__value_type_data_member">\</a>  array_view::value_type Data Member  
 The value type of the array_view and the bound array.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="array_view__view_as_method">\</a>  array_view::view_as Method  
 Reinterprets this                 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> as an                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> of a different rank.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The rank of the new                                 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The reshaping                                 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The data type of the elements in both the original                                 [array](../vs140/array-class.md) object and the returned                                 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The                         [array_view](../vs140/array_view-class.md) object that is constructed.  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)