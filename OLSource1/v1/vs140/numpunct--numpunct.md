---
title: "numpunct::numpunct"
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
  - "std::numpunct::numpunct"
  - "std.numpunct.numpunct"
  - "numpunct.numpunct"
  - "numpunct::numpunct"
  - "numpunct"
  - "xlocnum/std::numpunct::numpunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "numpunct method"
  - "numpunct class, constructor"
ms.assetid: f3064aac-1808-4934-80ce-62def2ffce3e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numpunct::numpunct
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
 [numpunct Class](../vs140/numpunct-class.md)