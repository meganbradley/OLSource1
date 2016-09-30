---
title: "File I-O Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "File I/O Classes"
f1_keywords: 
  - "vc.classes.file"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "disk file classes"
  - "stdio classes"
  - "OLE streams"
  - "I/O [C++], MFC classes"
  - "translated stream classes"
  - "file I/O classes [C++]"
  - "I/O [MFC], classes"
  - "sockets classes"
  - "stream classes"
  - "memory file classes"
ms.assetid: 92821c3f-d9e1-47f6-98c9-3b632d86e811
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File I-O Classes
These classes provide an interface to traditional disk files, in-memory files, Active streams, and Windows sockets. All of the classes derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> can be used with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to perform serialization.  
  
 Use the following classes, particularly <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if you write your own input/output processing. Normally you do not need to derive from these classes. If you use the application framework, the default implementations of the **Open** and **Save** commands on the **File** menu will handle file I/O (using class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), as long as you override your document's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function to supply details about how a document serializes its contents. For more information about the file classes and serialization, see the article [Files in MFC](../vs140/files-in-mfc.md) and the article [Serialization](../vs140/serialization-in-mfc.md).  
  
 [CFile](../vs140/cfile-class.md)  
 Provides a file interface to binary disk files.  
  
 [CStdioFile](../vs140/cstdiofile-class.md)  
 Provides a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface to buffered stream disk files, usually in text mode.  
  
 [CMemFile](../vs140/cmemfile-class.md)  
 Provides a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface to in-memory files.  
  
 [CSharedFile](../vs140/csharedfile-class.md)  
 Provides a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface to shared in-memory files.  
  
 [COleStreamFile](../vs140/colestreamfile-class.md)  
 Uses the COM <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface to provide <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> access to compound files.  
  
 [CSocketFile](../vs140/csocketfile-class.md)  
 Provides a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface to a Windows Socket.  
  
## Related Classes  
 [CArchive](../vs140/carchive-class.md)  
 Cooperates with a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object to implement persistent storage for objects through serialization (see [CObject::Serialize](../vs140/cobject--serialize.md)).  
  
 [CArchiveException](../vs140/carchiveexception-class.md)  
 An archive exception.  
  
 [CFileException](../vs140/cfileexception-class.md)  
 A file-oriented exception.  
  
 [CFileDialog](../vs140/cfiledialog-class.md)  
 Provides a standard dialog box for opening or saving a file.  
  
 [CRecentFileList](../vs140/crecentfilelist-class.md)  
 Maintains the most recently used (MRU) file list.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)