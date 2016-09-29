---
title: "InlineIsEqualIUnknown"
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
  - "InlineIsEqualIUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InlineIsEqualIUnknown function"
ms.assetid: bb0be0a6-5b81-481d-856e-3aa076c69104
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InlineIsEqualIUnknown
Call this function, for the special case of testing for **IUnknown**.  
  
## Syntax  
  
```  
  
      BOOL InlineIsEqualUnknown(  
   REFGUID rguid1   
);  
```  
  
#### Parameters  
 *rguid1*  
 [in] The GUID to compare to **IID_IUnknown**.  
  
## See Also  
 [COM Map Global Functions](../VS_csharp/com-map-global-functions.md)