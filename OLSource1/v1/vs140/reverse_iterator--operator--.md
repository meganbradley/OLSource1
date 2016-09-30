---
title: "reverse_iterator::operator-&gt;"
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
  - "reverse_iterator.operator->"
  - "reverse_iterator::operator->"
  - "std::reverse_iterator::operator->"
  - "std.reverse_iterator.operator->"
  - "iterator/std::reverse_iterator::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-> operator"
  - "-> operator, with specific objects"
  - "operator->"
ms.assetid: 1f1b6550-2d02-4dab-a2dd-1beead429c74
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator-&gt;
Returns a pointer to the element addressed by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the element addressed by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The operator returns **&\*\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The reverse_iterator rpos points to:**  
**( 1, 2 )**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)