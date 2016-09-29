---
title: "CDaoException::m_scode"
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
  - "CDaoException::m_scode"
  - "m_scode"
  - "CDaoException.m_scode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), getting error information"
  - "CDaoException class, m_scode for SCODE information"
  - "m_scode method"
  - "SCODE errors, getting DAO"
  - "exceptions, getting DAO SCODE information"
  - "errors [C++], SCODE getting in DAO"
  - "SCODE errors"
ms.assetid: f03ec453-b3fa-45d2-8680-664bd92a4303
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoException::m_scode
Contains a value of type `SCODE` that describes the error.  
  
## Remarks  
 This is an OLE code. You will seldom need to use this value because, in almost all cases, more specific MFC or DAO error information is available in the other `CDaoException` data members.  
  
 For information about `SCODE`, see the topic [Structure of OLE Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The `SCODE` data type maps to the `HRESULT` data type.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoException Class](../vs140/cdaoexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoException::m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md)   
 [CDaoException::m_nAfxDaoError](../vs140/cdaoexception--m_nafxdaoerror.md)