---
title: "CDatabase::m_hdbc"
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
  - "CDatabase.m_hdbc"
  - "CDatabase::m_hdbc"
  - "m_hdbc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, data members"
  - "m_hdbc"
ms.assetid: 8f24d05e-7c65-443e-b2cb-f88bfaf48e32
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::m_hdbc
Contains a public handle to an ODBC data source connection — a "connection handle."  
  
## Remarks  
 Normally, you will have no need to access this member variable directly. Instead, the framework allocates the handle when you call <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or **Open**. The framework deallocates the handle when you call the **delete** operator on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. Note that the **Close** member function does not deallocate the handle.  
  
 Under some circumstances, however, you may need to use the handle directly. For example, if you need to call ODBC API functions directly rather than through class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you may need a connection handle to pass as a parameter. See the code example below.  
  
## Example  
 [!code[NVC_MFCDatabase#15](../vs140/codesnippet/CPP/cdatabase--m_hdbc_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OpenEx](../vs140/cdatabase--openex.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)   
 [CDatabase::Close](../vs140/cdatabase--close.md)