---
title: "CClientDC::CClientDC"
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
  - "CClientDC::CClientDC"
  - "CClientDC.CClientDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CClientDC class, construction/destruction"
  - "CClientDC class, constructor"
ms.assetid: 358e9e43-bae6-48fb-a999-8f3a51fb8e9b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CClientDC::CClientDC
Constructs a `CClientDC` object that accesses the client area of the [CWnd](../vs140/cwnd-class.md) pointed to by `pWnd`.  
  
## Syntax  
  
```  
  
      explicit CClientDC(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 The window whose client area the device context object will access.  
  
## Remarks  
 The constructor calls the Windows function [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871).  
  
 An exception (of type `CResourceException`) is thrown if the Windows `GetDC` call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
## Example  
 [!code[NVC_MFCDocView#42](../vs140/codesnippet/CPP/cclientdc--cclientdc_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CClientDC Class](../vs140/cclientdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)