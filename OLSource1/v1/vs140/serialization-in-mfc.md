---
title: "Serialization in MFC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collection classes, serialization"
  - "bypassing serialization"
  - "MFC, serialization"
  - "serialization [C++], MFC"
  - "serialization [C++], bypassing"
ms.assetid: fb596a18-4522-47e0-96e0-192732d24c12
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Serialization in MFC
This article explains the serialization mechanism provided in the Microsoft Foundation Class Library (MFC) to allow objects to persist between runs of your program.  
  
 Serialization is the process of writing or reading an object to or from a persistent storage medium such as a disk file. Serialization is ideal for situations where it is desired to maintain the state of structured data (such as C++ classes or structures) during or after execution of a program. Using the serialization objects provided by MFC allows this to occur in a standard and consistent manner, relieving the user from the need to perform file operations by hand.  
  
 MFC supplies built-in support for serialization in the class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. Thus, all classes derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can take advantage of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>'s serialization protocol.  
  
 The basic idea of serialization is that an object should be able to write its current state, usually indicated by the value of its member variables, to persistent storage. Later, the object can be re-created by reading, or deserializing, the object's state from the storage. Serialization handles all the details of object pointers and circular references to objects that are used when you serialize an object. A key point is that the object itself is responsible for reading and writing its own state. Thus, for a class to be serializable, it must implement the basic serialization operations. As shown in the Serialization group of articles, it is easy to add this functionality to a class.  
  
 MFC uses an object of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class as an intermediary between the object to be serialized and the storage medium. This object is always associated with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, from which it obtains the necessary information for serialization, including the file name and whether the requested operation is a read or write. The object that performs a serialization operation can use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object without regard to the nature of the storage medium.  
  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object uses overloaded insertion (**<\<**) and extraction (**>>**) operators to perform writing and reading operations. For more information, see [Storing and Loading CObjects via an Archive](../vs140/storing-and-loading-cobjects-via-an-archive.md) in the article Serialization: Serializing an Object.  
  
> [!NOTE]
>  Do not confuse the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class with general-purpose iostream classes, which are for formatted text only. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class is for binary-format serialized objects.  
  
 If you want, you can bypass MFC serialization to create your own mechanism for persistent data storage. You will need to override the class member functions that initiate serialization at the user's command. See the discussion in [Technical Note 22](../vs140/tn022--standard-commands-implementation.md) of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, **ID_FILE_SAVE**, and **ID_FILE_SAVE_AS** standard commands.  
  
 The following articles cover the two main tasks required for serialization:  
  
-   [Serialization: Making a Serializable Class](../vs140/serialization--making-a-serializable-class.md)  
  
-   [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)  
  
 The article [Serialization: Serialization vs. Database Input/Output](../vs140/serialization--serialization-vs.-database-input-output.md) describes when serialization is an appropriate input/output technique in database applications.  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)   
 [CArchive Class](../vs140/carchive-class.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [CDocument Class](../vs140/cdocument-class.md)   
 [CFile Class](../vs140/cfile-class.md)