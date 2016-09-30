---
title: "Graphics (C++ AMP)"
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
ms.assetid: 190a98a4-5f7d-442e-866b-b374ca74c16f
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Graphics (C++ AMP)
C++ AMP contains several APIs in the [Concurrency::graphics](../vs140/concurrency--graphics-namespace.md) namespace that you can use to access the texture support on GPUs. Some common scenarios are:  
  
-   You can use the [texture](../vs140/texture-class.md) class as a data container for computation and exploit the *spatial locality* of the texture cache and layouts of GPU hardware. Spatial locality is the property of data elements being physically close to each other.  
  
-   The runtime provides efficient interoperability with non-compute shaders. Pixel, vertex, tessellation, and hull shaders frequently consume or produce textures that you can use in your C++ AMP computations.  
  
-   The graphics APIs in C++ AMP provide alternative ways to access sub-word packed buffers. Textures that have formats that represent *texels* (texture elements) that are composed of 8-bit or 16-bit scalars allow access to such packed data storage.  
  
## The norm and unorm Types  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> types are scalar types that limit the range of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values; this is known as *clamping*. These types can be explicitly constructed from other scalar types. In casting, the value is first cast to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and then clamped to the respective region that's allowed by norm [-1.0…1.0] or unorm [0.0…1.0]. Casting from +/- infinity returns +/-1. Casting from NaN is undefined. A norm can be implicitly constructed from a unorm and there is no loss of data. The implicit conversion operator to float is defined on these types. Binary operators are defined between these types and other built-in scalar types such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>: +, -, *, /, ==, !=, >, \<, >=, <=. The compound assignment operators are also supported: +=, -=, \*=, /=. The unary negation operator (-) is defined for norm types.  
  
## Short Vector Library  
 The Short Vector Library provides some of the functionality of the [Vector Type](http://go.microsoft.com/fwlink/p/?LinkId=248500) that's defined in HLSL and is typically used to define texels. A short vector is a data structure that holds one to four values of the same type. The supported types are <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The type names are shown in the following table. For each type, there is also a corresponding <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> that doesn't have an underscore in the name. The types that have the underscores are in the [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md). The types that don't have the underscores are in the [Concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md) so that they are clearly separated from the similarly-named fundamental types such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
||Length 2|Length 3|Length 4|  
|-|--------------|--------------|--------------|  
|double|double_2\<br />\<br /> double2|double_3\<br />\<br /> double3|double_4\<br />\<br /> double4|  
|float|float_2\<br />\<br /> float2|float_3\<br />\<br /> float3|float_4\<br />\<br /> float4|  
|int|int_2\<br />\<br /> int2|int_3\<br />\<br /> int3|int_4\<br />\<br /> int4|  
|norm|norm_2\<br />\<br /> norm2|norm_3\<br />\<br /> norm3|norm_4\<br />\<br /> norm4|  
|uint|uint_2\<br />\<br /> uint2|uint_3\<br />\<br /> uint3|uint_4\<br />\<br /> uint4|  
|unorm|unorm_2\<br />\<br /> unorm2|unorm_3\<br />\<br /> unorm3|unorm_4\<br />\<br /> unorm4|  
  
### Operators  
 If an operator is defined between two short vectors, then it is also defined between a short vector and a scalar. Also, one of these must be true:  
  
-   The scalar’s type must be the same as the short vector’s element type.  
  
-   The scalar’s type can be implicitly converted to the vector’s element type by using only one user-defined conversion.  
  
 The operation is carried component-wise between each component of the short vector and the scalar. Here are the valid operators:  
  
|Operator type|Valid types|  
|-------------------|-----------------|  
|Binary operators|Valid on all types: +, -, *, /,\<br />\<br /> Valid on integer types: %, ^, &#124;, &, <\<, >>\<br />\<br /> The two vectors must have the same size, and the result is a vector of the same size.|  
|Relational operators|Valid on all types: == and !=|  
|Compound assignment operator|Valid on all types: +=, -=, *=, /=\<br />\<br /> Valid on integer types: %=, ^=, &#124;=, &=, <\<=, >>=|  
|Increment and decrement operators|Valid on all types: ++, --\<br />\<br /> Both prefix and postfix are valid.|  
|Bitwise NOT operator (~)|Valid on integer types.|  
|Unary - operator|Valid on all types except <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
  
### Swizzling Expressions  
 The Short Vector Library supports the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> accessor construct to access the components of a short vector. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, which is known as a *swizzling expression*, specifies the components of the vector. The expression can be an l-value or an r-value. Individual characters in the identifier may be: x, y, z, and w; or r, g, b, and a. "x" and "r" mean the zero-th component, "y" and "g" mean the first component, and so on. (Notice that "x" and "r" cannot be used in the same identifier.) Therefore, "rgba" and "xyzw" return the same result. Single-component accessors such as "x" and "y" are scalar value types. Multi-component accessors are short vector types. For example, if you construct an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> vector that's named <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and has the values 2, 4, 6, and 8, then <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> returns the integer 4 and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> returns an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object that has the values 2 and 4.  
  
## Texture Classes  
 Many GPUs have hardware and caches that are optimized to fetch pixels and texels and to render images and textures. The [texture\<T,N>](../vs140/texture-class.md) class, which is a container class for texel objects, exposes the texture functionality of these GPUs. A texel can be:  
  
-   An <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> scalar.  
  
-   A short vector that has two or four components. The only exception is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, which is not allowed.  
  
 The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object can have a rank of 1, 2, or 3. The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object can be captured only by reference in the lambda of a call to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. The texture is stored on the GPU as Direct3D texture objects. For more information about textures and texels in Direct3D, see [Introduction to Textures in Direct3D 11](http://go.microsoft.com/fwlink/p/?LinkId=248502).  
  
 The texel type you use might be one of the many texture formats that are used in graphics programming. For example, an RGBA format could use 32 bits, with 8 bits each for the R, G, B, and A scalar elements. The texture hardware of a graphics card can access the individual elements based on the format. For example, if you are using the RGBA format, the texture hardware can extract each 8-bit element into a 32-bit form. In C++ AMP, you can set the bits per scalar element of your texel so that you can automatically access the individual scalar elements in the code without using bit-shifting.  
  
### Instantiating Texture Objects  
 You can declare a texture object without initialization. The following code example declares several texture objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also use a constructor to declare and initialize a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. The following code example instantiates a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object from a vector of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> objects. The bits per scalar element is set to the default. You cannot use this constructor with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, or the short vectors of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, because they do not have a default bits per scalar element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can also declare and initialize a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object by using a constructor overload that takes a pointer to the source data, the size of source data in bytes, and the bits per scalar element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The textures in these examples are created on the default view of the default accelerator. You can use other overloads of the constructor if you want to specify an <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object. You cannot create a texture object on a CPU accelerator.  
  
 There are limits on the size of each dimension of the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object, as shown in the following table. A run-time error is generated if you exceed the limits.  
  
|Texture|Size limitation|  
|-------------|---------------------|  
|texture\<T,1>|16384|  
|texture\<T,2>|16384|  
|texture\<T,2>|2048|  
  
### Reading from Texture Objects  
 You can read from a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object by using [texture::operator&#91;&#93; Operator](../vs140/texture--operatoroperator.md), [texture::operator() Operator](../vs140/texture--operator---operator.md), or [texture::get Method](../vs140/texture--get-method.md). [texture::operator&#91;&#93; Operator](../vs140/texture--operatoroperator.md) and [texture::operator() Operator](../vs140/texture--operator---operator.md) return a value, not a reference. Therefore, you cannot write to a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object by using [texture::operator&#91;&#93; Operator](../vs140/texture--operatoroperator.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following code example demonstrates how to store texture channels in a short vector, and then access the individual scalar elements as properties of the short vector.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following table lists the valid bits per channel for each sort vector type.  
  
|Texture data type|Valid bits per scalar element|  
|-----------------------|-----------------------------------|  
|int, int_2, int_4\<br />\<br /> uint, uint_2, uint_4|8, 16, 32|  
|int_3, uint_3|32|  
|float, float_2, float_4|16, 32|  
|float_3|32|  
|double, double_2|64|  
|norm, norm_2, norm_4\<br />\<br /> unorm, unorm_2, unorm, 4|8, 16|  
  
### Writing to Texture Objects  
 Use the [texture::set](../vs140/texture--set-method.md) method to write to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> objects. A texture object can be readonly or read/write. For a texture object to be readable and writeable, the following conditions must be true:  
  
-   T has only one scalar component. (Short vectors are not allowed.)  
  
-   T is not <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> property is 32.  
  
 If all three are not true, then the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object is readonly. The first two conditions are checked during compilation. A compilation error is generated if you have code that tries to write to a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> texture object. The condition for <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is detected at run time, and the runtime generates the [unsupported_feature](../vs140/unsupported_feature-class.md) exception if you try to write to a readonly <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
 The following code example writes values to a texture object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Copying Texture Objects  
 You can copy between texture objects by using the [copy](../vs140/copy-function.md) function or the [copy_async](../vs140/copy_async-function.md) function, as shown in the following code example.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 You can also copy from one texture to another by using the [texture::copy_to](../vs140/texture--copy_to-method.md) method. The two textures can be on different accelerator_views. When you copy to a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object, the data is copied to the underlying <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object. The bits per scalar element and the extent must be the same on the source and destination <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> objects. If those requirements are not met, the runtime throws an exception.  
  
## Texture View Classes  
 C++ AMP introduces the [texture_view class](../vs140/texture_view-class.md) in [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)]. Texture views support the same texel types and ranks as the [texture class](../vs140/texture-class.md), but unlike textures, they provide access to additional hardware features such as texture sampling and mipmaps. Texture views support read-only, write-only, and read-write access to the underlying texture data.  
  
-   Read-only access is provided by the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> template specialization, which supports elements that have 1, 2, or 4 components, texture sampling, and dynamic access to a range of mipmap levels that are determined when the view is instantiated.  
  
-   Write-only access is provided by the non-specialized template class <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, which supports elements that have either 2 or 4 components and can access one mipmap level that's determined when the view is instantiated. It does not support sampling.  
  
-   Read-write access is provided by the non-specialized template class <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, which, like textures, supports elements that have only one component; the view can access one mipmap level that's determined when it is instantiated. It does not support sampling.  
  
 Texture views are analogous to array views, but do not provide the automatic data management and movement functionality that the [array_view class](../vs140/array_view-class.md) provides over the [array class](../vs140/array-class.md). A <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> can only be accessed on the accelerator view where the underlying texture data resides.  
  
### writeonly_texture_view Deprecated  
 For [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)], C++ AMP introduces better support for hardware texture features such as sampling and mipmaps, which could not be supported by the [writeonly_texture_view class](../vs140/writeonly_texture_view-class.md). The newly introduced <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> class supports a superset of the functionality in <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>; as a result, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is deprecated.  
  
 We recommend—at least for new code—that you use <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> to access functionality that was formerly provided by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. Compare the following two code examples that write to a texture object that has two components (int_2). Notice that in both cases, the view, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, must be captured by value in the lambda expression. Here is the example that uses the new <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 And here is the deprecated <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 As you can see, the two code examples are nearly identical when all you are doing is writing to the primary mipmap level. If you used <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> in existing code and you're not planning to enhance that code, you don't have to change it. However, if you're thinking about bringing that code forward, we suggest that you rewrite it to use <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> because the enhancements in it support new hardware texture features. Read on for more information about these new capabilities.  
  
 For more information about the deprecation of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, see [Overview of the Texture View Design in C++ AMP](http://blogs.msdn.com/b/nativeconcurrency/archive/2013/07/25/overview-of-the-texture-view-design-in-c-amp.aspx) on the Parallel Programming in Native Code blog.  
  
### Instantiating Texture View Objects  
 Declaring a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is similar to declaring an <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> that's associated with an <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. The following code example declares several <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> objects and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> objects that are associated with them.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Notice how a texture view whose element type is non-const and has one component is read-write, but a texture view whose element type is non-const but has more than one componenent are write-only. Texture views of const element types are always read-only, but if the element type is non-const, then the number of components in the element determines whether it is read-write (1 component) or write-only (multiple components).  
  
 The element type of a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>—its const-ness and also the number of components it has—also plays a role in determining whether the view supports texture sampling, and how mipmap levels can be accessed:  
  
|Type|Components|Read|Write|Sampling|Mipmap access|  
|----------|----------------|----------|-----------|--------------|-------------------|  
|texture_view\<const T, N>|1, 2, 4|Yes|No (1)|Yes|Yes, indexable. Range is determined at instantiation.|  
|Texture_view\<T, N>|1\<br />\<br /> 2, 4|Yes\<br />\<br /> No (2)|Yes\<br />\<br /> Yes|No (1)\<br />\<br /> No (1)|Yes, one level. Level is determined at instantiation.\<br />\<br /> Yes, one level. Level is determined at instantiation.|  
  
 From this table, you can see that read-only texture views fully support the new capabilities in exchange for not being able to write to the view. Writable texture views are limited in that they can only access one mipmap level. Read-write texture views are even more specialized than writable ones, because they add the requirement that the element type of the texture view has only one component. Notice that sampling is not supported for writable texture views because it's a read-oriented operation.  
  
### Reading from Texture View Objects  
 Reading unsampled texture data through a texture view is just like reading it from the texture itself, except that textures are captured by reference, whereas texture views are captured by value. The following two code examples demonstrate; first, by using <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> only:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 And here is the same example, except it now uses the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Texture views whose elements are based on floating-point types—for example, float, float_2, or float_4—can also be read by using texture sampling to take advantage of hardware support for various filtering modes and addressing modes. C++ AMP supports the two filtering modes that are most common in compute scenarios—point-filtering (nearest-neighbor) and linear-filtering (weighted average)—and four addressing modes—wrapped, mirrored, clamped, and border. For more information about filtering modes, see [filter_mode Enumeration](../vs140/filter_mode-enumeration.md); for more information about addressing modes, see [address_mode Enumeration](../vs140/address_mode-enumeration.md).  
  
 In addition to modes that C++ AMP supports directly, you can access other filtering modes and addressing modes of the underlying platform by using the interop APIs to adopt a texture sampler that was created by using the platform APIs directly. For example, Direct3D supports other filtering modes such as anisotropic filtering, and can apply a different addressing mode to each dimension of a texture. You could create a texture sampler whose coordinates are wrapped vertically, mirrored horizontally, and sampled with anisotropic filtering by using the Direct3D APIs, and then leverage the sampler in your C++ AMP code by using the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> interop API. For more information see [Texture Sampling in C++ AMP](http://blogs.msdn.com/b/nativeconcurrency/archive/2013/07/18/texture-sampling-in-c-amp.aspx) on the Parallel Programming in Native Code blog.  
  
 Texture views also support the reading of mipmaps. Read-only texture views (those that have a const element type) offer the most flexibility because a range of mip-levels that is determined at instantiation can be dynamically sampled, and because elements that have 1, 2, or 4 components are supported. Read-write texture views that have elements that have one component also support mipmaps, but only of a level that's determined at instantiation. For more information, see [Texture with Mipmaps](http://blogs.msdn.com/b/nativeconcurrency/archive/2013/08/22/texture-with-mipmaps.aspx) on the Parallel Programming in Native Code blog.  
  
### Writing to Texture View Objects  
 Use the [texture_view::set member function](../vs140/texture_view--get-method.md) to write to the underlying <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> through the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object. A texture view can be read-only, read-write, or write-only. For a texture view to be writable it must have an element type that is non-const; for a texture view to be readable and writable, its element type must also have only one component. Otherwise, the texture view is read-only. You can only access one mipmap level of a texture at a time through a texture view, and the level is specified when the view is instantiated.  
  
 This example shows how to write to the second-most detailed mipmap level of a texture that has 4 mipmap levels. The most detailed mipmap level is level 0.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## Interoperability  
 The C++ AMP runtime supports interoperability between <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and the [ID3D11Texture1D interface](http://go.microsoft.com/fwlink/p/?LinkId=248503), between <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> and the [ID3D11Texture2D interface](http://go.microsoft.com/fwlink/p/?LinkId=255317), and between <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> and the [ID3D11Texture3D interface](http://go.microsoft.com/fwlink/p/?LinkId=255377). The [get_texture](../vs140/get_texture-function.md) method takes a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object and returns an <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> interface. The [make_texture](../vs140/make_texture-function.md) method takes an <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> interface and an <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object and returns a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object.  
  
## See Also  
 [double_2 Class](../vs140/double_2-class.md)   
 [double_3 Class](../vs140/double_3-class.md)   
 [double_4 Class](../vs140/double_4-class.md)   
 [float_2 Class](../vs140/float_2-class.md)   
 [float_3 Class](../vs140/float_3-class.md)   
 [float_4 Class](../vs140/float_4-class.md)   
 [int_2 Class](../vs140/int_2-class.md)   
 [int_3 Class](../vs140/int_3-class.md)   
 [int_4 Class](../vs140/int_4-class.md)   
 [norm_2 Class](../vs140/norm_2-class.md)   
 [norm_3 Class](../vs140/norm_3-class.md)   
 [norm_4 Class](../vs140/norm_4-class.md)   
 [short_vector Structure](../vs140/short_vector-structure.md)   
 [short_vector_traits Structure](../vs140/short_vector_traits-structure.md)   
 [uint_2 Class](../vs140/uint_2-class.md)   
 [uint_3 Class](../vs140/uint_3-class.md)   
 [uint_4 Class](../vs140/uint_4-class.md)   
 [unorm_2 Class](../vs140/unorm_2-class.md)   
 [unorm_3 Class](../vs140/unorm_3-class.md)   
 [unorm_4 Class](../vs140/unorm_4-class.md)