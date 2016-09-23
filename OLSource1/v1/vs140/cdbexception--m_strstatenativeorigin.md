---
title: "CDBException::m_strStateNativeOrigin"
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
  - m_strStateNativeOrigin
  - CDBException.m_strStateNativeOrigin
  - CDBException::m_strStateNativeOrigin
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_strStateNativeOrigin
ms.assetid: 6a31311e-d2be-437a-939b-f5d33a6737a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBException::m_strStateNativeOrigin
Contains a string describing the error that caused the exception.  
  
## Remarks  
 The string is of the form "State:%s,Native:%ld,Origin:%s", where the format codes, in order, are replaced by values that describe:  
  
-   The **SQLSTATE**, a null-terminated string containing a five-character error code returned in the *szSqlState* parameter of the ODBC function **SQLError**. **SQLSTATE** values are listed in Appendix A, [ODBC Error Codes](https://msdn.microsoft.com/en-us/library/ms714687.aspx), in the *ODBC Programmer's Reference*. Example: "S0022".  
  
-   The native error code, specific to the data source, returned in the *pfNativeError* parameter of the **SQLError** function. Example: 207.  
  
-   The error message text returned in the *szErrorMsg* parameter of the **SQLError** function. This message consists of several bracketed names. As an error is passed from its source to the user, each ODBC component (data source, driver, Driver Manager) appends its own name. This information helps to pinpoint the origin of the error. Example: [Microsoft][ODBC SQL Server Driver][SQL Server]  
  
 The framework interprets the error string and puts its components into **m_strStateNativeOrigin**; if **m_strStateNativeOrigin** contains information for more than one error, the errors are separated by newlines. The framework puts the alphanumeric error text into **m_strError**.  
  
 For additional information about the codes used to make up this string, see the [SQLError](https://msdn.microsoft.com/en-us/library/ms716312.aspx) function in the *ODBC Programmer's Reference*.  
  
## Example  
 From ODBC: "State:S0022,Native:207,Origin:[Microsoft][ODBC SQL Server Driver][SQL Server] Invalid column name 'ColName'"  
  
 In **m_strStateNativeOrigin**: "State:S0022,Native:207,Origin:[Microsoft][ODBC SQL Server Driver][SQL Server]"  
  
 In **m_strError**: "Invalid column name 'ColName'"  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBException Class](../vs140/cdbexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBException::m_strError](../vs140/cdbexception--m_strerror.md)