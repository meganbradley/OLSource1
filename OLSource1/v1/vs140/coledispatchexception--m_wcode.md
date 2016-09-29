---
title: "COleDispatchException::m_wCode"
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
  - "COleDispatchException::m_wCode"
  - "COleDispatchException.m_wCode"
  - "m_wCode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchException class, data members"
  - "m_wCode"
ms.assetid: 53886b7f-cf3a-44c0-a1df-1f4dfec65e74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchException::m_wCode
Contains an error code specific to your application.  
  
## Syntax  
  
```  
  
WORD m_wCode;  
```  
  
## Remarks  
 This member is set by the function [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) when an exception is thrown.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchException Class](../vs140/coledispatchexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchException::m_strDescription](../vs140/coledispatchexception--m_strdescription.md)   
 [COleDispatchException::m_dwHelpContext](../vs140/coledispatchexception--m_dwhelpcontext.md)   
 [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md)