---
title: "Exceptions: Database Exceptions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO [C++], exceptions"
  - "exceptions [C++], database"
  - "exception handling [C++], databases"
  - "ODBC exceptions [C++]"
  - "ODBC [C++], exceptions"
  - "database exceptions [C++]"
  - "databases [C++], exception handling"
  - "error codes [C++], database exception handling"
ms.assetid: 28daf260-f824-4be6-aecc-1f859e6dec26
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: Database Exceptions
This article explains how to handle database exceptions. Most of the material in this article applies whether you are working with the MFC classes for Open Database Connectivity (ODBC) or the MFC classes for Data Access Objects (DAO). Material specific to one or the other model is explicitly marked. Topics include:  
  
-   [Approaches to exception handling](#_core_approaches_to_exception_handling)  
  
-   [A database exception-handling example](#_core_a_database_exception.2d.handling_example)  
  
##  \<a name="_core_approaches_to_exception_handling"></a> Approaches to Exception Handling  
 The approach is the same whether you are working with DAO or ODBC.  
  
 You should always write exception handlers to handle exceptional conditions.  
  
 The most pragmatic approach to catching database exceptions is to test your application with exception scenarios. Determine the likely exceptions that might occur for an operation in your code, and force the exception to occur. Then examine the trace output to see what exception is thrown, or examine the returned error information in the debugger. This lets you know which return codes you'll see for the exception scenarios you are using.  
  
### Error Codes Used for ODBC Exceptions  
 In addition to return codes defined by the framework, which have names of the form **AFX_SQL_ERROR_XXX**, some [CDBExceptions](../vs140/cdbexception-class.md) are based on [ODBC](../vs140/odbc-basics.md) return codes. The return codes for such exceptions have names of the form **SQL_ERROR_XXX**.  
  
 The return codes — both framework-defined and ODBC-defined — that the database classes can return are documented under the [m_nRetCode](../vs140/cdbexception--m_nretcode.md) data member of class `CDBException`. Additional information about return codes defined by ODBC is available in the ODBC SDK *Programmer's Reference* in the MSDN Library.  
  
### Error Codes Used for DAO Exceptions  
 For DAO exceptions, more information is typically available. You can access error information through three data members of a caught [CDaoException](../vs140/cdaoexception-class.md) object:  
  
-   [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md) contains a pointer to a [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) object that encapsulates error information in DAO's collection of error objects associated with the database.  
  
-   [m_nAfxDaoError](../vs140/cdaoexception--m_nafxdaoerror.md) contains an extended error code from the MFC DAO classes. These error codes, which have names of the form **AFX_DAO_ERROR_XXX**, are documented under the data member in `CDaoException`.  
  
-   [m_scode](../vs140/cdaoexception--m_scode.md) contains an OLE `SCODE` from DAO, if applicable. You'll seldom need to work with this error code, however. Usually more information is available in the other two data members. See the data member for more about `SCODE` values.  
  
 Additional information about DAO errors, the DAO Error object type, and the DAO Errors collection is available under class [CDaoException](../vs140/cdaoexception-class.md).  
  
##  \<a name="_core_a_database_exception.2d.handling_example"></a> A Database Exception-Handling Example  
 The following example attempts to construct a [CRecordset](../vs140/crecordset-class.md)-derived object on the heap with the **new** operator, and then open the recordset (for an ODBC data source). For a similar example for the DAO classes, see "DAO Exception Example" below.  
  
### ODBC Exception Example  
 The [Open](../vs140/crecordset--open.md) member function could throw an exception (of type [CDBException](../vs140/cdbexception-class.md) for the ODBC classes), so this code brackets the **Open** call with a **try** block. The subsequent **catch** block will catch a `CDBException`. You could examine the exception object itself, called `e`, but in this case it is enough to know that the attempt to create a recordset has failed. The **catch** block displays a message box and cleans up by deleting the recordset object.  
  
 [!code[NVC_MFCDatabase#36](../vs140/codesnippet/CPP/exceptions--database-exceptions_1.cpp)]  
  
### DAO Exception Example  
 The DAO example is similar to the example for ODBC, but you can typically retrieve more kinds of information. The following code also attempts to open a recordset. If that attempt throws an exception, you can examine a data member of the exception object for error information. As with the previous ODBC example, it is probably enough to know that the attempt to create a recordset failed.  
  
 [!code[NVC_MFCDatabase#37](../vs140/codesnippet/CPP/exceptions--database-exceptions_2.cpp)]  
  
 This code gets an error message string from the [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md) member of the exception object. MFC fills this member when it throws the exception.  
  
 For a discussion of the error information returned by a `CDaoException` object, see classes [CDaoException](../vs140/cdaoexception-class.md) and [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md).  
  
 When you are working with Microsoft Jet (.mdb) databases, and in most cases when you are working with ODBC, there will be only one error object. In the rare case when you are using an ODBC data source and there are multiple errors, you can loop through DAO's Errors collection based on the number of errors returned by [CDaoException::GetErrorCount](../vs140/cdaoexception--geterrorcount.md). Each time through the loop, call [CDaoException::GetErrorInfo](../vs140/cdaoexception--geterrorinfo.md) to refill the `m_pErrorInfo` data member.  
  
## See Also  
 [Exception Handling](../vs140/exception-handling-in-mfc.md)