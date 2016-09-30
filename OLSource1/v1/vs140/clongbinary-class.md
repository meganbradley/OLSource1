---
title: "CLongBinary Class"
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
  - "BLOB"
  - "CLongBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB (binary large object)"
  - "CLongBinary class"
  - "BLOB (binary large object), CLongBinary class"
ms.assetid: f4320059-aeb4-4ee5-bc2b-25f19d898ef5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLongBinary Class
Simplifies working with very large binary data objects (often called BLOBs, or "binary large objects") in a database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CLongBinary::CLongBinary](#clongbinary__clongbinary)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CLongBinary::m_dwDataLength](#clongbinary__m_dwdatalength)|Contains the actual size in bytes of the data object whose handle is stored in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|[CLongBinary::m_hData](#clongbinary__m_hdata)|Contains a Windows <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handle to the actual image object.|  
  
## Remarks  
 For example, a record field in a SQL table might contain a bitmap representing a picture. A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object stores such an object and keeps track of its size.  
  
> [!NOTE]
>  In general, it is better practice now to use [CByteArray](../vs140/cbytearray-class.md) in conjunction with the [DFX_Binary](../vs140/dfx_binary.md) function. You can still use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, but in general <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> provides more functionality under Win32, since there is no longer the size limitation encountered with 16-bit <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This advice applies to programming with Data Access Objects (DAO) as well as Open Database Connectivity (ODBC).  
  
 To use a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, declare a field data member of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in your recordset class. This member will be an embedded member of the recordset class and will be constructed when the recordset is constructed. After the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is constructed, the record field exchange (RFX) mechanism loads the data object from a field in the current record on the data source and stores it back to the record when the record is updated. RFX queries the data source for the size of the binary large object, allocates storage for it (via the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> data member), and stores an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> handle to the data in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. RFX also stores the actual size of the data object in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data member. Work with the data in the object through <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, using the same techniques you would normally use to manipulate the data stored in a Windows <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> handle.  
  
 When you destroy your recordset, the embedded <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object is also destroyed, and its destructor deallocates the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data handle.  
  
 For more information about large objects and the use of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, see the articles [Recordset (ODBC)](../vs140/recordset--odbc-.md) and [Recordset: Working with Large Data Items (ODBC)](../vs140/recordset--working-with-large-data-items--odbc-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdb_.h  
  
##  \<a name="clongbinary__clongbinary">\</a>  CLongBinary::CLongBinary  
 Constructs a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="clongbinary__m_dwdatalength">\</a>  CLongBinary::m_dwDataLength  
 Stores the actual size in bytes of the data stored in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> handle in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This size may be smaller than the size of the memory block allocated for the data. Call the Win32                         [GLobalSize](http://msdn.microsoft.com/library/windows/desktop/aa366593) function to get the allocated size.  
  
##  \<a name="clongbinary__m_hdata">\</a>  CLongBinary::m_hData  
 Stores a Windows <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> handle to the actual binary large object data.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset](../vs140/crecordset-class.md)