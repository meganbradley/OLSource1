---
title: "inserter"
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
  - "std.inserter"
  - "inserter"
  - "iterator/std::inserter"
  - "std::inserter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inserter"
  - "inserter function"
ms.assetid: 47e27c8a-89ac-4c26-a923-7623d86633ba
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inserter
A helper template function that lets you use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The container to which new elements are to be added.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An iterator locating the point of insertion.  
  
## Remarks  
 The template function returns [insert_iterator](../vs140/insert_iterator--insert_iterator.md)<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The list L is:**  
 **( 20 30 40 ).**  
**After the insertions, the list L is:**  
 **( 1 20 30 40 500 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)