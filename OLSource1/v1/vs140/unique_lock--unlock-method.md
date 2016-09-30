---
title: "unique_lock::unlock Method"
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
  - "mutex/std::unique_lock::unlock"
dev_langs: 
  - "C++"
ms.assetid: 489a9734-36c0-4d8b-8bbc-296f6440a47a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::unlock Method
Releases ownership of the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the calling thread doesn't own the associated <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, this method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Otherwise, this method calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and sets the internal thread ownership flag to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)