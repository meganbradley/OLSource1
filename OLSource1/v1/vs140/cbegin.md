---
title: "cbegin"
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
  - "std::cbegin"
  - "iterator/std::cbegin"
  - "xutility/std::cbegin"
  - "cbegin"
dev_langs: 
  - "C++"
ms.assetid: 9ffd573c-6c7d-4798-9873-ea2f977dcf79
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cbegin
Retrieves a const iterator to the first element in a specified container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A container or initializer_list.  
  
## Return Value  
 A constant <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function works with all STL containers and with [initializer_list](../vs140/initializer_list-class.md).  
  
 You can use this member function in place of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> template function to guarantee that the return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) container or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> of any kind that supports <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [begin](../vs140/begin.md)   
 [cend](../vs140/cend.md)   
 [end](../vs140/end.md)