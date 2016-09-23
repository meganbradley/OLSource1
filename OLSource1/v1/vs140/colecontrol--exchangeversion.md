---
title: "COleControl::ExchangeVersion"
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
  - ExchangeVersion
  - COleControl.ExchangeVersion
  - COleControl::ExchangeVersion
dev_langs: 
  - C++
helpviewer_keywords: 
  - ExchangeVersion method
ms.assetid: 57812e57-e379-44a4-b842-27f66e5aed9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::ExchangeVersion
Serializes or initializes the state of a control's version information.  
  
## Syntax  
  
```  
  
      BOOL ExchangeVersion(  
   CPropExchange* pPX,  
   DWORD dwVersionDefault,  
   BOOL bConvert = TRUE   
);  
```  
  
#### Parameters  
 `pPX`  
 A pointer to a `CPropExchange` object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
 `dwVersionDefault`  
 The current version number of the control.  
  
 `bConvert`  
 Indicates whether persistent data should be converted to the latest format when saved, or maintained in the same format that was loaded.  
  
## Return Value  
 Nonzero of the function succeeded; 0 otherwise.  
  
## Remarks  
 Typically, this will be the first function called by a control's override of `COleControl::DoPropExchange`. When loading, this function reads the version number of the persistent data, and sets the version attribute of the [CPropExchange](../vs140/cpropexchange-class.md) object accordingly. When saving, this function writes the version number of the persistent data.  
  
 For more information on persistence and versioning, see the article [ActiveX Controls: Serializing](../vs140/mfc-activex-controls--serializing.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)