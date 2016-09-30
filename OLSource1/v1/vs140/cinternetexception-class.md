---
title: "CInternetException Class"
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
  - "CInternetException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception handling, Internet operations"
  - "exceptions, Internet"
  - "CInternetException class"
ms.assetid: 44fb3cbe-523e-4754-8843-a77909990b14
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetException Class
Represents an exception condition related to an Internet operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetException::CInternetException](#cinternetexception__cinternetexception)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetException::m_dwContext](#cinternetexception__m_dwcontext)|The context value associated with the operation that caused the exception.|  
|[CInternetException::m_dwError](#cinternetexception__m_dwerror)|The error that caused the exception.|  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class includes two public data members: one holds the error code associated with the exception, and the other holds the context identifier of the Internet application associated with the error.  
  
 For more information about context identifiers for Internet applications, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cinternetexception__cinternetexception">\</a>  CInternetException::CInternetException  
 This member function is called when a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is created.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The error that caused the exception.  
  
### Remarks  
 To throw a CInternetException, call the MFC global function [AfxThrowInternetException](../vs140/afxthrowinternetexception.md).  
  
##  \<a name="cinternetexception__m_dwcontext">\</a>  CInternetException::m_dwContext  
 The context value associated with the related Internet operation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The context identifier is originally specified in [CInternetSession](../vs140/cinternetsession-class.md) and passed by MFC to [CInternetConnection](../vs140/cinternetconnection-class.md)- and [CInternetFile](../vs140/cinternetfile-class.md)-derived classes. You can override this default and assign any <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter a value of your choosing. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is associated with any operation of the given object. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback).  
  
##  \<a name="cinternetexception__m_dwerror">\</a>  CInternetException::m_dwError  
 The error that caused the exception.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This error value may be a system error code, found in WINERROR.H, or an error value from WININET.H.  
  
 For a list of Win32 error codes, see                         [Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms681381). For a list of Internet-specific error messages, see  . Both topics are in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException](../vs140/cexception-class.md)