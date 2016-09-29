---
title: "COleControl::ExchangeStockProps"
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
  - "ExchangeStockProps"
  - "COleControl.ExchangeStockProps"
  - "COleControl::ExchangeStockProps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExchangeStockProps method"
ms.assetid: 0973f25d-aaf4-4d1c-87e5-1055ae40dbaa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::ExchangeStockProps
Serializes or initializes the state of the control's stock properties.  
  
## Syntax  
  
```  
  
      void ExchangeStockProps(  
   CPropExchange* pPX   
);  
```  
  
#### Parameters  
 `pPX`  
 A pointer to a [CPropExchange](../vs140/cpropexchange-class.md) object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
## Remarks  
 This function is normally called by the default implementation of `COleControl::DoPropExchange`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)