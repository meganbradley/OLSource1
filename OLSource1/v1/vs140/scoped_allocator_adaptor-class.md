---
title: "scoped_allocator_adaptor Class"
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
  - "std.scoped_allocator_adaptor"
  - "scoped_allocator_adaptor"
  - "scoped_allocator/std::scoped_allocator_adaptor"
  - "std::scoped_allocator_adaptor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scoped_allocator_adaptor Class"
ms.assetid: 0d9b06a1-9a4a-4669-9470-8805cae48e89
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor Class
Represents a nest of allocators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template class encapsulates a nest of one or more allocators. Each such class has an outermost allocator of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, a synonym for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which is a public base of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is used to allocate memory to be used by a container. You can obtain a reference to this allocator base object by calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The remainder of the nest has type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. An inner allocator is used to allocate memory for elements within a container. You can obtain a reference to the stored object of this type by calling <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is not empty, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> designates a member object. Otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> designates the entire object.  
  
 The nest behaves as if it has arbitrary depth, replicating its innermost encapsulated allocator as needed.  
  
 Several concepts that are not a part of the visible interface aid in describing the behavior of this template class. An *outermost allocator* mediates all calls to the construct and destroy methods. It is effectively defined by the recursive function <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is one of the following.  
  
-   If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is well formed, then <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
-   Otherwise, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Three types are defined for the sake of exposition:  
  
|Type|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The type of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
### Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_allocator_adaptor::scoped_allocator_adaptor Constructor](#scoped_allocator_adaptor__scoped_allocator_adaptor_constructor)|Constructs a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> that is associated with the allocator <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> that is associated with the allocator <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> that is associated with the allocator <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|This type is a synonym for the type of the nested adaptor <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|This type is a synonym for the type of the base allocator <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> associated with the allocator <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The type holds true only if <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> holds true or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> holds true.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|The type holds true only if <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> holds true or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> holds true.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|The type holds true only if <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> holds true or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> holds true.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> associated with the allocator <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> associated with the allocator <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|This type is a synonym for the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> associated with the allocator <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.|  
  
### Structs  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_allocator_adaptor::rebind Struct](#scoped_allocator_adaptor__rebind_struct)|Defines the type <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.|  
  
### Methods  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_allocator_adaptor::allocate Method](#scoped_allocator_adaptor__allocate_method)|Allocates memory by using the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> allocator.|  
|[scoped_allocator_adaptor::construct Method](#scoped_allocator_adaptor__construct_method)|Constructs an object.|  
|[scoped_allocator_adaptor::deallocate Method](#scoped_allocator_adaptor__deallocate_method)|Deallocates objects by using the outer allocator.|  
|[scoped_allocator_adaptor::destroy Method](#scoped_allocator_adaptor__destroy_method)|Destroys a specified object.|  
|[scoped_allocator_adaptor::inner_allocator Method](#scoped_allocator_adaptor__inner_allocator_method)|Retrieves a reference to the stored object of type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.|  
|[scoped_allocator_adaptor::max_size Method](#scoped_allocator_adaptor__max_size_method)|Determines the maximum number of objects that can be allocated by the outer allocator.|  
|[scoped_allocator_adaptor::outer_allocator Method](#scoped_allocator_adaptor__outer_allocator_method)|Retrieves a reference to the stored object of type <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.|  
|[scoped_allocator_adaptor::select_on_container_copy_construction Method](#scoped_allocator_adaptor__select_on_container_copy_construction_method)|Creates a new <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object with each stored allocator object initialized by calling <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> for each corresponding allocator.|  
  
## Requirements  
 **Header:** \<scoped_allocator>  
  
 **Namespace:** std  
  
##  \<a name="scoped_allocator_adaptor__allocate_method">\</a>  scoped_allocator_adaptor::allocate Method  
 Allocates memory by using the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> allocator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The number of elements for which sufficient storage is to be allocated.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer that might assist the allocator object by locating the address of an object allocated prior to the request.  
  
### Return Value  
 The first member function returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. The second member function returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="scoped_allocator_adaptor__construct_method">\</a>  scoped_allocator_adaptor::construct Method  
 Constructs an object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A pointer to the memory location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A list of arguments.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 An object of the first type in a pair.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 An object of the second type in a pair.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 An existing object to be moved or copied.  
  
### Remarks  
 The first method constructs the object at <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is one of the following.  
  
-   If <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> holds false, then <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> holds true, and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> holds true, then <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> holds true, and <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> holds true, then <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 The second method constructs the pair object at <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> modified as in the above list, and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> modified as in the above list.  
  
 The third method behaves the same as <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
 The fourth method behaves the same as <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
 The fifth method behaves the same as <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
 The sixth method behaves the same as <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
##  \<a name="scoped_allocator_adaptor__deallocate_method">\</a>  scoped_allocator_adaptor::deallocate Method  
 Deallocates objects by using the outer allocator.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A pointer to the starting location of the objects to be deallocated.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The number of objects to deallocate.  
  
##  \<a name="scoped_allocator_adaptor__destroy_method">\</a>  scoped_allocator_adaptor::destroy Method  
 Destroys a specified object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 A pointer to the object to be destroyed.  
  
### Return Value  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
##  \<a name="scoped_allocator_adaptor__inner_allocator_method">\</a>  scoped_allocator_adaptor::inner_allocator Method  
 Retrieves a reference to the stored object of type <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the stored object of type <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
##  \<a name="scoped_allocator_adaptor__max_size_method">\</a>  scoped_allocator_adaptor::max_size Method  
 Determines the maximum number of objects that can be allocated by the outer allocator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
##  \<a name="scoped_allocator_adaptor__outer_allocator_method">\</a>  scoped_allocator_adaptor::outer_allocator Method  
 Retrieves a reference to the stored object of type <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the stored object of type <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
##  \<a name="scoped_allocator_adaptor__rebind_struct">\</a>  scoped_allocator_adaptor::rebind Struct  
 Defines the type <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="scoped_allocator_adaptor__scoped_allocator_adaptor_constructor">\</a>  scoped_allocator_adaptor::scoped_allocator_adaptor Constructor  
 Constructs a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 An existing allocator to be used as the outer allocator.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A list of allocators to be used as the inner allocators.  
  
### Remarks  
 The first constructor default constructs its stored allocator objects. Each of the next three constructors constructs its stored allocator objects from the corresponding objects in <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>. The last constructor constructs its stored allocator objects from the corresponding arguments in the argument list.  
  
##  \<a name="scoped_allocator_adaptor__select_on_container_copy_construction_method">\</a>  scoped_allocator_adaptor::select_on_container_copy_construction Method  
 Creates a new <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object with each stored allocator object initialized by calling <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> for each corresponding allocator.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 This method effectively returns <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. The result is a new <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object with each stored allocator object initialized by calling <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> for the corresponding allocator <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)