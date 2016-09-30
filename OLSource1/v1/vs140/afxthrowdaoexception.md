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
Call this function to throw an exception of type [CDaoException](../vs140/cdaoexception-class.md) from your own code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer value representing a DAO extended error code, which can be one of the values listed under [CDaoException::m_nAfxDaoError](../vs140/cdaoexception--m_nafxdaoerror.md).  
  
 *scode*  
 An OLE error code from DAO, of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For information, see [CDaoException::m_scode](../vs140/cdaoexception--m_scode.md).  
  
## Remarks  
 The framework also calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. In your call, you can pass one of the parameters or both. For example, if you want to raise one of the errors defined in **CDaoException::nAfxDaoError** but you do not care about the *scode* parameter, pass a valid code in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter and accept the default value for *scode*.  
  
 For information about exceptions related to the MFC DAO classes, see class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in this book and the article [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CException Class](../vs140/cexception-class.md)