---
title: "CException Class"
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
  - "CException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchException class, base class"
  - "CException class"
  - "exceptions, classes for"
  - "CInternetException class, base class"
  - "macros, exception handling"
  - "CNotSupportedException class, base class"
  - "CFileException class, base class"
  - "CDBException class, base class"
  - "CArchiveException class, base class"
  - "CUserException class"
  - "CDaoException class, base class"
  - "CMemoryException class, base class"
  - "COleException class, base class"
  - "CResourceException class, base class"
ms.assetid: cfacf14d-bfe4-4666-a5c7-38b800512920
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CException Class
The base class for all exceptions in the Microsoft Foundation Class Library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CException::CException](#cexception__cexception)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CException::Delete](#cexception__delete)|Deletes a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|[CException::ReportError](#cexception__reporterror)|Reports an error message in a message box to the user.|  
  
## Remarks  
 Because <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an abstract base class you cannot create <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects directly; you must create objects of derived classes. If you need to create your own <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-style class, use one of the derived classes listed above as a model. Make sure that your derived class also uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The derived classes and their descriptions are listed below:  
  
|||  
|-|-|  
|[CSimpleException](../vs140/csimpleexception-class.md)|A base class for resource-critical MFC exceptions|  
|[CInvalidArgException](../vs140/cinvalidargexception-class.md)|Invalid argument exception condition|  
|[CMemoryException](../vs140/cmemoryexception-class.md)|Out-of-memory exception|  
|[CNotSupportedException](../vs140/cnotsupportedexception-class.md)|Request for an unsupported operation|  
|[CArchiveException](../vs140/carchiveexception-class.md)|Archive-specific exception|  
|[CFileException](../vs140/cfileexception-class.md)|File-specific exception|  
|[CResourceException](../vs140/cresourceexception-class.md)|Windows resource not found or not creatable|  
|[COleException](../vs140/coleexception-class.md)|OLE exception|  
|[CDBException](../vs140/cdbexception-class.md)|Database exception (that is, exception conditions arising for MFC database classes based on Open Database Connectivity)|  
|[COleDispatchException](../vs140/coledispatchexception-class.md)|OLE dispatch (automation) exception|  
|[CUserException](../vs140/cuserexception-class.md)|Exception that indicates that a resource could not be found|  
|[CDaoException](../vs140/cdaoexception-class.md)|Data access object exception (that is, exception conditions arising for DAO classes)|  
|[CInternetException](../vs140/cinternetexception-class.md)|Internet exception (that is, exception conditions arising for Internet classes).|  
  
 These exceptions are intended to be used with the [THROW](../vs140/throw--mfc-.md), [THROW_LAST](../vs140/throw_last.md), [TRY](../vs140/try.md), [CATCH](../vs140/catch.md), [AND_CATCH](../vs140/and_catch.md), and [END_CATCH](../vs140/end_catch.md) macros. For more information on exceptions, see [Exception Processing](../vs140/exception-processing.md), or see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
 To catch a specific exception, use the appropriate derived class. To catch all types of exceptions, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then use [CObject::IsKindOf](../vs140/cobject-class.md#cobject__iskindof) to differentiate among <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>-derived classes. Note that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> works only for classes declared with the [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md) macro, in order to take advantage of dynamic type checking. Any <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-derived class that you create should use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> macro, too.  
  
 You can report details about exceptions to the user by calling [GetErrorMessage](../vs140/cfileexception-class.md#cfileexception__geterrormessage) or [ReportError](#cexception__reporterror), two member functions that work with any of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>'s derived classes.  
  
 If an exception is caught by one of the macros, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is deleted automatically; do not delete it yourself. If an exception is caught by using a **catch** keyword, it is not automatically deleted. See the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md) for more information about when to delete an exeption object.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cexception__cexception">\</a>  CException::CException  
 This member function constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *b_AutoDelete*  
 Specify **TRUE** if the memory for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object has been allocated on the heap. This will cause the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to be deleted when the **Delete** member function is called to delete the exception. Specify **FALSE** if the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object is on the stack or is a global object. In this case, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object will not be deleted when the **Delete** member function is called.  
  
### Remarks  
 You would normally never need to call this constructor directly. A function that throws an exception should create an instance of a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>-derived class and call its constructor, or it should use one of the MFC throw functions, such as [AfxThrowFileException](../vs140/afxthrowfileexception.md), to throw a predefined type. This documentation is provided only for completeness.  
  
##  \<a name="cexception__delete">\</a>  CException::Delete  
 This function checks to see if the **CException** object was created on the heap, and if so, it calls the **delete** operator on the object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 When deleting a **CException** object, use the **Delete** member function to delete the exception. Do not use the **delete** operator directly, because the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object may be a global object or have been created on the stack.  
  
 You can specify whether the object should be deleted when the object is constructed. For more information, see [CException::CException](#cexception__cexception).  
  
 You only need to call **Delete** if you are using the C++ **try**- **catch** mechanism. If you are using the MFC macros **TRY** and **CATCH**, then these macros will automatically call this function.  
  
### Example  
 [!code[NVC_MFCExceptions#21](../vs140/codesnippet/CPP/cexception-class_1.cpp)]  
  
##  \<a name="cexception__reporterror">\</a>  CException::ReportError  
 Call this member function to report error text in a message box to the user.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the style of the message box. Apply any combination of the [message-box styles](../vs140/message-box-styles.md) to the box. If you don't specify this parameter, the default is **MB_OK**.  
  
 *nMessageID*  
 Specifies the resource ID (string table entry) of a message to display if the exception object does not have an error message. If 0, the message "No error message is available" is displayed.  
  
### Return Value  
 An <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value; otherwise 0 if there is not enough memory to display the message box. See [AfxMessageBox](../vs140/afxmessagebox.md) for the possible return values.  
  
### Example  
 Here is an example of the use of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For another example, see the example for [CATCH](../vs140/catch.md).  
  
 [!code[NVC_MFCExceptions#23](../vs140/codesnippet/CPP/cexception-class_2.cpp)]  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Exception Processing](../vs140/exception-processing.md)   
 [How Do I: Create my Own Custom Exception Classes?](http://go.microsoft.com/fwlink/?LinkId=128045)