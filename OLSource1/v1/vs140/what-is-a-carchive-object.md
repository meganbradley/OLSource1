---
title: "What Is a CArchive Object"
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
  - "CArchive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "archive objects [C++]"
  - "archives [C++], for serialization"
  - "buffers, serializable objects"
  - "CArchive class, about CArchive class"
  - "buffering, serializable objects"
ms.assetid: 843f1825-288d-4d89-a1fa-70e1f92d9b8b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Is a CArchive Object
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object provides a type-safe buffering mechanism for writing or reading serializable objects to or from a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. Usually the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object represents a disk file; however, it can also be a memory file (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object), perhaps representing the Clipboard.  
  
 A given <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object either stores (writes, serializes) data or loads (reads, deserializes) data, but never both. The life of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is limited to one pass through writing objects to a file or reading objects from a file. Thus, two successively created <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects are required to serialize data to a file and then deserialize it back from the file.  
  
 When an archive stores objects to a file, the archive attaches the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> name to the objects. Then, when another archive loads objects from a file to memory, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived objects are dynamically reconstructed based on the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> of the objects. A given object may be referenced more than once as it is written to the file by the storing archive. The loading archive, however, will reconstruct the object only once. The details about how an archive attaches <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> information to objects and reconstructs objects, taking into account possible multiple references, are described in [Technical Note 2](../vs140/tn002--persistent-object-data-format.md).  
  
 As data is serialized to an archive, the archive accumulates the data until its buffer is full. Then the archive writes its buffer to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object pointed to by the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. Similarly, as you read data from an archive, it reads data from the file to its buffer and then from the buffer to your deserialized object. This buffering reduces the number of times a hard disk is physically read, thus improving your application's performance.  
  
## See Also  
 [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)