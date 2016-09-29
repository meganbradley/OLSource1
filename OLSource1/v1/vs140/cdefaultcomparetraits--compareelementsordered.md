---
title: "CDefaultCompareTraits::CompareElementsOrdered"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CDefaultCompareTraits::CompareElementsOrdered"
  - "CompareElementsOrdered"
  - "CDefaultCompareTraits::CompareElementsOrdered"
  - "ATL.CDefaultCompareTraits.CompareElementsOrdered"
  - "CDefaultCompareTraits.CompareElementsOrdered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElementsOrdered function"
ms.assetid: b5595088-3165-4c3e-9528-f3647ba93025
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultCompareTraits::CompareElementsOrdered
Call this function to determine the greater and lesser element.  
  
## Syntax  
  
```  
  
      static int CompareElementsOrdered(  
   const T& element1,  
   const T& element2   
);  
```  
  
#### Parameters  
 `element1`  
 The first element.  
  
 `element2`  
 The second element.  
  
## Return Value  
 Returns an integer based on the following table:  
  
|Condition|Return value|  
|---------------|------------------|  
|`element1` < `element2`|<0|  
|`element1` == `element2`|0|  
|`element1` > `element2`|>0|  
  
## Remarks  
 The default implementation of this function uses the `==`, **<**, and **>** operators. For objects other than simple data types, this function may need to be overridden.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CDefaultCompareTraits Class](../vs140/cdefaultcomparetraits-class.md)   
 [CDefaultCompareTraits::CompareElementsOrdered](../vs140/cdefaultcomparetraits--compareelementsordered.md)