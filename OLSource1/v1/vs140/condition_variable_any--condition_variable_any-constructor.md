---
title: "condition_variable_any::condition_variable_any Constructor"
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
  - "condition_variable/std::condition_variable_any::condition_variable_any"
dev_langs: 
  - "C++"
ms.assetid: d5894374-bd5b-48cf-96f5-e266ece47a09
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable_any::condition_variable_any Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If not enough memory is available, the constructor throws a [system_error](../vs140/system_error-class.md) object that has a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> error code. If the object cannot be constructed because some other resource is not available, the constructor throws a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that has a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> error code.  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable_any Class](../vs140/condition_variable_any-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)