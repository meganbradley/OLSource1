---
title: "COleDispatchException::m_dwHelpContext"
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
  - "COleDispatchException.m_dwHelpContext"
  - "m_dwHelpContext"
  - "COleDispatchException::m_dwHelpContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwHelpContext"
  - "COleDispatchException class, data members"
ms.assetid: 4dd046ea-c5c8-4073-b665-6ecc93f06663
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchException::m_dwHelpContext
Identifies a help context in your application's help (.HLP) file.  
  
## Syntax  
  
```  
  
DWORD m_dwHelpContext;  
```  
  
## Remarks  
 This member is set by the function [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) when an exception is thrown.  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchException Class](../vs140/coledispatchexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchException::m_strDescription](../vs140/coledispatchexception--m_strdescription.md)   
 [COleDispatchException::m_wCode](../vs140/coledispatchexception--m_wcode.md)   
 [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md)