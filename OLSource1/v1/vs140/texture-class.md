---
title: "texture Class"
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
  - "amp_graphics/Concurrency::graphics::texture"
dev_langs: 
  - "C++"
ms.assetid: 16e85d4d-e80a-474a-995d-8bf63fbdf34c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture Class
A texture is a data aggregate on an             <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the extent domain. It is a collection of variables, one for each element in an extent domain. Each variable holds a value corresponding to C++ primitive type (            <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>), a scalar type (            <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or             <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>), or a short vector type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Scalar types.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Value types.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[texture::texture Constructor](#texture__texture_constructor)|Initializes a new instance of the                                         [texture](../vs140/texture-class.md) class.|  
|[texture::~texture Destructor](#texture___dtortexture_destructor)|Destroys the                                         [texture](../vs140/texture-class.md) object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[texture::copy_to Method](#texture__copy_to_method)|Copies the                                         [texture](../vs140/texture-class.md) object to the destination, by doing a deep copy.|  
|[texture::data Method](#texture__data_method)|Returns a CPU pointer to the raw data of this texture.|  
|[texture::get Method](#texture__get_method)|Returns the value of the element at the specified index.|  
|[Texture::get_associated_accelerator_view Data Member](#texture__get_associated_accelerator_view_method)|Returns the                                         [accelerator_view](../vs140/accelerator_view-class.md) that is the preferred target for this texture to be copied to.|  
|[texture::get_depth_pitch Method](#texture__get_depth_pitch_method)|Returns the number of bytes between each depth slice in a 3D staging texture on the CPU.|  
|[texture::get_row_pitch Method](#texture__get_row_pitch_method)|Returns the number of bytes between each row in a 2D or 3D staging texture on the CPU.|  
|[texture::set Method](#texture__set_method)|Sets the value of the element at the specified index.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[texture::operator() Operator](#texture__operator___operator)|Returns the element value that is specified by the parameters.|  
|[texture::operator&#91;&#93; Operator](#texture__operator_at_operator)|Returns the element that is at the specified index.|  
|[texture::operator= Operator](#texture__operator_eq_operator)|Copies the specified                                         [texture](../vs140/texture-class.md) object to this one.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[texture::rank Constant](#texture__rank_constant)|Gets the rank of the                                         [texture](../vs140/texture-class.md) object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[Texture::associated_accelerator_view Data Member](#texture__associated_accelerator_view_data_member)|Gets the                                         [accelerator_view](../vs140/accelerator_view-class.md) that is the preferred target for this texture to be copied to.|  
|[texture::depth_pitch Data Member](#texture__depth_pitch_data_member)|Gets the number of bytes between each depth slice in a 3D staging texture on the CPU.|  
|[texture::row_pitch Data Member](#texture__row_pitch_data_member)|Gets the number of bytes between each row in a 2D or 3D staging texture on the CPU.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
##  \<a name="texture___dtortexture_destructor">\</a>  texture::~texture Destructor  
 Destroys the                 [texture](../vs140/texture-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="texture__associated_accelerator_view_data_member">\</a>  texture::associated_accelerator_view Data Member  
 Gets the                 [accelerator_view](../vs140/accelerator_view-class.md) that is the preferred target for this texture to be copied to.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="texture__copy_to_method">\</a>  texture::copy_to Method  
 Copies the                 [texture](../vs140/texture-class.md) object to the destination, by doing a deep copy.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
##  \<a name="texture__data_method">\</a>  texture::data Method  
 Returns a CPU pointer to the raw data of this texture.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the raw data of the texture.  
  
##  \<a name="texture__depth_pitch_data_member">\</a>  texture::depth_pitch Data Member  
 Gets the number of bytes between each depth slice in a 3D staging texture on the CPU.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="texture__get_method">\</a>  texture::get Method  
 Returns the value of the element at the specified index.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The index of the element.  
  
### Return Value  
 The value of the element at the specified index.  
  
##  \<a name="texture__get_associated_accelerator_view_method">\</a>  texture::get_associated_accelerator_view Method  
 Returns the accelerator_view that is the preferred target for this texture to be copied to.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The                         [accelerator_view](../vs140/accelerator_view-class.md) that is the preferred target for this texture to be copied to.  
  
##  \<a name="texture__get_depth_pitch_method">\</a>  texture::get_depth_pitch Method  
 Returns the number of bytes between each depth slice in a 3D staging texture on the CPU.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The number of bytes between each depth slice in a 3D staging texture on the CPU.  
  
##  \<a name="texture__get_row_pitch_method">\</a>  texture::get_row_pitch Method  
 Returns the number of bytes between each row in a 2-dimensional staging texture, or between each row of a depth slice in 3-dimensional staging texture.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The number of bytes between each row in a 2-dimensional staging texture, or between each row of a depth slice in 3-dimensional staging texture.  
  
##  \<a name="texture__operator___operator">\</a>  texture::operator() Operator  
 Returns the element value that is specified by the parameters.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The index.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The most-significant component of the index.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the index.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The least-significant component of the index.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The rank of the index.  
  
### Return Value  
 The element value that is specified by the parameters.  
  
##  \<a name="texture__operator_at_operator">\</a>  texture::operator[] Operator  
 Returns the element that is at the specified index.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The index.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The index.  
  
### Return Value  
 The element that is at the specified index.  
  
##  \<a name="texture__operator_eq_operator">\</a>  texture::operator= Operator  
 Copies the specified                 [texture](../vs140/texture-class.md) object to this one.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The                                 [texture](../vs140/texture-class.md) object to copy from.  
  
### Return Value  
 A reference to this                         [texture](../vs140/texture-class.md) object.  
  
##  \<a name="texture__rank_constant">\</a>  texture::rank Constant  
 Gets the rank of the                 [texture](../vs140/texture-class.md) object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="texture__row_pitch_data_member">\</a>  texture::row_pitch Data Member  
 Gets the number of bytes between each row in a 2D or 3D staging texture on the CPU.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="texture__set_method">\</a>  texture::set Method  
 Sets the value of the element at the specified index.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The index of the element.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The rank of the index.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The new value of the element.  
  
##  \<a name="texture__texture_constructor">\</a>  texture::texture Constructor  
 Initializes a new instance of the                 [texture](../vs140/texture-class.md) class.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The                                 [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The                                 [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 An accelerator_view that specifies the preferred target for copies to or from this texture.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The number of bits per each scalar element in the underlying scalar type of the texture. In general, supported value are 8, 16, 32, and 64. If 0 is specified, the number of bits is the same as the underlying scalar_type. 64 is only valid for double-based textures.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The extent in each dimension of the texture.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The most significant component of the texture.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the texture.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The least significant component of the extent of the texture.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The number of mipmap levels in the underlying texture. If 0 is specified, the texture will have the full range of mipmap levels down to the smallest possible size for the specified extent.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The rank of the extent.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to a host buffer.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 To texture to copy.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The number of bytes in the source buffer.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Other data source.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The rank of the section.  
  
## See Also  
 [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)