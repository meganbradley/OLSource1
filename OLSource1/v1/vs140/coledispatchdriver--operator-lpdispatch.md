---
title: "COleDispatchDriver::operator LPDISPATCH"
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
  - LPDISPATCH
  - COleDispatchDriver.operatorLPDISPATCH
  - COleDispatchDriver::LPDISPATCH
  - COleDispatchDriver.LPDISPATCH
  - operatorLPDISPATCH
  - COleDispatchDriver::operatorLPDISPATCH
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator LPDISPATCH
  - LPDISPATCH operator
ms.assetid: 66dda3bc-d2c5-45dd-90ee-377bc18c19d7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDispatchDriver::operator LPDISPATCH
Accesses the underlying `IDispatch` pointer of the `COleDispatchDriver` object.  
  
## Syntax  
  
```  
  
operator LPDISPATCH( );  
  
```  
  
## Example  
 [!code[NVC_MFCOleContainer#8](../vs140/codesnippet/CPP/coledispatchdriver--operator-lpdispatch_1.cpp)]
  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md)