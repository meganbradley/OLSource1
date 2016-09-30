---
title: "hash_map::key_comp"
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
  - "hash_map::key_comp"
  - "std.hash_map.key_comp"
  - "key_comp"
  - "hash_map/stdext::hash_map::key_comp"
  - "std::hash_map::key_comp"
  - "hash_map.key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 28bd00f6-7a9d-4aab-a9c7-ca6e2b512b4c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::key_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a hash_map uses to order its elements.  
  
## Remarks  
 The stored object defines the member function  
  
 **bool operator**(**const Key&** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>**, const Key&** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>);  
  
 that returns **true** if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the sort order.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)