---
title: "array::array Constructor"
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
  - "amp/Concurrency::array::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array, constructor"
ms.assetid: 9d9c6b28-6f75-4b61-8694-586683891aba
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::array Constructor
Initializes a new instance of the [array](../vs140/array-class.md) class. There is no default constructor for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. All constructors are run on the CPU only. They cannot be executed on a Direct3D target.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An accelerator_view which specifies the preferred target location of the array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An [accelerator_view](../vs140/accelerator_view-class.md) object that specifies the location of the array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The desired [access_type](../vs140/access_type-enumeration.md) for the array on the CPU. This parameter has a default value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> leaving the CPU <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> determination to the runtime. The actual CPU <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the array can be queried using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The extent in each dimension of the array.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Other data source.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The rank of the section.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
## Remarks  
 Staging constructors have two [accelerator_view](../vs140/accelerator_view-class.md) objects as constructor parameters. Staging arrays are used as a hint to optimize repeated copies between two accelerators (between the CPU and a Direct3D accelerator). Staging arrays are optimized for data transfer and do not have stable user-space memory. They are backed by DirectX staging buffers that have the correct hardware alignment to make sure there is an efficient Direct Memory Access (DMA) transfer between the CPU and the accelerator. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property of a staging array returns the value of the first accelerator argument that it was constructed with. You can't change or examine the contents of a staging array when it is involved in a transfer operation, as demonstrated in the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)