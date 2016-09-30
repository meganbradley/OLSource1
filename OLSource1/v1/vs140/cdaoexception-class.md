---
title: "CDaoException Class"
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
  - "CDaoException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "errors [C++], DAO"
  - "CDaoException class"
  - "DAO (Data Access Objects), exceptions"
  - "exceptions, in MFC DAO classes"
  - "Errors collection, DAO"
  - "collections, DAO errors"
ms.assetid: b2b01fa9-7ce2-42a1-842e-40f13dc50da4
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoException Class
Represents an exception condition arising from the MFC database classes based on data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoException::CDaoException](#cdaoexception__cdaoexception)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoException::GetErrorCount](#cdaoexception__geterrorcount)|Returns the number of errors in the database engine's Errors collection.|  
|[CDaoException::GetErrorInfo](#cdaoexception__geterrorinfo)|Returns error information about a particular error object in the Errors collection.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoException::m_nAfxDaoError](#cdaoexception__m_nafxdaoerror)|Contains an extended error code for any error in the MFC DAO classes.|  
|[CDaoException::m_pErrorInfo](#cdaoexception__m_perrorinfo)|A pointer to a [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) object that contains information about one DAO error object.|  
|[CDaoException::m_scode](#cdaoexception__m_scode)|The [SCODE](#cdaoexception__m_scode) value associated with the error.|  
  
## Remarks  
 The class includes public data members you can use to determine the cause of the exception. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects are constructed and thrown by member functions of the DAO database classes.  
  
> [!NOTE]
>  The DAO database classes are distinct from the MFC database classes based on Open Database Connectivity (ODBC). All DAO database class names have the "CDao" prefix. You can still access ODBC data sources with the DAO classes. In general, the MFC classes based on DAO are more capable than the MFC classes based on ODBC; the DAO-based classes can access data, including through ODBC drivers, via their own database engine. The DAO-based classes also support Data Definition Language (DDL) operations, such as adding tables via the classes, without having to call DAO directly. For information on exceptions thrown by the ODBC classes, see [CDBException](../vs140/cdbexception-class.md).  
  
 You can access exception objects within the scope of a [CATCH](../vs140/catch.md) expression. You can also throw <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects from your own code with the [AfxThrowDaoException](../vs140/afxthrowdaoexception.md) global function.  
  
 In MFC, all DAO errors are expressed as exceptions, of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. When you catch an exception of this type, you can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member functions to retrieve information from any DAO error objects stored in the database engine's Errors collection. As each error occurs, one or more error objects are placed in the Errors collection. (Normally the collection contains only one error object; if you are using an ODBC data source, you are more likely to get multiple error objects.) When another DAO operation generates an error, the Errors collection is cleared, and the new error object is placed in the Errors collection. DAO operations that do not generate an error have no effect on the Errors collection.  
  
 For DAO error codes, see the file DAOERR.H. For related information, see the topic "Trappable Data Access Errors" in DAO Help.  
  
 For more information about exception handling in general, or about <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects, see the articles [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md) and [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md). The second article contains example code that illustrates exception handling in DAO.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdao.h  
  
##  \<a name="cdaoexception__cdaoexception">\</a>  CDaoException::CDaoException  
 Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Ordinarily, the framework creates exception objects when its code throws an exception. You seldom need to construct an exception object explicitly. If you want to throw a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> from your own code, call the global function [AfxThrowDaoException](../vs140/afxthrowdaoexception.md).  
  
 However, you might want to explicitly create an exception object if you are making direct calls to DAO via the DAO interface pointers that MFC classes encapsulate. In that case, you might need to retrieve error information from DAO. Suppose an error occurs in DAO when you call a DAO method via the DAODatabases interface to a workspace's Databases collection.  
  
##### To retrieve the DAO error information  
  
1.  Construct a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
2.  Call the exception object's [GetErrorCount](#cdaoexception__geterrorcount) member function to determine how many error objects are in the database engine's Errors collection. (Normally only one, unless you are using an ODBC data source.)  
  
3.  Call the exception object's [GetErrorInfo](#cdaoexception__geterrorinfo) member function to retrieve one specific error object at a time, by index in the collection, via the exception object. Think of the exception object as a proxy for one DAO error object.  
  
4.  Examine the current [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) structure that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns in the [m_pErrorInfo](#cdaoexception__m_perrorinfo) data member. Its members provide information on the DAO error.  
  
5.  In the case of an ODBC data source, repeat steps 3 and 4 as needed, for more error objects.  
  
6.  If you constructed the exception object on the heap, delete it with the **delete** operator when you finish.  
  
 For more information about handling errors in the MFC DAO classes, see the article [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md).  
  
##  \<a name="cdaoexception__geterrorcount">\</a>  CDaoException::GetErrorCount  
 Call this member function to retrieve the number of DAO error objects in the database engine's Errors collection.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The number of DAO error objects in the database engine's Errors collection.  
  
### Remarks  
 This information is useful for looping through the Errors collection to retrieve each of the one or more DAO error objects in the collection. To retrieve an error object by index or by DAO error number, call the [GetErrorInfo](#cdaoexception__geterrorinfo) member function.  
  
> [!NOTE]
>  Normally there is only one error object in the Errors collection. If you are working with an ODBC data source, however, there could be more than one.  
  
##  \<a name="cdaoexception__geterrorinfo">\</a>  CDaoException::GetErrorInfo  
 Returns error information about a particular error object in the Errors collection.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The index of the error information in the database engine's Errors collection, for lookup by index.  
  
### Remarks  
 Call this member function to obtain the following kinds of information about the exception:  
  
-   Error code  
  
-   Source  
  
-   Description  
  
-   Help file  
  
-   Help context  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> stores the information in the exception object's <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> data member. For a brief description of the information returned, see [m_pErrorInfo](#cdaoexception__m_perrorinfo). If you catch an exception of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> thrown by MFC, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member will already be filled in. If you choose to call DAO directly, you must call the exception object's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function yourself to fill <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For a more detailed description, see the [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) structure.  
  
 For information about DAO exceptions, and example code, see the article [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md).  
  
##  \<a name="cdaoexception__m_nafxdaoerror">\</a>  CDaoException::m_nAfxDaoError  
 Contains an MFC extended error code.  
  
### Remarks  
 This code is supplied in cases where a specific component of the MFC DAO classes has erred.  
  
 Possible values are:  
  
-   **NO_AFX_DAO_ERROR** The most recent operation did not result in an MFC extended error. However, the operation could have produced other errors from DAO or OLE, so you should check [m_pErrorInfo](#cdaoexception__m_perrorinfo) and possibly [m_scode](#cdaoexception__m_scode).  
  
-   **AFX_DAO_ERROR_ENGINE_INITIALIZATION** MFC could not initialize the Microsoft Jet database engine. OLE might have failed to initialize, or it might have been impossible to create an instance of the DAO database engine object. These problems usually suggest a bad installation of either DAO or OLE.  
  
-   **AFX_DAO_ERROR_DFX_BIND** An address used in a DAO record field exchange (DFX) function call does not exist or is invalid (the address was not used to bind data). You might have passed a bad address in a DFX call, or the address might have become invalid between DFX operations.  
  
-   **AFX_DAO_ERROR_OBJECT_NOT_OPEN** You attempted to open a recordset based on a querydef or a tabledef object that was not in an open state.  
  
##  \<a name="cdaoexception__m_perrorinfo">\</a>  CDaoException::m_pErrorInfo  
 Contains a pointer to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> structure that provides information on the DAO error object that you last retrieved by calling [GetErrorInfo](#cdaoexception__geterrorinfo).  
  
### Remarks  
 This object contains the following information:  
  
|CDaoErrorInfo member|Information|Meaning|  
|--------------------------|-----------------|-------------|  
|**m_lErrorCode**|Error Code|The DAO error code|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Source|The name of the object or application that originally generated the error|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Description|A descriptive string associated with the error|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Help File|A path to a Windows Help file in which the user can get information about the problem|  
|**m_lHelpContext**|Help Context|The context ID for a topic in the DAO Help file|  
  
 For full details about the information contained in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object, see the [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) structure.  
  
##  \<a name="cdaoexception__m_scode">\</a>  CDaoException::m_scode  
 Contains a value of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that describes the error.  
  
### Remarks  
 This is an OLE code. You will seldom need to use this value because, in almost all cases, more specific MFC or DAO error information is available in the other <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> data members.  
  
 For information about <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see the topic                         [Structure of OLE Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> data type maps to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> data type.  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException](../vs140/cexception-class.md)