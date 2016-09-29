---
title: "_ATL_NO_AUTOMATIC_NAMESPACE"
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
  - "ATL::_ATL_NO_AUTOMATIC_NAMESPACE"
  - "ATL._ATL_NO_AUTOMATIC_NAMESPACE"
  - "_ATL_NO_AUTOMATIC_NAMESPACE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_NO_AUTOMATIC_NAMESPACE macro"
  - "_ATL_NO_AUTOMATIC_NAMESPACE macro"
ms.assetid: 99497aa3-e127-45ed-a69d-6644c4b7496a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_NO_AUTOMATIC_NAMESPACE
A symbol which prevents the default use of namespace as ATL.  
  
## Syntax  
  
```  
  
_ATL_NO_AUTOMATIC_NAMESPACE  
  
```  
  
## Remarks  
 If this symbol is not defined, including atlbase.h will perform **using namespace ATL** by default, which may lead to naming conflicts. To prevent this, define this symbol.  
  
## See Also  
 [Compiler Options Macros](../VS_csharp/compiler-options-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)