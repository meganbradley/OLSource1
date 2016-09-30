---
title: "Concurrency::graphics::direct3d namespace functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 11ee1d42-333e-4ae9-95ac-4cf68c06d13d
caps.latest.revision: 8
---
# Concurrency::graphics::direct3d namespace functions
||||  
|-|-|-|  
|[get_sampler Function](#get_sampler_function)|[get_texture Function](#get_texture_function)|[make_sampler Function](#make_sampler_function)|  
|[make_texture Function](#make_texture_function)|[msad4 Function](#msad4_function)|  
  
##  \<a name="get_sampler_function">\</a>  get_sampler Function  
 Get the D3D sampler state interface on the given accelerator view that represents the specified sampler object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A D3D accelerator view on which the D3D sampler state is to be created.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A sampler object for which the underlying D3D sampler state interface is created.  
  
### Return Value  
 The IUnknown interface pointer corresponding to the D3D sampler state that represents the given sampler.  
  
##  \<a name="get_texture_function">\</a>  get_texture Function  
 Gets the Direct3D texture interface underlying the specified                 [texture](../vs140/texture-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The element type of the texture.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A texture or texture view associated with the accelerator_view for which the underlying Direct3D texture interface is returned.  
  
### Return Value  
 The IUnknown interface pointer corresponding to the Direct3D texture underlying the texture.  
  
##  \<a name="make_sampler_function">\</a>  make_sampler Function  
 Create a sampler from a D3D sampler state interface pointer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 IUnknown interface pointer of the D3D sampler state to create the sampler from.  
  
### Return Value  
 A sampler represents the provided D3D sampler state.  
  
##  \<a name="make_texture_function">\</a>  make_texture Function  
 Creates a                 [texture](../vs140/texture-class.md) object by using the specified parameters.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A D3D accelerator view on which the texture is to be created.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 IUnknown interface pointer of the D3D texture to create the texture from.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The DXGI format to use for views created from this texture. Pass DXGI_FORMAT_UNKNOWN (the default) to derive the format from the underlying format of _D3D_texture and the _Value_type of this template. The provided format must be compatible with the underlying format of _D3D_texture.  
  
### Return Value  
 A texture using the provided D3D texture.  
  
##  \<a name="msad4_function">\</a>  msad4 Function  
 Compares a 4-byte reference value and an 8-byte source value and accumulates a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of different byte alignments between the reference value and the source value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The reference array of 4 bytes in one uint value  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The source array of 8 bytes in a vector of two uint values.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A vector of 4 values to be added to the masked sum of absolute differences of the different byte alignments between the reference value and the source value.  
  
### Return Value  
 Returns a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of different byte alignments between the reference value and the source value.  
  
## See Also  
 [Concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)