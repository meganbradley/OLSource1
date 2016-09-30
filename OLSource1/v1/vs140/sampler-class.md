---
title: "sampler Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 9a6a9807-497d-402d-b092-8c4d86275b80
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sampler Class
The sampler class aggregates sampling configuration information to be used for texture sampling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[sampler::sampler Constructor](#sampler__sampler_constructor)|Overloaded. Constructs a sampler instance.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[sampler::get_address_mode Method](#sampler__get_address_mode_method)|Returns the                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that’s associated with the sampler object.|  
|[sampler::get_border_color Method](#sampler__get_border_color_method)|Returns the border color that’s associated with the sampler object.|  
|[sampler::get_filter_mode Method](#sampler__get_filter_mode_method)|Returns the                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that’s associated with the sampler object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[sampler::operator= Operator](#sampler__operator_eq_operator)|Overloaded. Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[sampler::address_mode Data Member](#sampler__address_mode_data_member)|Gets the address mode of the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[sampler::border_color Data Member](#sampler__border_color_data_member)|Gets the border color of the                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[sampler::filter_mode Data Member](#sampler__filter_mode_data_member)|Gets the filter mode of the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
##  \<a name="sampler__sampler_constructor">\</a>  sampler::sampler Constructor  
 Constructs an instance of the                 [sampler Class](../vs140/sampler-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The filter mode to be used in sampling.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The addressing mode to be used in sampling for all dimensions.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The border color to be used if the address mode is address_border. The default value is                                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [5] Copy Constructor  
 The                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to copy into the new                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> instance.  
  
 [6] Move Constructor  
 The                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object to move into the new                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> instance.  
  
##  \<a name="sampler__address_mode_data_member">\</a>  sampler::address_mode Data Member  
 Gets the address mode of the                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="sampler__border_color_data_member">\</a>  sampler::border_color Data Member  
 Gets the border color of the                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="sampler__filter_mode_data_member">\</a>  sampler::filter_mode Data Member  
 Gets the filter mode of the                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="sampler__get_address_mode_method">\</a>  sampler::get_address_mode Method  
 Returns the filter mode that’s configured for this                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The address mode that’s configured for the sampler.  
  
##  \<a name="sampler__get_border_color_method">\</a>  sampler::get_border_color Method  
 Returns the border color that’s configured for this                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A float_4 that contains the border color.  
  
##  \<a name="sampler__get_filter_mode_method">\</a>  sampler::get_filter_mode Method  
 Returns the filter mode that’s configured for this                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The filter mode that’s configured for the sampler.  
  
##  \<a name="sampler__operator_eq_operator">\</a>  sampler::operator= Operator  
 Assigns the value of another sampler object to an existing sampler.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [1] Copy Assignment Operator  
 The                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object to copy into this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 [2] Move Assignment Operator  
 The                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object to move into this                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to this sampler instance.  
  
## See Also  
 [concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)