---
title: "future_error Class"
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
  - "future/std::future_error"
dev_langs: 
  - "C++"
ms.assetid: 6071c545-ac2a-49ef-9967-07b0125da861
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future_error Class
Describes an exception object that can be thrown by methods of types that manage [future](../vs140/future-class.md) objects.  
  
## Syntax  
  
```  
class future_error : public logic_error {  
public:  
   future_error(error_code code);  
   const error_code& code() const throw();  
   const char *what() const throw();  
};  
```  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [logic_error Class](../vs140/logic_error-class.md)   
 [error_code Class](../vs140/error_code-class.md)