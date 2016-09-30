---
title: "money_put::money_put"
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
  - "money_put.money_put"
  - "money_put"
  - "std.money_put.money_put"
  - "std::money_put::money_put"
  - "xlocmon/std::money_put::money_put"
  - "money_put::money_put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "money_put method"
  - "money_put class, constructor"
ms.assetid: 1ec9db51-bc4c-463c-b83f-c00039771c47
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_put::money_put
The constructor for objects of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
## Remarks  
 The possible values for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: the lifetime of the object is managed by the locales that contain it.  
  
-   1: the lifetime of the object must be manually managed.  
  
-   \> 0: these values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_put Class](../vs140/money_put-class.md)