---
title: "locale::category"
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
  - "std.locale.category"
  - "locale.category"
  - "std::locale::category"
  - "category"
  - "xlocale/std::locale::category"
  - "Category"
  - "locale::category"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "category typedef"
  - "category method"
ms.assetid: ad0a5af3-e893-436b-827e-8cb3d29db95a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::category
An integer type that provides bitmask values to denote standard facet families.  
  
## Syntax  
  
```  
typedef int category;  
static const int collate = LC_COLLATE;  
static const int ctype = LC_CTYPE;  
static const int monetary = LC_MONETARY;  
static const int numeric = LC_NUMERIC;  
static const int time = LC_TIME;  
static const int messages = LC_MESSAGES;  
static const int all = LC_ALL;  
static const int none = 0;  
```  
  
## Remarks  
 The type is a synonym for an `int` type that can represent a group of distinct elements of a bitmask type local to class locale or can be used to represent any of the corresponding C locale categories. The elements are:  
  
-   **collate**, corresponding to the C category LC_COLLATE  
  
-   **ctype**, corresponding to the C category LC_CTYPE  
  
-   **monetary**, corresponding to the C category LC_MONETARY  
  
-   **numeric**, corresponding to the C category LC_NUMERIC  
  
-   **time**, corresponding to the C category LC_TIME  
  
-   **messages**, corresponding to the Posix category LC_MESSAGES  
  
 In addition, two useful values are:  
  
-   **none**, corresponding to none of the C categories  
  
-   **all**, corresponding to the C union of all categories LC_ALL  
  
 You can represent an arbitrary group of categories by using `OR` with these constants, as in **monetary** &#124; **time**.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)