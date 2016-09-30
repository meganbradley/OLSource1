---
title: "uninitialized_fill"
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
  - "memory/std::uninitialized_fill"
  - "std.uninitialized_fill"
  - "uninitialized_fill"
  - "std::uninitialized_fill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_fill function"
  - "uninitialized_fill"
ms.assetid: 6eadc810-1513-440a-9993-09d997215489
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_fill
Copies objects of a specified value into an uninitialized destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range that is to be initiated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the last element in the destination range that is to be initiated.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value to be used to initialize the destination range.  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **The initialized Array contains: 25 25 25 25 25 25 25 25 25 25**    
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std