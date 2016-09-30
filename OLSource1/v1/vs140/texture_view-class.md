---
title: "texture_view Class"
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
ms.assetid: 6ec2e289-1626-4727-9592-07981cf1d27d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view Class
Provides read access and write access to a texture.             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can only be used to read textures whose value type is             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or             <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that have default 32-bit bpse. To read other texture formats, use             <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The type of the elements in the texture aggregate.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The rank of the                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The type of the elements in the texture aggregates.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The type of the coordinate used to specify a texel in the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>—that is, a                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> that has the same rank as the associated texture that has a value type of                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The return type used for gather operations—that is, a rank 4                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> that holds the four homogenous color components gathered from the four texel values sampled.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[texture_view::texture_view Constructor](#texture_view__texture_view_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> instance.|  
|[texture_view::~texture_view Destructor](#texture_view___dtortexture_view_destructor)|Destroys the                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instance.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[texture_view::gather_alpha Method](#texture_view__gather_alpha_method)|Overloaded. Samples the texture at the specified coordinates by using the specified sampling configuration and returns the alpha (w) components of the four sampled texels.|  
|[texture_view::gather_blue Method](#texture_view__gather_blue_method)|Overloaded. Samples the texture at the specified coordinates by using the specified sampling configuration and returns the blue (z) components of the four sampled texels.|  
|[texture_view::gather_green Method](#texture_view__gather_green_method)|Overloaded. Samples the texture at the specified coordinates by using the specified sampling configuration and returns the green (y) components of the four sampled texels.|  
|[texture_view::gather_red Method](#texture_view__gather_red_method)|Overloaded. Samples the texture at the specified coordinates by using the specified sampling configuration and returns the red (x) components of the four sampled texels.|  
|[texture_view::get Method](#texture_view__get_method)|Overloaded. Gets the element value by index.|  
|[texture_view::sample Method](#texture_view__sample_method)|Overloaded. Samples the texture at the specified coordinates and level of detail by using the specified sampling configuration.|  
|[texture_view::set Method](#texture_view__set_method)|Sets the value of an element by index.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[texture_view::operator() Operator](#texture_view__operator___operator)|Overloaded. Gets the element value by index.|  
|[texture_view::operator&#91;&#93; Operator](#texture_view__operator_at_operator)|Overloaded. Gets the element value by index.|  
|[texture_view::operator= Operator](#texture_view__operator_eq_operator)|Overloaded. Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[texture_view::value_type Data Member](#texture_view__value_type_data_member)|The value type of the elements of the                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
##  \<a name="texture_view___dtortexture_view_destructor">\</a>  texture_view::~texture_view Destructor  
 Destroys the                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> instance.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="texture_view__texture_view_constructor">\</a>  texture_view::texture_view Constructor  
 Constructs a                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> instance.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [1, 2] Constructor  
 The                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> on which the writable                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is created.  
  
 [3, 4] Constructor  
 The                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> on which the non-writable                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is created.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 [5] Copy Constructor  
 The source writable                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 [6, 7] Copy Constructor  
 The source non-writable                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The specific mipmap level on the source                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> that this writeable                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> binds to. The default value is 0, which represents the top level (most detailed) mip level.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Top level (most detailed) mip level for the view, relative to the specified                                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The number of mipmap levels accessible through the                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="texture_view__gather_red_method">\</a>  texture_view::gather_red Method  
 Samples the texture at the specified coordinates by using the specified sampling configuration and returns the red (x) components of the four sampled texels.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The address mode to use to sample the                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
### Return Value  
 A rank 4 short vector containing the red (x) component of the 4 sampled texel values.  
  
##  \<a name="texture_view__gather_green_method">\</a>  texture_view::gather_green Method  
 Samples the texture at the specified coordinates by using the specified sampling configuration and returns the green (y) components of the four sampled texels.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The address mode to use to sample the                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
### Return Value  
 A rank 4 short vector containing the green (y) component of the 4 sampled texel values.  
  
##  \<a name="texture_view__gather_blue_method">\</a>  texture_view::gather_blue Method  
 Samples the texture at the specified coordinates by using the specified sampling configuration and returns the blue (z) components of the four sampled texels.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The address mode to use to sample the                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
### Return Value  
 A rank 4 short vector containing the red (x) component of the 4 sampled texel values.  
  
##  \<a name="texture_view__gather_alpha_method">\</a>  texture_view::gather_alpha Method  
 Samples the texture at the specified coordinates by using the specified sampling configuration and returns the alpha (w) components of the four sampled texels.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The address mode to use to sample the                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the                                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
### Return Value  
 A rank 4 short vector containing the alpha (w) component of the 4 sampled texel values.  
  
##  \<a name="texture_view__get_method">\</a>  texture_view::get Method  
 Gets the value of the element at the specified index.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The index of the element to get, possibly multi-dimensional.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The mipmap level from which we should get the value. The default value 0 represents the most detailed mipmap level.  
  
### Return Value  
 The value of the element.  
  
##  \<a name="texture_view__operator_eq_operator">\</a>  texture_view::operator= Operator  
 Assigns a view of the same texture as the specified                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to this                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> instance.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 [1, 2] Copy Constructor  
 A writable                                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object.  
  
 [3] Copy Constructor  
 A non-writable                                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> instance.  
  
##  \<a name="texture_view__operator_at_operator">\</a>  texture_view::operator[] Operator  
 Returns the element value by index.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The index, possibly multi-dimensional.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The one-dimensional index.  
  
### Return Value  
 The element value indexed by                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="texture_view__operator___operator">\</a>  texture_view::operator() Operator  
 Returns the element value by index.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The index, possibly multi-dimensional.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The most-significant component of the index.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the index.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The least-significant component of the index.  
  
### Return Value  
 The element value indexed by                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
##  \<a name="texture_view__sample_method">\</a>  texture_view::sample Method  
 Samples the texture at the specified coordinates and level of detail by using the specified sampling configuration.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The filter mode to use to sample the texture_view. The filter mode is the same for the minimization, maximization, and mipmap filters.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The address mode to use to sample the texture_view. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the texture_view.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between texel values.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The value specifies the mipmap level to sample from. Fractional values are used to interpolate between two mipmap levels. The default level of detail is 0, which represents the most detailed mip level.  
  
### Return Value  
 The interpolated sample value.  
  
##  \<a name="texture_view__set_method">\</a>  texture_view::set Method  
 Sets the value of the element at the specified index to the specified value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The index of the element to set, possibly multi-dimensional.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The value to set the element to.  
  
##  \<a name="texture_view__value_type_data_member">\</a>  texture_view::value_type Data Member  
 The value type of the elements of the texture_view.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)