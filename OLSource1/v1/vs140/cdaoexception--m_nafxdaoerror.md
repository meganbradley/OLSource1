---
title: "CDaoException::m_nAfxDaoError"
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
  - AFX_DAO_ERROR_OBJECT_NOT_OPEN
  - m_nAfxDaoError
  - AFX_DAO_ERROR_DFX_BIND
  - CDaoException::m_nAfxDaoError
  - AFX_DAO_ERROR_ENGINE_INITIALIZATION
  - NO_AFX_DAO_ERROR
  - CDaoException.m_nAfxDaoError
dev_langs: 
  - C++
helpviewer_keywords: 
  - NO_AFX_DAO_ERROR code
  - m_nAfxDaoError
  - DAO (Data Access Objects), getting error information
  - AFX_DAO_ERROR_DFX_BIND
  - AFX_DAO_ERROR_OBJECT_NOT_OPEN
  - errors [C++], MFC DAO
  - exceptions, getting error information
  - AFX_DAO_ERROR_ENGINE_INITIALIZATION
  - extended errors in MFC DAO
ms.assetid: 132aa890-f0b8-44ae-8cd3-82885974f107
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoException::m_nAfxDaoError
Contains an MFC extended error code.  
  
## Remarks  
 This code is supplied in cases where a specific component of the MFC DAO classes has erred.  
  
 Possible values are:  
  
-   **NO_AFX_DAO_ERROR** The most recent operation did not result in an MFC extended error. However, the operation could have produced other errors from DAO or OLE, so you should check [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md) and possibly [m_scode](../vs140/cdaoexception--m_scode.md).  
  
-   **AFX_DAO_ERROR_ENGINE_INITIALIZATION** MFC could not initialize the Microsoft Jet database engine. OLE might have failed to initialize, or it might have been impossible to create an instance of the DAO database engine object. These problems usually suggest a bad installation of either DAO or OLE.  
  
-   **AFX_DAO_ERROR_DFX_BIND** An address used in a DAO record field exchange (DFX) function call does not exist or is invalid (the address was not used to bind data). You might have passed a bad address in a DFX call, or the address might have become invalid between DFX operations.  
  
-   **AFX_DAO_ERROR_OBJECT_NOT_OPEN** You attempted to open a recordset based on a querydef or a tabledef object that was not in an open state.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoException Class](../vs140/cdaoexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoException::GetErrorCount](../vs140/cdaoexception--geterrorcount.md)   
 [CDaoException::GetErrorInfo](../vs140/cdaoexception--geterrorinfo.md)