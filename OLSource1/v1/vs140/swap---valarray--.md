---
title: "swap (&lt;valarray&gt;)"
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
  - "std.swap"
  - "std::swap"
  - "valarray/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: 1fc8dd13-ef62-4679-adae-b912621fcf8c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (&lt;valarray&gt;)
Exchanges the elements of two valarrays.  
  
## Syntax  
  
```  
template<class Type>  
    void swap(  
        valarray<Type>& _Left,  
        valarray<Type>& _Right  
    );  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|An object of type `valarray`.|  
|`_Right`|An object of type `valarray`.|  
  
## Remarks  
 The template function executes `_Left.swap(_Right)`.  
  
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [\<valarray>](../vs140/-valarray-.md)   
 [Header Files Reference](../vs140/c---standard-library-header-files.md)