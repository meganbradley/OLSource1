---
title: "_ATL_DEBUG_QI"
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
  - "ATL::_ATL_DEBUG_QI"
  - "ATL._ATL_DEBUG_QI"
  - "_ATL_DEBUG_QI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATL_DEBUG_QI macro"
  - "ATL_DEBUG_QI macro"
ms.assetid: 4f1feddf-1469-42ad-a2f7-5a816d1c0bc5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_DEBUG_QI
Writes all calls to `QueryInterface` to the output window.  
  
## Syntax  
  
```  
  
#define _ATL_DEBUG_QI  
  
```  
  
## Remarks  
 If a call to `QueryInterface` failed, the output window will display:  
  
 *interface name* - `failed`  
  
## See Also  
 [Debugging and Error Reporting Macros](../VS_csharp/debugging-and-error-reporting-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)