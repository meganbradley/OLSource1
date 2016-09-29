---
title: "COleException::m_sc"
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
  - "m_sc"
  - "COleException::m_sc"
  - "COleException.m_sc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleException class, data members"
  - "m_sc"
ms.assetid: cdefe0c2-0139-4b9e-975a-530e8261c2be
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleException::m_sc
This data member holds the OLE status code that indicates the reason for the exception.  
  
## Syntax  
  
```  
  
SCODE m_sc;  
```  
  
## Remarks  
 This variable's value is set by [AfxThrowOleException](../vs140/afxthrowoleexception.md).  
  
 For more information on `SCODE`, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCOleContainer#22](../vs140/codesnippet/CPP/coleexception--m_sc_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleException Class](../vs140/coleexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxThrowOleException](../vs140/afxthrowoleexception.md)