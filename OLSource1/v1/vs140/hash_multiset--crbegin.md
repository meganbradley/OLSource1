---
title: "hash_multiset::crbegin"
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
  - "hash_multiset::crbegin"
  - "hash_set/stdext::hash_multiset.crbegin"
  - "stdext.hash_multiset.crbegin"
  - "hash_multiset.crbegin"
  - "stdext::hash_multiset::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 160aa028-8b22-43b0-8905-25cb37f64600
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multiset](../vs140/hash_multiset-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> just as [begin](../vs140/hash_multiset--begin.md) is used with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element in the reversed hash_multiset is 30.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)