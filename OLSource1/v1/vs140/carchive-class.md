---
title: "CArchive Class"
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
  - "CArchive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "I/O [MFC], archiving objects"
  - "CArchive class"
  - "serialization [C++], CArchive class"
  - "storage [C++], CArchive class"
  - "data storage [C++], CArchive class"
ms.assetid: 9e950d23-b874-456e-ae4b-fe00781a7699
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive Class
Allows you to save a complex network of objects in a permanent binary form (usually disk storage) that persists after those objects are deleted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CArchive::CArchive](#carchive__carchive)|Creates a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CArchive::Abort](#carchive__abort)|Closes an archive without throwing an exception.|  
|[CArchive::Close](#carchive__close)|Flushes unwritten data and disconnects from the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[CArchive::Flush](#carchive__flush)|Flushes unwritten data from the archive buffer.|  
|[CArchive::GetFile](#carchive__getfile)|Gets the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object pointer for this archive.|  
|[CArchive::GetObjectSchema](#carchive__getobjectschema)|Called from the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function to determine the version of the object that is being deserialized.|  
|[CArchive::IsBufferEmpty](#carchive__isbufferempty)|Determines whether the buffer has been emptied during a Windows Sockets receive process.|  
|[CArchive::IsLoading](#carchive__isloading)|Determines whether the archive is loading.|  
|[CArchive::IsStoring](#carchive__isstoring)|Determines whether the archive is storing.|  
|[CArchive::MapObject](#carchive__mapobject)|Places objects in the map that are not serialized to the file, but that are available for subobjects to reference.|  
|[CArchive::Read](#carchive__read)|Reads raw bytes.|  
|[CArchive::ReadClass](#carchive__readclass)|Reads a class reference previously stored with <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|[CArchive::ReadObject](#carchive__readobject)|Calls an object's <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function for loading.|  
|[CArchive::ReadString](#carchive__readstring)|Reads a single line of text.|  
|[CArchive::SerializeClass](#carchive__serializeclass)|Reads or writes the class reference to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object depending on the direction of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|[CArchive::SetLoadParams](#carchive__setloadparams)|Sets the size to which the load array grows. Must be called before any object is loaded or before <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is called.|  
|[CArchive::SetObjectSchema](#carchive__setobjectschema)|Sets the object schema stored in the archive object.|  
|[CArchive::SetStoreParams](#carchive__setstoreparams)|Sets the hash table size and the block size of the map used to identify unique objects during the serialization process.|  
|[CArchive::Write](#carchive__write)|Writes raw bytes.|  
|[CArchive::WriteClass](#carchive__writeclass)|Writes a reference to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.|  
|[CArchive::WriteObject](#carchive__writeobject)|Calls an object's <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function for storing.|  
|[CArchive::WriteString](#carchive__writestring)|Writes a single line of text.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator<\<](#carchive__operator__lt__lt_)|Stores objects and primitive types to the archive.|  
|[operator>>](#carchive__operator__gt__gt_)|Loads objects and primitive types from the archive.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CArchive::m_pDocument](#carchive__m_pdocument)||  
  
## Remarks  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> does not have a base class.  
  
 Later you can load the objects from persistent storage, reconstituting them in memory. This process of making data persistent is called "serialization."  
  
 You can think of an archive object as a kind of binary stream. Like an input/output stream, an archive is associated with a file and permits the buffered writing and reading of data to and from storage. An input/output stream processes sequences of ASCII characters, but an archive processes binary object data in an efficient, nonredundant format.  
  
 You must create a [CFile](../vs140/cfile-class.md) object before you can create a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object. In addition, you must ensure that the archive's load/store status is compatible with the file's open mode. You are limited to one active archive per file.  
  
 When you construct a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object, you attach it to an object of class <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (or a derived class) that represents an open file. You also specify whether the archive will be used for loading or storing. A <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object can process not only primitive types but also objects of [CObject](../vs140/cobject-class.md)-derived classes designed for serialization. A serializable class usually has a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> member function, and it usually uses the [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macros, as described under class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 The overloaded extraction ( **>>**) and insertion ( **<<**) operators are convenient archive programming interfaces that support both primitive types and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>-derived classes.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> also supports programming with the MFC Windows Sockets classes [CSocket](../vs140/csocket-class.md) and [CSocketFile](../vs140/csocketfile-class.md). The [IsBufferEmpty](#carchive__isbufferempty) member function supports that usage.  
  
 For more information on <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, see the articles [Serialization](../vs140/serialization-in-mfc.md) and [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="carchive__abort">\</a>  CArchive::Abort  
 Call this function to close the archive without throwing an exception.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The **CArchive** destructor will normally call **Close**, which will flush any data that has not been saved to the associated <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object. This can cause exceptions.  
  
 When catching these exceptions, it is a good idea to use **Abort**, so that destructing the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object doesn't cause further exceptions. When handling exceptions, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> will not throw an exception on failures because, unlike [CArchive::Close](#carchive__close), **Abort** ignores failures.  
  
 If you used **new** to allocate the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object on the heap, then you must delete it after closing the file.  
  
### Example  
  See the example for [CArchive::WriteClass](#carchive__writeclass).  
  
##  \<a name="carchive__carchive">\</a>  CArchive::CArchive  
 Constructs a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object and specifies whether it will be used for loading or storing objects.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object that is the ultimate source or destination of the persistent data.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A flag that specifies whether objects will be loaded from or stored to the archive. The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> parameter must have one of the following values:  
  
-   **CArchive::load** Loads data from the archive. Requires only <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> read permission.  
  
-   **CArchive::store** Saves data to the archive. Requires <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> write permission.  
  
-   **CArchive::bNoFlushOnDelete** Prevents the archive from automatically calling <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> when the archive destructor is called. If you set this flag, you are responsible for explicitly calling **Close** before the destructor is called. If you do not, your data will be corrupted.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 An integer that specifies the size of the internal file buffer, in bytes. Note that the default buffer size is 4,096 bytes. If you routinely archive large objects, you will improve performance if you use a larger buffer size that is a multiple of the file buffer size.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 An optional pointer to a user-supplied buffer of size <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. If you do not specify this parameter, the archive allocates a buffer from the local heap and frees it when the object is destroyed. The archive does not free a user-supplied buffer.  
  
### Remarks  
 You cannot change this specification after you have created the archive.  
  
 You may not use <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> operations to alter the state of the file until you have closed the archive. Any such operation will damage the integrity of the archive. You may access the position of the file pointer at any time during serialization by obtaining the archive's file object from the [GetFile](#carchive__getfile) member function and then using the [CFile::GetPosition](../vs140/cfile-class.md#cfile__getposition) function. You should call [CArchive::Flush](#carchive__flush) before obtaining the position of the file pointer.  
  
### Example  
 [!code[NVC_MFCSerialization#12](../vs140/codesnippet/CPP/carchive-class_1.cpp)]  
  
##  \<a name="carchive__close">\</a>  CArchive::Close  
 Flushes any data remaining in the buffer, closes the archive, and disconnects the archive from the file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 No further operations on the archive are permitted. After you close an archive, you can create another archive for the same file or you can close the file.  
  
 The member function **Close** ensures that all data is transferred from the archive to the file, and it makes the archive unavailable. To complete the transfer from the file to the storage medium, you must first use [CFile::Close](../vs140/cfile-class.md#cfile__close) and then destroy the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
### Example  
  See the example for [CArchive::WriteString](#carchive__writestring).  
  
##  \<a name="carchive__flush">\</a>  CArchive::Flush  
 Forces any data remaining in the archive buffer to be written to the file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The member function <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> ensures that all data is transferred from the archive to the file. You must call [CFile::Close](../vs140/cfile-class.md#cfile__close) to complete the transfer from the file to the storage medium.  
  
### Example  
 [!code[NVC_MFCSerialization#13](../vs140/codesnippet/CPP/carchive-class_2.cpp)]  
  
##  \<a name="carchive__getfile">\</a>  CArchive::GetFile  
 Gets the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object pointer for this archive.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A constant pointer to the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object in use.  
  
### Remarks  
 You must flush the archive before using <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCSerialization#14](../vs140/codesnippet/CPP/carchive-class_3.cpp)]  
  
##  \<a name="carchive__getobjectschema">\</a>  CArchive::GetObjectSchema  
 Call this function from the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> function to determine the version of the object that is currently being deserialized.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 During deserialization, the version of the object being read.  
  
### Remarks  
 Calling this function is only valid when the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object is being loaded ( [CArchive::IsLoading](#carchive__isloading) returns nonzero). It should be the first call in the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> function and called only once. A return value of ( **UINT**)–1 indicates that the version number is unknown.  
  
 A <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>-derived class may use **VERSIONABLE_SCHEMA** combined (using bitwise <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>) with the schema version itself (in the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> macro) to create a "versionable object," that is, an object whose <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> member function can read multiple versions. The default framework functionality (without **VERSIONABLE_SCHEMA**) is to throw an exception when the version is mismatched.  
  
### Example  
 [!code[NVC_MFCSerialization#15](../vs140/codesnippet/CPP/carchive-class_4.cpp)]  
  
##  \<a name="carchive__isbufferempty">\</a>  CArchive::IsBufferEmpty  
 Call this member function to determine whether the archive object's internal buffer is empty.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the archive's buffer is empty; otherwise 0.  
  
### Remarks  
 This function is supplied to support programming with the MFC Windows Sockets class <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. You do not need to use it for an archive associated with a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
 The reason for using <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> with an archive associated with a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object is that the archive's buffer might contain more than one message or record. After receiving one message, you should use <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to control a loop that continues receiving data until the buffer is empty. For more information, see the [Receive](../vs140/casyncsocket-class.md#casyncsocket__receive) member function of class <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, which shows how to use <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="carchive__isloading">\</a>  CArchive::IsLoading  
 Determines whether the archive is loading data.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the archive is currently being used for loading; otherwise 0.  
  
### Remarks  
 This member function is called by the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> functions of the archived classes.  
  
### Example  
 [!code[NVC_MFCSerialization#16](../vs140/codesnippet/CPP/carchive-class_5.cpp)]  
  
##  \<a name="carchive__isstoring">\</a>  CArchive::IsStoring  
 Determines whether the archive is storing data.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the archive is currently being used for storing; otherwise 0.  
  
### Remarks  
 This member function is called by the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> functions of the archived classes.  
  
 If the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> status of an archive is nonzero, then its <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> status is 0, and vice versa.  
  
### Example  
 [!code[NVC_MFCSerialization#17](../vs140/codesnippet/CPP/carchive-class_6.cpp)]  
  
##  \<a name="carchive__mapobject">\</a>  CArchive::MapObject  
 Call this member function to place objects in the map that are not really serialized to the file, but that are available for subobjects to reference.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A constant pointer to the object being stored.  
  
### Remarks  
 For example, you might not serialize a document, but you would serialize the items that are part of the document. By calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, you allow those items, or subobjects, to reference the document. Also, serialized subitems can serialize their <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> back pointer.  
  
 You can call <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> when you store to and load from the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> adds the specified object to the internal data structures maintained by the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object during serialization and deserialization, but unlike [ReadObject](#carchive__readobject) and [WriteObject](#carchive__writeobject)**,** it does not call serialize on the object.  
  
### Example  
 [!code[NVC_MFCSerialization#18](../vs140/codesnippet/CPP/carchive-class_7.h)]  
  
 [!code[NVC_MFCSerialization#19](../vs140/codesnippet/CPP/carchive-class_8.cpp)]  
  
 [!code[NVC_MFCSerialization#20](../vs140/codesnippet/CPP/carchive-class_9.h)]  
  
 [!code[NVC_MFCSerialization#21](../vs140/codesnippet/CPP/carchive-class_10.cpp)]  
  
##  \<a name="carchive__m_pdocument">\</a>  CArchive::m_pDocument  
 Set to **NULL** by default, this pointer to a **CDocument** can be set to anything the user of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> instance wants.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A common usage of this pointer is to convey additional information about the serialization process to all objects being serialized. This is achieved by initializing the pointer with the document (a **CDocument**-derived class) that is being serialized, in such a way that objects within the document can access the document if necessary. This pointer is also used by <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> objects during serialization.  
  
 The framework sets <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to the document being serialized when a user issues a File Open or Save command. If you serialize an Object Linking and Embedding (OLE) container document for reasons other than File Open or Save, you must explicitly set <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. For example, you would do this when serializing a container document to the Clipboard.  
  
### Example  
 [!code[NVC_MFCSerialization#35](../vs140/codesnippet/CPP/carchive-class_11.cpp)]  
  
##  \<a name="carchive__operator__lt__lt_">\</a>  CArchive::operator &lt;&lt;  
 Stores the indicated object or primitive type to the archive.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> reference that enables multiple insertion operators on a single line.  
  
### Remarks  
 The last two versions above are specifically for storing 64-bit integers.  
  
 If you used the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> macro in your class implementation, then the insertion operator overloaded for <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> calls the protected **WriteObject**. This function, in turn, calls the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> function of the class.  
  
 The [CStringT](../vs140/cstringt-class.md) insertion operator (<<) supports diagnostic dumping and storing to an archive.  
  
### Example  
 This example demonstrates the use of the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> insertion operator << with the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> types.  
  
 [!code[NVC_MFCSerialization#31](../vs140/codesnippet/CPP/carchive-class_12.cpp)]  
  
### Example  
 This example 2 demonstrates the use of the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> insertion operator << with the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> type.  
  
 [!code[NVC_MFCSerialization#32](../vs140/codesnippet/CPP/carchive-class_13.cpp)]  
  
##  \<a name="carchive__operator__gt__gt_">\</a>  CArchive::operator &gt;&gt;  
 Loads the indicated object or primitive type from the archive.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> reference that enables multiple extraction operators on a single line.  
  
### Remarks  
 The last two versions above are specifically for loading 64-bit integers.  
  
 If you used the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> macro in your class implementation, then the extraction operators overloaded for <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> call the protected **ReadObject** function (with a nonzero run-time class pointer). This function, in turn, calls the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> function of the class.  
  
 The [CStringT](../vs140/cstringt-class.md) extraction operator (>>) supports loading from an archive.  
  
### Example  
 This example demonstrates the use of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> extraction operator >> with the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> type.  
  
 [!code[NVC_MFCSerialization#33](../vs140/codesnippet/CPP/carchive-class_14.cpp)]  
  
### Example  
 This example demonstrates the use of the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> insertion and extraction operators <\< and >> with the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> type.  
  
 [!code[NVC_MFCSerialization#34](../vs140/codesnippet/CPP/carchive-class_15.cpp)]  
  
##  \<a name="carchive__read">\</a>  CArchive::Read  
 Reads a specified number of bytes from the archive.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 A pointer to a user-supplied buffer that is to receive the data read from the archive.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 An unsigned integer specifying the number of bytes to be read from the archive.  
  
### Return Value  
 An unsigned integer containing the number of bytes actually read. If the return value is less than the number requested, the end of file has been reached. No exception is thrown on the end-of-file condition.  
  
### Remarks  
 The archive does not interpret the bytes.  
  
 You can use the **Read** member function within your <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> function for reading ordinary structures that are contained in your objects.  
  
### Example  
 [!code[NVC_MFCSerialization#24](../vs140/codesnippet/CPP/carchive-class_16.cpp)]  
  
##  \<a name="carchive__readclass">\</a>  CArchive::ReadClass  
 Call this member function to read a reference to a class previously stored with [WriteClass](#carchive__writeclass).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the class reference requested. Can be **NULL**.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 A pointer to a schema of the run-time class previously stored.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A number that refers to an object's unique tag. Used internally by the implementation of [ReadObject](#carchive__readobject). Exposed for advanced programming only; <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> normally should be **NULL**.  
  
### Return Value  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure.  
  
### Remarks  
 If <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> is not **NULL**, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> verifies that the archived class information is compatible with your runtime class. If it is not compatible, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 If <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> is **NULL**, the schema of the stored class can be retrieved by calling [CArchive::GetObjectSchema](#carchive__getobjectschema); otherwise, **\***<CodeContentPlaceHolder>129\</CodeContentPlaceHolder> will contain the schema of the run-time class that was previously stored.  
  
 You can use [SerializeClass](#carchive__serializeclass) instead of <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, which handles both reading and writing of the class reference.  
  
### Example  
  See the example for [CArchive::WriteClass](#carchive__writeclass).  
  
##  \<a name="carchive__readobject">\</a>  CArchive::ReadObject  
 Reads object data from the archive and constructs an object of the appropriate type.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A constant pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the object you expect to read.  
  
### Return Value  
 A [CObject](../vs140/cobject-class.md) pointer that must be safely cast to the correct derived class by using [CObject::IsKindOf](../vs140/cobject-class.md#cobject__iskindof).  
  
### Remarks  
 This function is normally called by the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> extraction ( **>>**) operator overloaded for a [CObject](../vs140/cobject-class.md) pointer. **ReadObject**, in turn, calls the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> function of the archived class.  
  
 If you supply a nonzero <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> parameter, which is obtained by the [RUNTIME_CLASS](../vs140/runtime_class.md) macro, then the function verifies the run-time class of the archived object. This assumes you have used the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> macro in the implementation of the class.  
  
### Example  
  See the example for [CArchive::WriteObject](#carchive__writeobject).  
  
##  \<a name="carchive__readstring">\</a>  CArchive::ReadString  
 Call this member function to read text data into a buffer from the file associated with the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) that will contain the resultant string after it is read from the file associated with the CArchive object.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies a pointer to a user-supplied buffer that will receive a null-terminated text string.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Specifies the maximum number of characters to read. Should be one less than the size of the                                 *lpsz* buffer.  
  
### Return Value  
 In the version that returns **BOOL**, **TRUE** if successful; **FALSE** otherwise.  
  
 In the version that returns an <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, a pointer to the buffer containing the text data; **NULL** if end-of-file was reached.  
  
### Remarks  
 In the version of the member function with the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> parameter, the buffer will hold up to a limit of <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> - 1 characters. Reading is stopped by a carriage return-linefeed pair. Trailing newline characters are always removed. A null character ('\0') is appended in either case.  
  
 [CArchive::Read](#carchive__read) is also available for text-mode input, but it does not terminate on a carriage return-linefeed pair.  
  
### Example  
  See the example for [CArchive::WriteString](#carchive__writestring).  
  
##  \<a name="carchive__serializeclass">\</a>  CArchive::SerializeClass  
 Call this member function when you want to store and load the version information of a base class.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 A pointer to a run-time class object for the base class.  
  
### Remarks  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> reads or writes the reference to a class to the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object, depending on the direction of the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> in place of [ReadClass](#carchive__readclass) and [WriteClass](#carchive__writeclass) as a convenient way to serialize base-class objects; <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> requires less code and fewer parameters.  
  
 Like <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> verifies that the archived class information is compatible with your runtime class. If it is not compatible, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 Use the [RUNTIME_CLASS](../vs140/runtime_class.md) macro to retrieve the value for the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> parameter. The base class must have used the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro.  
  
### Example  
 [!code[NVC_MFCSerialization#25](../vs140/codesnippet/CPP/carchive-class_17.h)]  
  
##  \<a name="carchive__setloadparams">\</a>  CArchive::SetLoadParams  
 Call <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> when you are going to read a large number of <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>-derived objects from an archive.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
### Remarks  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> uses a load array to resolve references to objects stored in the archive. <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> allows you to set the size to which the load array grows.  
  
 You must not call <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> after any object is loaded, or after [MapObject](#carchive__mapobject) or [ReadObject](#carchive__readobject) is called.  
  
### Example  
 [!code[NVC_MFCSerialization#26](../vs140/codesnippet/CPP/carchive-class_18.h)]  
  
##  \<a name="carchive__setobjectschema">\</a>  CArchive::SetObjectSchema  
 Call this member function to set the object schema stored in the archive object to <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Specifies the object's schema.  
  
### Remarks  
 The next call to [GetObjectSchema](#carchive__getobjectschema) will return the value stored in <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 Use <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> for advanced versioning; for example, when you want to force a particular version to be read in a <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> function of a derived class.  
  
### Example  
 [!code[NVC_MFCSerialization#27](../vs140/codesnippet/CPP/carchive-class_19.cpp)]  
  
##  \<a name="carchive__setstoreparams">\</a>  CArchive::SetStoreParams  
 Use <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> when storing a large number of <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>-derived objects in an archive.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *nHashSize*  
 The size of the hash table for interface pointer maps. Should be a prime number.  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Specifies the memory-allocation granularity for extending the parameters. Should be a power of 2 for the best performance.  
  
### Remarks  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> allows you to set the hash table size and the block size of the map used to identify unique objects during the serialization process.  
  
 You must not call <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> after any objects are stored, or after [MapObject](#carchive__mapobject) or [WriteObject](#carchive__writeobject) is called.  
  
### Example  
 [!code[NVC_MFCSerialization#26](../vs140/codesnippet/CPP/carchive-class_18.h)]  
  
##  \<a name="carchive__write">\</a>  CArchive::Write  
 Writes a specified number of bytes to the archive.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 A pointer to a user-supplied buffer that contains the data to be written to the archive.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 An integer that specifies the number of bytes to be written to the archive.  
  
### Remarks  
 The archive does not format the bytes.  
  
 You can use the **Write** member function within your <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> function to write ordinary structures that are contained in your objects.  
  
### Example  
 [!code[NVC_MFCSerialization#23](../vs140/codesnippet/CPP/carchive-class_20.cpp)]  
  
##  \<a name="carchive__writeclass">\</a>  CArchive::WriteClass  
 Use <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> to store the version and class information of a base class during serialization of the derived class.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the class reference requested.  
  
### Remarks  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> writes a reference to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) for the base class to the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. Use [CArchive::ReadClass](#carchive__readclass) to retrieve the reference.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> verifies that the archived class information is compatible with your runtime class. If it is not compatible, <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 You can use [SerializeClass](#carchive__serializeclass) instead of <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, which handles both reading and writing of the class reference.  
  
### Example  
 [!code[NVC_MFCSerialization#28](../vs140/codesnippet/CPP/carchive-class_21.cpp)]  
  
##  \<a name="carchive__writeobject">\</a>  CArchive::WriteObject  
 Stores the specified <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> to the archive.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 A constant pointer to the object being stored.  
  
### Remarks  
 This function is normally called by the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> insertion ( **<<**) operator overloaded for <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. **WriteObject**, in turn, calls the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> function of the archived class.  
  
 You must use the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> macro to enable archiving. **WriteObject** writes the ASCII class name to the archive. This class name is validated later during the load process. A special encoding scheme prevents unnecessary duplication of the class name for multiple objects of the class. This scheme also prevents redundant storage of objects that are targets of more than one pointer.  
  
 The exact object encoding method (including the presence of the ASCII class name) is an implementation detail and could change in future versions of the library.  
  
> [!NOTE]
>  Finish creating, deleting, and updating all your objects before you begin to archive them. Your archive will be corrupted if you mix archiving with object modification.  
  
### Example  
 For a definition of the class <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, see the example for [CObList::CObList](../vs140/coblist-class.md#coblist__coblist).  
  
 [!code[NVC_MFCSerialization#29](../vs140/codesnippet/CPP/carchive-class_22.cpp)]  
  
##  \<a name="carchive__writestring">\</a>  CArchive::WriteString  
 Use this member function to write data from a buffer to the file associated with the <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Specifies a pointer to a buffer containing a null-terminated text string.  
  
### Remarks  
 The terminating null character ('\0') is not written to the file; nor is a newline automatically written.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> throws an exception in response to several conditions, including the disk-full condition.  
  
 **Write** is also available, but rather than terminating on a null character, it writes the requested number of bytes to the file.  
  
### Example  
 [!code[NVC_MFCSerialization#30](../vs140/codesnippet/CPP/carchive-class_23.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile](../vs140/cfile-class.md)   
 [CObject](../vs140/cobject-class.md)   
 [CSocket](../vs140/csocket-class.md)   
 [CSocketFile](../vs140/csocketfile-class.md)