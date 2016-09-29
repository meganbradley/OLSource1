---
title: "CPropExchange::ExchangeVersion"
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
  - "CPropExchange::ExchangeVersion"
  - "ExchangeVersion"
  - "CPropExchange.ExchangeVersion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropExchange class, operations"
  - "ExchangeVersion method"
ms.assetid: 62530e56-4386-478c-95df-ecde5b0517dc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropExchange::ExchangeVersion
Called by the framework to handle persistence of a version number.  
  
## Syntax  
  
```  
  
      virtual BOOL ExchangeVersion(  
   DWORD& dwVersionLoaded,  
   DWORD dwVersionDefault,  
   BOOL bConvert   
);  
```  
  
#### Parameters  
 *dwVersionLoaded*  
 Reference to a variable where the version number of the persistent data being loaded will be stored.  
  
 `dwVersionDefault`  
 The current version number of the control.  
  
 `bConvert`  
 Indicates whether to convert persistent data to the current version or keep it at the same version that was loaded.  
  
## Return Value  
 Nonzero if the function succeeded; 0 otherwise.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CPropExchange Class](../vs140/cpropexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::ExchangeVersion](../vs140/colecontrol--exchangeversion.md)