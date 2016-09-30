---
title: "uninitialized_fill_n"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "memory/std::uninitialized_fill_n"
  - "uninitialized_fill_n"
  - "std::uninitialized_fill_n"
  - "std.uninitialized_fill_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_fill_n"
  - "uninitialized_fill_n function"
ms.assetid: 4b14460b-fd5e-4fbc-a606-a447a74a65ef
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_fill_n
Copies objects of a specified value into specified number of elements into an uninitialized destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range to be initiated.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of elements to be initialized.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value to be used to initialize the destination range.  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std