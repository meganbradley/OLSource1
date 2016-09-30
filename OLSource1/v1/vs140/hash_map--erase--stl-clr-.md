---
title: "hash_map::erase (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::erase (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase member [STL/CLR]"
ms.assetid: 1d2a79aa-62f7-461c-8f7c-7b660eb189be
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::erase (STL-CLR)
Removes elements at specified positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to erase.  
  
 key  
 Key value to erase.  
  
 last  
 End of range to erase.  
  
 where  
 Element to erase.  
  
## Remarks  
 The first member function removes the element of the controlled sequence pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and returns an iterator that designates the first element remaining beyond the element removed, or [end](../vs140/hash_map--end--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if no such element exists. You use it to remove a single element.  
  
 The second member function removes the elements of the controlled sequence in the range <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and returns an iterator that designates the first element remaining beyond any elements removed, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if no such element exists.. You use it to remove zero or more contiguous elements.  
  
 The third member function removes any element of the controlled sequence whose key has equivalent ordering to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and returns a count of the number of elements removed. You use it to remove and count all elements that match a specified key.  
  
 Each element erasure takes time proportional to the logarithm of the number of elements in the controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**erase(begin()) = [b 2]**  
 **[b 2] [c 3] [d 4] [e 5]**  
**erase(begin(), end()-1) = [e 5]**  
**size() = 1**  
**erase(L'x') = 0**  
**erase(L'e') = 1**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [clear](../vs140/hash_map--clear--stl-clr-.md)