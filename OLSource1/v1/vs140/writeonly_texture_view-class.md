---
title: "writeonly_texture_view Class"
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
  - "amp_graphics/Concurrency::graphics::writeonly_texture_view"
dev_langs: 
  - "C++"
ms.assetid: 8d117ad3-0a1c-41ae-b29c-7c95fdd4d04d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# writeonly_texture_view Class
Provides writeonly access to a texture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The type of the elements in the texture.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[writeonly_texture_view::writeonly_texture_view Constructor](#writeonly_texture_view__writeonly_texture_view_constructor)|Initializes a new instance of the                                         [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) class.|  
|[writeonly_texture_view::~writeonly_texture_view Destructor](#writeonly_texture_view___dtorwriteonly_texture_view_destructor)|Destroys the                                         [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[writeonly_texture_view::set Method](#writeonly_texture_view__set_method)|Sets the value of the element at the specified index.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[writeonly_texture_view::operator= Operator](#writeonly_texture_view__operator_eq_operator)|Copies the specified                                         [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object to this one.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[writeonly_texture_view::rank Constant](#writeonly_texture_view__rank_constant)|Gets the rank of the                                         [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
##  \<a name="writeonly_texture_view___dtorwriteonly_texture_view_destructor">\</a>  writeonly_texture_view::~writeonly_texture_view Destructor  
 Destroys the                 [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="writeonly_texture_view__operator_eq_operator">\</a>  writeonly_texture_view::operator= Operator  
 Copies the specified                 [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object to this one.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object to copy from.  
  
### Return Value  
 A reference to this                         [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object.  
  
##  \<a name="writeonly_texture_view__rank_constant">\</a>  writeonly_texture_view::rank Constant  
 Gets the rank of the                 [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="writeonly_texture_view__set_method">\</a>  writeonly_texture_view::set Method  
 Sets the value of the element at the specified index.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The index of the element.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The new value of the element.  
  
##  \<a name="writeonly_texture_view__writeonly_texture_view_constructor">\</a>  writeonly_texture_view::writeonly_texture_view Constructor  
 Initializes a new instance of the                 [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The rank of the texture.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The type of the elements in the texture.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The texture that is used to create the                                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## See Also  
 [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)