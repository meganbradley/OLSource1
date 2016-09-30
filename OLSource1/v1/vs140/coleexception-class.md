---
title: "COleException Class"
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
  - "COleException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleException class"
  - "exceptions, OLE"
ms.assetid: 2571e9fe-26cc-42f0-9ad9-8ad5b4311ec1
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleException Class
Represents an exception condition related to an OLE operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleException::Process](#coleexception__process)|Translates a caught exception into an OLE return code.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleException::m_sc](#coleexception__m_sc)|Contains the status code that indicates the reason for the exception.|  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class includes a public data member that holds the status code indicating the reason for the exception.  
  
 In general, you should not create a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object directly; instead, you should call [AfxThrowOleException](../vs140/afxthrowoleexception.md).  
  
 For more information on exceptions, see the articles [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md) and [Exceptions: OLE Exceptions](../vs140/exceptions--ole-exceptions.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="coleexception__m_sc">\</a>  COleException::m_sc  
 This data member holds the OLE status code that indicates the reason for the exception.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This variable's value is set by [AfxThrowOleException](../vs140/afxthrowoleexception.md).  
  
 For more information on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#22](../vs140/codesnippet/CPP/coleexception-class_1.cpp)]  
  
##  \<a name="coleexception__process">\</a>  COleException::Process  
 Call the **Process** member function to translate a caught exception into an OLE status code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pAnyException*  
 Pointer to a caught exception.  
  
### Return Value  
 An OLE status code.  
  
### Remarks  
  
> [!NOTE]
>  This function is **static**.  
  
 For more information on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver-class.md#coledispatchdriver__createdispatch).  
  
## See Also  
 [MFC Sample CALCDRIV](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)