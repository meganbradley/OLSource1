---
title: "make_texture Function"
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
  - "amp_graphics/Concurrency::graphics::direct3d::make_texture"
dev_langs: 
  - "C++"
ms.assetid: abf23804-dac7-455b-826e-c50f57e8f4b7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_texture Function
Creates a [texture](../vs140/texture-class.md) object by using the specified parameters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A D3D accelerator view on which the texture is to be created.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 IUnknown interface pointer of the D3D texture to create the texture from.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The DXGI format to use for views created from this texture. Pass DXGI_FORMAT_UNKNOWN (the default) to derive the format from the underlying format of _D3D_texture and the _Value_type of this template. The provided format must be compatible with the underlying format of _D3D_texture.  
  
## Return Value  
 A texture using the provided D3D texture.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics::direct3d  
  
## See Also  
 [Concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)