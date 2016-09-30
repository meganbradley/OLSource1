---
title: "mask_array Class"
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
  - "std.mask_array"
  - "mask_array"
  - "std::mask_array"
  - "valarray/std::mask_array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mask_array class"
ms.assetid: c49bed6a-3000-4f39-bff6-cb9a453acb0b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mask_array Class
An internal, auxiliary template class that supports objects that are subsets of parent valarrays, specified with a Boolean expression, by providing operations between the subset arrays.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class describes an object that stores a reference to an object **va** of class [valarray](../vs140/valarray-class.md)**\<Type>**, along with an object **ba** of class [valarray\<bool>](../vs140/valarray-bool--class.md), which describes the sequence of elements to select from the **valarray\<Type>** object.  
  
 You construct a **mask_array\<Type>** object only by writing an expression of the form [va&#91;ba&#93;](../vs140/valarray-class.md#valarray__operator_at). The member functions of class mask_array then behave like the corresponding function signatures defined for **valarray\<Type>**, except that only the sequence of selected elements is affected.  
  
 The sequence consists of at most **ba.size** elements. An element                 *J* is included only if **ba**[                *J*] is true. Thus, there are as many elements in the sequence as there are true elements in **ba**. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the index of the lowest true element in **ba**, then **va**[ <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>] is element zero in the selected sequence.  
  
## Example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)