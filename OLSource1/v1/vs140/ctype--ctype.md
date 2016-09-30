---
title: "ctype::ctype"
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
  - "ctype"
  - "ctype::ctype"
  - "xlocale/std::ctype::ctype"
  - "std.ctype.ctype"
  - "ctype.ctype"
  - "CType"
  - "std::ctype::ctype"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ctype class, constructor"
  - "ctype typedef"
  - "ctype method"
ms.assetid: 9b60a120-9d16-4f68-8d80-1aeace584c5c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::ctype
Constructor for objects of class ctype that serve as locale facets for characters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
## Remarks  
 The possible values for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> base object with **locale::**[facet](../vs140/facet-class.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)