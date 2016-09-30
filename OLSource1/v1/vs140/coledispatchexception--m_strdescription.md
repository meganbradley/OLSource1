---
title: "COleDispatchException::m_strDescription"
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
  - "m_strDescription"
  - "COleDispatchException.m_strDescription"
  - "COleDispatchException::m_strDescription"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchException class, data members"
  - "m_strDescription"
ms.assetid: 03326be7-b43d-46eb-b78c-0de34ce453c0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchException::m_strDescription
Contains a verbal error description, such as "Disk full."  
  
## Syntax  
  
```  
  
CString m_strDescription;  
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
 [COleDispatchException::m_dwHelpContext](../vs140/coledispatchexception--m_dwhelpcontext.md)   
 [COleDispatchException::m_wCode](../vs140/coledispatchexception--m_wcode.md)   
 [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md)