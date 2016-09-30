---
title: "hash_set::value_comp"
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
  - "value_comp"
  - "hash_set.value_comp"
  - "std.hash_set.value_comp"
  - "std::hash_set::value_comp"
  - "hash_set::value_comp"
  - "hash_set/stdext::hash_set::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 54f95b47-fc7c-4923-b87b-65d9fe6fd280
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::value_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Retrieves a copy of the comparison object used to order element values in a hash_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a hash_set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator**(**const Key&** _*xVal*, **const Key&** \_<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [value_compare](../vs140/set--value_compare.md) and [key_compare](../vs140/set--key_compare.md) are synonyms for the template parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)