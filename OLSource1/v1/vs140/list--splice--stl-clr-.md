---
title: "list::splice (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::splice (STL/CLR)"
f1_keywords: 
  - "cliext::list::splice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splice member [STL/CLR]"
ms.assetid: ebc424b9-8341-4a88-b101-86d56324f5ac
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::splice (STL-CLR)
Restitch links between nodes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to splice.  
  
 last  
 End of range to splice.  
  
 right  
 Container to splice from.  
  
 where  
 Where in container to splice before.  
  
## Remarks  
 The first member function inserts the sequence controlled by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> before the element in the controlled sequence pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It also removes all elements from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must not equal <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.) You use it to splice all of one list into another.  
  
 The second member function removes the element pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sequence controlled by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and inserts it before the element in the controlled sequence pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, no change occurs.) You use it to splice a single element of one list into another.  
  
 The third member function inserts the subrange designated by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> from the sequence controlled by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> before the element in the controlled sequence pointed to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It also removes the original subrange from the sequence controlled by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must not include the element pointed to by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.) You use it to splice a subsequence of zero or more elements from one list into another.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**c1.size() = 0**  
 **a b c**  
 **a**  
 **b c**  
 **b c a**  
**c2.size() = 0**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [assign](../vs140/list--assign--stl-clr-.md)   
 [insert](../vs140/list--insert--stl-clr-.md)   
 [merge](../vs140/list--merge--stl-clr-.md)