---
title: "COleVariant::Clear"
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
  - "COleVariant::Clear"
  - "COleVariant.Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clear method"
ms.assetid: 56b74164-9f7c-4dff-af8f-1a4db3878b6a
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::Clear
Clears the **VARIANT**.  
  
## Syntax  
  
```  
  
void Clear( );  
  
```  
  
## Remarks  
 This sets the **VARTYPE** for this object to `VT_EMPTY`. The `COleVariant` destructor calls this function.  
  
 For more information, see the `VARIANT`, `VARTYPE`, and `VariantClear` entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)