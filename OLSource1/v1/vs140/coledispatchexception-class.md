---
title: "COleDispatchException Class"
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
  - "COleDispatchException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchException class"
  - "Automation, exceptions"
  - "exceptions, OLE"
  - "OLE exceptions, to IDispatch interface"
ms.assetid: 0e95c8be-e21a-490c-99ec-181c6a9a26d0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchException Class
Handles exceptions specific to the OLE <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface, which is a key part of OLE automation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchException::m_dwHelpContext](#coledispatchexception__m_dwhelpcontext)|Help context for error.|  
|[COleDispatchException::m_strDescription](#coledispatchexception__m_strdescription)|Verbal error description.|  
|[COleDispatchException::m_strHelpFile](#coledispatchexception__m_strhelpfile)|Help file to use with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[COleDispatchException::m_strSource](#coledispatchexception__m_strsource)|Application that generated the exception.|  
|[COleDispatchException::m_wCode](#coledispatchexception__m_wcode)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-specific error code.|  
  
## Remarks  
 Like the other exception classes derived from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> base class, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be used with the **THROW**, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, **TRY**, **CATCH**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> macros.  
  
 In general, you should call [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) to create and throw a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
 For more information on exceptions, see the articles [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md) and [Exceptions: OLE Exceptions](../vs140/exceptions--ole-exceptions.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="coledispatchexception__m_dwhelpcontext">\</a>  COleDispatchException::m_dwHelpContext  
 Identifies a help context in your application's help (.HLP) file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This member is set by the function [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) when an exception is thrown.  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver-class.md#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchexception__m_strdescription">\</a>  COleDispatchException::m_strDescription  
 Contains a verbal error description, such as "Disk full."  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This member is set by the function [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) when an exception is thrown.  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver-class.md#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchexception__m_strhelpfile">\</a>  COleDispatchException::m_strHelpFile  
 The framework fills in this string with the name of the application's help file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="coledispatchexception__m_strsource">\</a>  COleDispatchException::m_strSource  
 The framework fills in this string with the name of the application that generated the exception.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver-class.md#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchexception__m_wcode">\</a>  COleDispatchException::m_wCode  
 Contains an error code specific to your application.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This member is set by the function [AfxThrowOleDispatchException](../vs140/afxthrowoledispatchexception.md) when an exception is thrown.  
  
## See Also  
 [MFC Sample CALCDRIV](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver](../vs140/coledispatchdriver-class.md)   
 [COleException](../vs140/coleexception-class.md)