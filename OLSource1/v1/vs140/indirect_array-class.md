---
title: "indirect_array Class"
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
  - "std.indirect_array"
  - "valarray/std::indirect_array"
  - "std::indirect_array"
  - "indirect_array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "indirect_array class"
ms.assetid: 10e1eaea-ba5a-405c-a25e-7bdd3eee7fc7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# indirect_array Class
An internal, auxiliary template class that supports objects that are subsets of valarrays by providing operations between subset arrays defined by specifying a subset of indices of a parent valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class describes an object that stores a reference to an object **va** of class [valarray](../vs140/valarray-class.md)**\<Type>**, along with an object **xa** of class **valarray\<size_t>**, which describes the sequence of elements to select from the **valarray\<Type>** object.  
  
 You construct an **indirect_array\<Type>** object only by writing an expression of the form **va[xa]**. The member functions of class indirect_array then behave like the corresponding function signatures defined for **valarray\<Type>**, except that only the sequence of selected elements is affected.  
  
 The sequence consists of **xa.**[size](../vs140/valarray-class.md#valarray__size) elements, where element <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> becomes the index **xa**[ <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>] within **va**.  
  
## Example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)