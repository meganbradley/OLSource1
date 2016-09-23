---
title: "COleVariant::Attach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleVariant.Attach
  - COleVariant::Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [MFC]
ms.assetid: e1b11b7b-9f06-4c7d-a6bf-48a4ef4673ba
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleVariant::Attach
Call this function to attach the given [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object to the current `COleVariant` object.  
  
## Syntax  
  
```  
  
      void Attach(  
   VARIANT& varSrc   
);  
```  
  
#### Parameters  
 *varSrc*  
 An existing **VARIANT** object to be attached to the current `COleVariant` object.  
  
## Remarks  
 This function sets the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) of *varSrc* to `VT_EMPTY`.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) and [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator LPCVARIANT](../vs140/colevariant--operator-lpcvariant.md)   
 [COleVariant::operator LPVARIANT](../vs140/colevariant--operator-lpvariant.md)