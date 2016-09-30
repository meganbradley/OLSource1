---
title: "AfxThrowDBException"
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
  - "AFXDB/AfxThrowDBException"
  - "AfxThrowDBException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception-throwing functions"
  - "AfxThrowDBException function"
ms.assetid: f086d61b-56dc-4d3a-a273-b3c62986e195
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowDBException
Call this function to throw an exception of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> from your own code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value of type **RETCODE**, defining the type of error that caused the exception to be thrown.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that represents the data source connection with which the exception is associated.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An ODBC **HSTMT** handle that specifies the statement handle with which the exception is associated.  
  
## Remarks  
 The framework calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when it receives an ODBC **RETCODE** from a call to an ODBC API function and interprets the **RETCODE** as an exceptional condition rather than an expectable error. For example, a data access operation might fail because of a disk read error.  
  
 For information about the **RETCODE** values defined by ODBC, see Chapter 8, "Retrieving Status and Error Information," in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For information about MFC extensions to these codes, see class [CDBException](../vs140/cdbexception-class.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CDBException::m_nRetCode](../vs140/cdbexception--m_nretcode.md)