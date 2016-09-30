---
title: "texture::texture Constructor"
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
  - "amp_graphics/Concurrency::graphics::texture::texture"
dev_langs: 
  - "C++"
ms.assetid: 17175f00-a5b3-4040-bb12-6a26678ad865
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::texture Constructor
Initializes a new instance of the [texture](../vs140/texture-class.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An accelerator_view that specifies the preferred target for copies to or from this texture.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of bits per each scalar element in the underlying scalar type of the texture. In general, supported value are 8, 16, 32, and 64. If 0 is specified, the number of bits is the same as the underlying scalar_type. 64 is only valid for double-based textures.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The extent in each dimension of the texture.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The most significant component of the texture.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the texture.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The least significant component of the extent of the texture.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of mipmap levels in the underlying texture. If 0 is specified, the texture will have the full range of mipmap levels down to the smallest possible size for the specified extent.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The rank of the extent.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A pointer to a host buffer.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 To texture to copy.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The number of bytes in the source buffer.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Other data source.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The rank of the section.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)