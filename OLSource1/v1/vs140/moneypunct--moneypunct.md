---
title: "moneypunct::moneypunct"
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
  - "std.moneypunct.moneypunct"
  - "moneypunct"
  - "moneypunct.moneypunct"
  - "std::moneypunct::moneypunct"
  - "moneypunct::moneypunct"
  - "xlocmon/std::moneypunct::moneypunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "moneypunct method"
  - "moneypunct class, constructor"
ms.assetid: bd614519-5793-4c40-b379-ad37a1ce4e81
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::moneypunct
Constructor of objects of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
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
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(_*Refs*).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)