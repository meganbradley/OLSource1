---
title: "CDaoException::GetErrorInfo"
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
  - "m_pErrorInfo"
  - "GetErrorInfo"
  - "CDaoException::GetErrorInfo"
  - "CDaoException.GetErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetErrorInfo method"
  - "DAO (Data Access Objects), getting error information"
  - "errors [C++], getting information about DAO"
ms.assetid: 4183de78-d105-4b0c-81a9-68f1741e9e91
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoException::GetErrorInfo
Returns error information about a particular error object in the Errors collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the error information in the database engine's Errors collection, for lookup by index.  
  
## Remarks  
 Call this member function to obtain the following kinds of information about the exception:  
  
-   Error code  
  
-   Source  
  
-   Description  
  
-   Help file  
  
-   Help context  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> stores the information in the exception object's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member. For a brief description of the information returned, see [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md). If you catch an exception of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> thrown by MFC, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member will already be filled in. If you choose to call DAO directly, you must call the exception object's <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function yourself to fill <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For a more detailed description, see the [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) structure.  
  
 For information about DAO exceptions, and example code, see the article [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoException Class](../vs140/cdaoexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoException::GetErrorCount](../vs140/cdaoexception--geterrorcount.md)