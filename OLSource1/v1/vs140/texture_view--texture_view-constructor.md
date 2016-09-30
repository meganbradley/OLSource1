---
title: "texture_view::texture_view Constructor"
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
ms.assetid: f06b4025-cdac-4aee-9b20-e6dbf35653d1
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view::texture_view Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [1, 2] Constructor  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on which the writable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is created.  
  
 [3, 4] Constructor  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on which the non-writable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is created.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [5] Copy Constructor  
 The source writable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [6, 7] Copy Constructor  
 The source non-writable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The specific mipmap level on the source <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that this writeable <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> binds to. The default value is 0, which represents the top level (most detailed) mip level.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Top level (most detailed) mip level for the view, relative to the specified <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The number of mipmap levels accessible through the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)