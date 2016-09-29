---
title: "unchecked_array_iterator Class"
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
  - "unchecked_array_iterator"
  - "stdext::unchecked_array_iterator"
dev_langs: 
  - "C++"
ms.assetid: 693b3b30-4e3a-465b-be06-409700bc50b1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unchecked_array_iterator Class
The `unchecked_array_iterator` class allows you to wrap an array or pointer into an unchecked iterator. Use this class as a wrapper (using the [make_unchecked_array_iterator](../VS_csharp/-iterator--functions.md#make_unchecked_array_iterator) function) for raw pointers or arrays as a targeted way to manage unchecked pointer warnings instead of globally silencing these warnings. If possible, prefer the checked version of this class, [checked_array_iterator](../VS_csharp/checked_array_iterator-class.md).  
  
> [!NOTE]
>  This class is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
## Syntax  
  
```  
template <class Iterator>  
    class unchecked_array_iterator;  
```  
  
## Remarks  
 This class is defined in the [stdext](../VS_csharp/stdext-namespace.md) namespace.  
  
 This is the unchecked version of the [checked_array_iterator Class](../VS_csharp/checked_array_iterator-class.md) and supports all the same overloads and members. For more information on the checked iterator feature with code examples, see [Checked Iterators](../VS_csharp/checked-iterators.md).  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [<iterator\>](../VS_csharp/-iterator-.md)   
 [Standard Template Library](../Topic/Standard%20Template%20Library.md)