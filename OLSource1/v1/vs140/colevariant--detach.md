---
title: "COleVariant::Detach"
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
  - "COleVariant::Detach"
  - "COleVariant.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: e77a07bf-42dd-4486-90c8-fee15f5a3944
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::Detach
Detaches the underlying [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object from this `COleVariant` object.  
  
## Syntax  
  
```  
  
VARIANT Detach( );  
  
```  
  
## Return Type  
 The underlying **VARIANT** value of this `COleVariant` object.  
  
## Remarks  
 This function sets the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) for this `COleVariant` object to `VT_EMPTY`.  
  
> [!NOTE]
>  After calling **Detach**, it is the caller's responsibility to call **VariantClear** on the resulting **VARIANT** structure.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4), and [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator LPCVARIANT](../vs140/colevariant--operator-lpcvariant.md)   
 [COleVariant::operator LPVARIANT](../vs140/colevariant--operator-lpvariant.md)