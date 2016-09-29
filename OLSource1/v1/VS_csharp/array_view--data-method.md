---
title: "array_view::data Method"
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
  - "amp/Concurrency::array_view::data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data method"
ms.assetid: 5a834362-19e5-49be-88c0-25ddf978a2f4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::data Method
Returns a pointer to the raw data of the [array_view](../VS_csharp/array_view-class.md).  
  
## Syntax  
  
```  
_Value_type* data() const restrict(amp,cpu);  
  
const _Value_type* data() const restrict(amp,cpu);  
```  
  
## Return Value  
 A pointer to the raw data of the `array_view`.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../VS_csharp/array_view-class.md)