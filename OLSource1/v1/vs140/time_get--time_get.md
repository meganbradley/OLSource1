---
title: "time_get::time_get"
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
  - "time_get::time_get"
  - "std.time_get.time_get"
  - "std::time_get::time_get"
  - "time_get.time_get"
  - "xloctime/std::time_get::time_get"
  - "time_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time_get method"
  - "time_get class, constructor"
ms.assetid: 49f54929-4d5a-4bf7-8ad9-a7069ed86926
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::time_get
The constructor for objects of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
## Remarks  
 The possible values for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)