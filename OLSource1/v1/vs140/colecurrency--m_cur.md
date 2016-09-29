---
title: "COleCurrency::m_cur"
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
  - "COleCurrency.m_cur"
  - "COleCurrency::m_cur"
  - "m_cur"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_cur"
  - "COleCurrency class, data members"
ms.assetid: d5eb1810-88e8-46d2-b4f1-ae1ce6ab466d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::m_cur
The underlying [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) structure for this **COleCurrency** object.  
  
## Remarks  
  
> [!CAUTION]
>  Changing the value in the **CURRENCY** structure accessed by the pointer returned by this function will change the value of this **COleCurrency** object. It does not change the status of this **COleCurrency** object.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::COleCurrency](../vs140/colecurrency--colecurrency.md)   
 [COleCurrency::operator CURRENCY](../vs140/colecurrency--operator-currency.md)   
 [COleCurrency::SetCurrency](../vs140/colecurrency--setcurrency.md)