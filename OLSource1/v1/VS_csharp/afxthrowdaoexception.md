---
title: "AfxThrowDaoException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXDAO/AfxThrowDaoException"
  - "AfxThrowDaoException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxThrowDaoException function"
  - "exceptions, throwing"
  - "throwing exceptions"
ms.assetid: f1b0a19f-a130-4c80-ba06-445b7919f037
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowDaoException
Call this function to throw an exception of type [CDaoException](../VS_csharp/cdaoexception-class.md) from your own code.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxThrowDaoException(  
   int nAfxDaoError = NO_AFX_DAO_ERROR,  
   SCODE scode = S_OK   
);  
```  
  
#### Parameters  
 `nAfxDaoError`  
 An integer value representing a DAO extended error code, which can be one of the values listed under [CDaoException::m_nAfxDaoError](../Topic/CDaoException::m_nAfxDaoError.md).  
  
 *scode*  
 An OLE error code from DAO, of type `SCODE`. For information, see [CDaoException::m_scode](../Topic/CDaoException::m_scode.md).  
  
## Remarks  
 The framework also calls `AfxThrowDaoException`. In your call, you can pass one of the parameters or both. For example, if you want to raise one of the errors defined in **CDaoException::nAfxDaoError** but you do not care about the *scode* parameter, pass a valid code in the `nAfxDaoError` parameter and accept the default value for *scode*.  
  
 For information about exceptions related to the MFC DAO classes, see class `CDaoException` in this book and the article [Exceptions: Database Exceptions](../VS_csharp/exceptions--database-exceptions.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CException Class](../VS_csharp/cexception-class.md)