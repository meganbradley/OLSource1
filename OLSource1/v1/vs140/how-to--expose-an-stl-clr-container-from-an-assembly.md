---
title: "How to: Expose an STL-CLR Container from an Assembly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "How to: Expose an STL/CLR Container from an Assembly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "STL/CLR Containers [STL/CLR]"
  - "STL/CLR, cross-assembly issues"
ms.assetid: 87efb41b-3db3-4498-a2e7-f3ef8a99f04d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Expose an STL-CLR Container from an Assembly
STL/CLR containers such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are implemented as template ref classes. Because C++ templates are instantiated at compile time, two template classes that have exactly the same signature but are in different assemblies are actually different types. This means that template classes cannot be used across assembly boundaries.  
  
 To make cross-assembly sharing possible, STL/CLR containers implement the generic interface <xref:System.Collections.Generic.ICollection<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>StlClrClassLibrary<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>StlClrClassLibrary<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>generic_container<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>cliext::vector<int><CodeContentPlaceHolder>12\</CodeContentPlaceHolder>cliext::vector<int>::generic_container<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>generic_iterator<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>cliext::vector<int>::generic_iterator<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>cliext::vector<int><CodeContentPlaceHolder>16\</CodeContentPlaceHolder>System.Collections.Generic.ICollection<int><CodeContentPlaceHolder>17\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>queue<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>priority_queue<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>stack<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>generic_container<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>1*> methods of the STL/CLR containers to iterate over the containers and to display their contents.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md)