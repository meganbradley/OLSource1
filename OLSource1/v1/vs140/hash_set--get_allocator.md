---
title: "hash_set::get_allocator"
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
  - "hash_set::get_allocator"
  - "std::hash_set::get_allocator"
  - "hash_set.get_allocator"
  - "get_allocator"
  - "std.hash_set.get_allocator"
  - "hash_set/stdext::hash_set::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: cf1e71eb-c027-4f71-9497-8c0346f79981
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::get_allocator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The allocator used by the hash_set to manage memory, which is the template parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
## Remarks  
 Allocators for the hash_set class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 The following output is for x86.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)