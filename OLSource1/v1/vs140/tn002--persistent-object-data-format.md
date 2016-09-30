---
title: "TN002: Persistent Object Data Format"
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
  - "vc.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VERSIONABLE_SCHEMA macro"
  - "persistent object data"
  - "CArchive class, support for persistent data"
  - "persistent C++ objects"
  - "TN002"
ms.assetid: 553fe01d-c587-4c8d-a181-3244a15c2be9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN002: Persistent Object Data Format
This note describes the MFC routines that support persistent C++ objects and the format of the object data when it is stored in a file. This applies only to classes with the [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macros.  
  
## The Problem  
 The MFC implementation for persistent data stores data for many objects in a single contiguous part of a file. The object's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method translates the object's data into a compact binary format.  
  
 The implementation guarantees that all data is saved in the same format by using the [CArchive Class](../vs140/carchive-class.md). It uses a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object as a translator. This object persists from the time it is created until you call [CArchive::Close](../vs140/carchive--close.md). This method can be called either explicitly by the programmer or implicitly by the destructor when the program exits the scope that contains the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 This note describes the implementation of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> members [CArchive::ReadObject](../vs140/carchive--readobject.md) and [CArchive::WriteObject](../vs140/carchive--writeobject.md). You will find the code for these functions in Arcobj.cpp, and the main implementation for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in Arccore.cpp. User code does not call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directly. Instead, these objects are used by class-specific type-safe insertion and extraction operators that are generated automatically by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macros. The following code shows how <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> are implicitly called:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Saving Objects to the Store (CArchive::WriteObject)  
 The method <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> writes header data that is used to reconstruct the object. This data consists of two parts: the type of the object and the state of the object. This method is also responsible for maintaining the identity of the object being written out, so that only a single copy is saved, regardless of the number of pointers to that object (including circular pointers).  
  
 Saving (inserting) and restoring (extracting) objects relies on several "manifest constants." These are values that are stored in binary and provide important information to the archive (note the "w" prefix indicates 16-bit quantities):  
  
|Tag|Description|  
|---------|-----------------|  
|wNullTag|Used for NULL object pointers (0).|  
|wNewClassTag|Indicates class description that follows is new to this archive context (-1).|  
|wOldClassTag|Indicates class of the object being read has been seen in this context (0x8000).|  
  
 When storing objects, the archive maintains a [CMapPtrToPtr](../vs140/cmapptrtoptr-class.md) (the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) which is a mapping from a stored object to a 32-bit persistent identifier (PID). A PID is assigned to every unique object and every unique class name that is saved in the context of the archive. These PIDs are handed out sequentially starting at 1. These PIDs have no significance outside the scope of the archive and, in particular, are not to be confused with record numbers or other identity items.  
  
 In the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class, PIDs are 32-bit, but they are written out as 16-bit unless they are larger than 0x7FFE. Large PIDs are written as 0x7FFF followed by the 32-bit PID. This maintains compatibility with projects that were created in earlier versions.  
  
 When a request is made to save an object to an archive (usually by using the global insertion operator), a check is made for a NULL [CObject](../vs140/cobject-class.md) pointer. If the pointer is NULL, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is inserted into the archive stream.  
  
 If the pointer is not NULL and can be serialized (the class is a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class), the code checks the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to see whether the object has been saved already. If it has, the code inserts the 32-bit PID associated with that object into the archive stream.  
  
 If the object has not been saved before, there are two possibilities to consider: either both the object and the exact type (that is, class) of the object are new to this archive context, or the object is of an exact type already seen. To determine whether the type has been seen, the code queries the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for a [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that matches the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object associated with the object being saved. If there is a match, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> inserts a tag that is the bit-wise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and this index. If the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is new to this archive context, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> assigns a new PID to that class and inserts it into the archive, preceded by the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value.  
  
 The descriptor for this class is then inserted into the archive using the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> inserts the schema number of the class (see below) and the ASCII text name of the class. Note that the use of the ASCII text name does not guarantee uniqueness of the archive across applications. Therefore, you should tag your data files to prevent corruption. Following the insertion of the class information, the archive puts the object into the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and then calls the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method to insert class-specific data. Placing the object into the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> prevents multiple copies of the object from being saved to the store.  
  
 When returning to the initial caller (usually the root of the network of objects), you must call [CArchive::Close](../vs140/carchive--close.md). If you plan to perform other [CFile](../vs140/cfile-class.md)operations, you must call the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method [Flush](../vs140/carchive--flush.md) to prevent corruption of the archive.  
  
> [!NOTE]
>  This implementation imposes a hard limit of 0x3FFFFFFE indices per archive context. This number represents the maximum number of unique objects and classes that can be saved in a single archive, but a single disk file can have an unlimited number of archive contexts.  
  
## Loading Objects from the Store (CArchive::ReadObject)  
 Loading (extracting) objects uses the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method and is the converse of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. As with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not called directly by user code; user code should call the type-safe extraction operator that calls <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> with the expected <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. This insures the type integrity of the extract operation.  
  
 Since the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> implementation assigned increasing PIDs, starting with 1 (0 is predefined as the NULL object), the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> implementation can use an array to maintain the state of the archive context. When a PID is read from the store, if the PID is larger than the current upper bound of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> knows that a new object (or class description) follows.  
  
## Schema Numbers  
 The schema number, which is assigned to the class when the  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method of the class is encountered, is the "version" of the class implementation. The schema refers to the implementation of the class, not to the number of times a given object has been made persistent (usually referred to as the object version).  
  
 If you intend to maintain several different implementations of the same class over time, incrementing the schema as you revise your object's <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method implementation will enable you to write code that can load objects stored by using older versions of the implementation.  
  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method will throw a [CArchiveException](../vs140/carchiveexception-class.md) when it encounters a schema number in the persistent store that differs from the schema number of the class description in memory. It is not easy to recover from this exception.  
  
 You can use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> combined with (bitwise <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>) your schema version to keep this exception from being thrown. By using <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, your code can take the appropriate action in its <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> function by checking the return value from [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md).  
  
## Calling Serialize Directly  
 In many cases the overhead of the general object archive scheme of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is not necessary. This is the common case of serializing the data into a [CDocument](../vs140/cdocument-class.md). In this case, the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is called directly, not with the extract or insert operators. The contents of the document may in turn use the more general object archive scheme.  
  
 Calling <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> directly has the following advantages and disadvantages:  
  
-   No extra bytes are added to the archive before or after the object is serialized. This not only makes the saved data smaller, but allows you to implement <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> routines that can handle any file formats.  
  
-   The MFC is tuned so the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> implementations and related collections will not be linked into your application unless you need the more general object archive scheme for some other purpose.  
  
-   Your code does not have to recover from old schema numbers. This makes your document serialization code responsible for encoding schema numbers, file format version numbers, or whatever identifying numbers you use at the start of your data files.  
  
-   Any object that is serialized with a direct call to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> must not use <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or must handle a return value of (UINT)-1 indicating that the version was unknown.  
  
 Because <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is called directly on your document, it is not usually possible for the sub-objects of the document to archive references to their parent document. These objects must be given a pointer to their container document explicitly or you must use [CArchive::MapObject](../vs140/carchive--mapobject.md) function to map the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> pointer to a PID before these back pointers are archived.  
  
 As noted earlier, you should encode the version and class information yourself when you call <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> directly, enabling you to change the format later while still maintaining backward compatibility with older files. The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> function can be called explicitly before directly serializing an object or before calling a base class.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)