---
title: "cend"
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
  - "xutility/std::cend"
  - "std::cend"
  - "cend"
  - "iterator/std::cend"
dev_langs: 
  - "C++"
ms.assetid: a60f3363-2869-4c07-b5c7-052ddc1e9556
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cend
Retrieves a const iterator to the element that follows the last element in the specified container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A container or initializer_list.  
  
## Return Value  
 A constant <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function works with all STL containers and with [initializer_list](../vs140/initializer_list-class.md).  
  
 You can use this member function in place of the [end()](../vs140/end.md) template function to guarantee that the return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) container or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of any kind that supports <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [begin](../vs140/begin.md)   
 [cbegin](../vs140/cbegin.md)   
 [end](../vs140/end.md)