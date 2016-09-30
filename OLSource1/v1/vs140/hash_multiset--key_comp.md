---
title: "hash_multiset::key_comp"
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
  - "key_comp"
  - "hash_multiset.key_comp"
  - "std::hash_multiset::key_comp"
  - "hash_set/stdext::hash_multiset::key_comp"
  - "std.hash_multiset.key_comp"
  - "hash_multiset::key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: a8136242-e9a2-4598-9f53-14664f7dad32
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::key_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the hash_multiset template parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which contains function objects that are used to hash and to order the elements of the container.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
## Remarks  
 The stored object defines a member function:  
  
 **bool operator**(**const Key&** *_xVal,* **const Key&** _<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](../vs140/hash_multiset--key_compare.md) and [value_compare](../vs140/hash_multiset--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the hash_multiset and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)