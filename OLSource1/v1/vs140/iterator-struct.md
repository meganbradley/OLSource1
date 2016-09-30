---
title: "iterator Struct"
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
  - "iterator"
  - "std::iterator"
  - "std.iterator"
  - "xutility/std::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator class"
  - "iterator struct"
ms.assetid: c74c8000-8b18-4829-9b71-6103c4229b74
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iterator Struct
An empty base struct used to ensure that a user-defined iterator class works properly with **iterator_trait**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template struct serves as a base type for all iterators. It defines the member types  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (a synonym for the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (a synonym for the template parameter **Type**).  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (a synonym for the template parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (a synonym for the template parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (a synonym for the template parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (a synonym for the template parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
 Note that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> should not be a constant type even if **pointer** points at an object of const **Type** and reference designates an object of const **Type**.  
  
## Example  
 See [iterator_traits](../vs140/iterator_traits-struct.md) for an example of how to declare and use the types in the iterator base class.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)