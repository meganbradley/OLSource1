---
title: "COleVariant::ChangeType"
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
  - "COleVariant.ChangeType"
  - "COleVariant::ChangeType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChangeType method"
ms.assetid: a676151c-fbb7-4137-a7d4-4e2cd1145b19
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::ChangeType
Converts the type of variant value in this `COleVariant` object.  
  
## Syntax  
  
```  
  
      void ChangeType(  
   VARTYPE vartype,  
   LPVARIANT pSrc = NULL   
);  
```  
  
#### Parameters  
 `vartype`  
 The [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) for this `COleVariant` object.  
  
 `pSrc`  
 A pointer to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object to be converted. If this value is **NULL**, this `COleVariant` object is used as the source for the conversion.  
  
## Remarks  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4), and [VariantChangeType](assetId:///48a51e32-95d7-4eeb-8106-f5043ffa2fd1) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator =](../vs140/colevariant--operator-=.md)