---
title: "CDBVariant Class"
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
  - "CDBVariant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDBVariant class"
  - "Variant data types, ODBC"
ms.assetid: de23609c-c560-4b24-bd6b-9d8903fd5b49
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant Class
Represents a variant data type for the MFC ODBC classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDBVariant::CDBVariant](#cdbvariant__cdbvariant)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDBVariant::Clear](#cdbvariant__clear)|Clears the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDBVariant::m_dwType](#cdbvariant__m_dwtype)|Contains the data type of the currently stored value. Type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
  
### Public Union Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDBVariant::m_boolVal](#cdbvariant__m_boolval)|Contains a value of type **BOOL**.|  
|[CDBVariant::m_chVal](#cdbvariant__m_chval)|Contains a value of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[CDBVariant::m_dblVal](#cdbvariant__m_dblval)|Contains a value of type **double**.|  
|[CDBVariant::m_fltVal](#cdbvariant__m_fltval)|Contains a value of type **float**.|  
|[CDBVariant::m_iVal](#cdbvariant__m_ival)|Contains a value of type **short**.|  
|[CDBVariant::m_lVal](#cdbvariant__m_lval)|Contains a value of type **long**.|  
|[CDBVariant::m_pbinary](#cdbvariant__m_pbinary)|Contains a pointer to an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[CDBVariant::m_pdate](#cdbvariant__m_pdate)|Contains a pointer to an object of type **TIMESTAMP_STRUCT**.|  
|[CDBVariant::m_pstring](#cdbvariant__m_pstring)|Contains a pointer to an object of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[CDBVariant::m_pstringA](#cdbvariant__m_pstringa)|Stores a pointer to an ASCII [CString](../vs140/cstringt-class.md) object.|  
|[CDBVariant::m_pstringW](#cdbvariant__m_pstringw)|Stores a pointer to a wide [CString](../vs140/cstringt-class.md) object.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not have a base class.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is similar to [COleVariant](../vs140/colevariant-class.md); however, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not use OLE. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> allows you to store a value without worrying about the value's data type. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> tracks the data type of the current value, which is stored in a union.  
  
 Class [CRecordset](../vs140/crecordset-class.md) utilizes <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects in three member functions: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For example, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> allows you to dynamically fetch data in a column. Because the data type of the column may not be known at run time, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to store the column's data.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdb.h  
  
##  \<a name="cdbvariant__cdbvariant">\</a>  CDBVariant::CDBVariant  
 Creates a NULL <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Sets the [m_dwType](#cdbvariant__m_dwtype) data member to **DBVT_NULL**.  
  
##  \<a name="cdbvariant__clear">\</a>  CDBVariant::Clear  
 Call this member function to clear the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 If the value of the [m_dwType](#cdbvariant__m_dwtype) data member is **DBVT_DATE**, **DBVT_STRING**, or **DBVT_BINARY**, **Clear** frees the memory associated with the union pointer member. **Clear** sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to **DBVT_NULL**.  
  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> destructor calls **Clear**.  
  
##  \<a name="cdbvariant__m_boolval">\</a>  CDBVariant::m_boolVal  
 Stores a value of type **BOOL**.  
  
### Remarks  
 The **m_boolVal** data member belongs to a union. Before accessing **m_boolVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is set to **DBVT_BOOL**, then **m_boolVal** will contain a valid value; otherwise, accessing **m_boolVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_chval">\</a>  CDBVariant::m_chVal  
 Stores a value of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Remarks  
 The **m_chVal** data member belongs to a union. Before accessing **m_chVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to **DBVT_UCHAR**, then **m_chVal** contains a valid value; otherwise, accessing **m_chVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_dblval">\</a>  CDBVariant::m_dblVal  
 Stores a value of type **double**.  
  
### Remarks  
 The **m_dblVal** data member belongs to a union. Before accessing **m_dblVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is set to **DBVT_DOUBLE**, then **m_dblVal** contains a valid value; otherwise, accessing **m_dblVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_dwtype">\</a>  CDBVariant::m_dwType  
 This data member contains the data type for the value that is currently stored in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object's union data member.  
  
### Remarks  
 Before accessing this union, you must check the value of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in order to determine which union data member to access. The following table lists the possible values for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the corresponding union data member.  
  
|m_dwType|Union data member|  
|---------------|-----------------------|  
|**DBVT_NULL**|No union member is valid for access.|  
|**DBVT_BOOL**|[m_boolVal](#cdbvariant__m_boolval)|  
|**DBVT_UCHAR**|[m_chVal](#cdbvariant__m_chval)|  
|**DBVT_SHORT**|[m_iVal](#cdbvariant__m_ival)|  
|**DBVT_LONG**|[m_lVal](#cdbvariant__m_lval)|  
|**DBVT_SINGLE**|[m_fltVal](#cdbvariant__m_fltval)|  
|**DBVT_DOUBLE**|[m_dblVal](#cdbvariant__m_dblval)|  
|**DBVT_DATE**|[m_pdate](#cdbvariant__m_pdate)|  
|**DBVT_STRING**|[m_pstring](#cdbvariant__m_pstring)|  
|**DBVT_BINARY**|[m_pbinary](#cdbvariant__m_pbinary)|  
|**DBVT_ASTRING**|[m_pstringA](#cdbvariant__m_pstringa)|  
|**DBVT_WSTRING**|[m_pstringW](#cdbvariant__m_pstringw)|  
  
##  \<a name="cdbvariant__m_fltval">\</a>  CDBVariant::m_fltVal  
 Stores a value of type **float**.  
  
### Remarks  
 The **m_fltVal** data member belongs to a union. Before accessing **m_fltVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is set to **DBVT_SINGLE**, then **m_fltVal** contains a valid value; otherwise, accessing **m_fltVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_ival">\</a>  CDBVariant::m_iVal  
 Stores a value of type **short**.  
  
### Remarks  
 The **m_iVal** data member belongs to a union. Before accessing **m_iVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is set to **DBVT_SHORT**, then **m_iVal** contains a valid value; otherwise, accessing **m_iVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_lval">\</a>  CDBVariant::m_lVal  
 Stores a value of type **long**.  
  
### Remarks  
 The **m_lVal** data member belongs to a union. Before accessing **m_lVal**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to **DBVT_LONG**, then **m_lVal** contains a valid value; otherwise, accessing **m_lVal** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_pbinary">\</a>  CDBVariant::m_pbinary  
 Stores a pointer to an object of type [CLongBinary](../vs140/clongbinary-class.md).  
  
### Remarks  
 The **m_pbinary** data member belongs to a union. Before accessing **m_pbinary**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is set to **DBVT_BINARY**, then **m_pbinary** contains a valid pointer; otherwise, accessing **m_pbinary** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_pdate">\</a>  CDBVariant::m_pdate  
 Stores a pointer to an object of type **TIMESTAMP_STRUCT**.  
  
### Remarks  
 The **m_pdate** data member belongs to a union. Before accessing **m_pdate**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is set to **DBVT_DATE**, then **m_pdate** contains a valid pointer; otherwise, accessing **m_pdate** will produce unreliable results.  
  
 For more information about the **TIMESTAMP_STRUCT** data type, see the topic                         [C Data Types](https://msdn.microsoft.com/en-us/library/ms714556.aspx) in Appendix D of the                         *ODBC Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdbvariant__m_pstring">\</a>  CDBVariant::m_pstring  
 Stores a pointer to an object of type [CString](../vs140/cstringt-class.md).  
  
### Remarks  
 The **m_pstring** data member belongs to a union. Before accessing **m_pstring**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is set to **DBVT_STRING**, then **m_pstring** contains a valid pointer; otherwise, accessing **m_pstring** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_pstringa">\</a>  CDBVariant::m_pstringA  
 Stores a pointer to an ASCII [CString](../vs140/cstringt-class.md) object.  
  
### Remarks  
 The **m_pstringA** data member belongs to a union. Before accessing **m_pstringA**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is set to **DBVT_ASTRING**, then **m_pstringA** contains a valid pointer; otherwise, accessing **m_pstringA** will produce unreliable results.  
  
##  \<a name="cdbvariant__m_pstringw">\</a>  CDBVariant::m_pstringW  
 Stores a pointer to a wide [CString](../vs140/cstringt-class.md) object.  
  
### Remarks  
 The **m_pstringW** data member belongs to a union. Before accessing **m_pstringW**, first check the value of [CDBVariant::m_dwType](#cdbvariant__m_dwtype). If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is set to **DBVT_WSTRING**, then **m_pstringW** contains a valid pointer; otherwise, accessing **m_pstringW** will produce unreliable results.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset](../vs140/crecordset-class.md)   
 [CRecordset::GetFieldValue](../vs140/crecordset-class.md#crecordset__getfieldvalue)   
 [CRecordset::GetBookmark](../vs140/crecordset-class.md#crecordset__getbookmark)   
 [CRecordset::SetBookmark](../vs140/crecordset-class.md#crecordset__setbookmark)