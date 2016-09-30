---
title: "thread::operator= Operator"
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
  - "thread/std::thread::operator="
dev_langs: 
  - "C++"
ms.assetid: 7b69dca5-b979-449a-bff0-ef427820e948
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::operator= Operator
Associates the thread of a specified object with the current object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Remarks  
 The method calls detach if the calling object is joinable.  
  
 After the association is made, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to a default-constructed state.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [\<thread>](../vs140/-thread-.md)