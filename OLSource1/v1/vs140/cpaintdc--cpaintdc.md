---
title: "CPaintDC::CPaintDC"
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
  - "CPaintDC.CPaintDC"
  - "CPaintDC::CPaintDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaintDC class, constructor"
  - "CPaintDC class, construction/destruction"
ms.assetid: 85ad20f4-f348-4bd8-8c94-9a9da802fe5f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaintDC::CPaintDC
Constructs a `CPaintDC` object, prepares the application window for painting, and stores the [PAINTSTRUCT](../vs140/paintstruct-structure.md) structure in the [m_ps](../vs140/cpaintdc--m_ps.md) member variable.  
  
## Syntax  
  
```  
  
      explicit CPaintDC(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the `CWnd` object to which the `CPaintDC` object belongs.  
  
## Remarks  
 An exception (of type `CResourceException`) is thrown if the Windows [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
## Example  
 [!code[NVC_MFCDocView#97](../vs140/codesnippet/CPP/cpaintdc--cpaintdc_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPaintDC Class](../vs140/cpaintdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)