---
title: "Bypassing the Serialization Mechanism"
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
  - "archive objects [C++]"
  - "bypassing serialization"
  - "archives [C++], serialization"
  - "serialization [C++], bypassing"
  - "archives [C++]"
  - "serialization [C++], role of framework"
  - "serialization [C++], overriding"
ms.assetid: 48d4a279-b51c-4ba5-81cd-ed043312b582
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bypassing the Serialization Mechanism
As you have seen, the framework provides a default way to read and write data to and from files. Serializing through an archive object suits the needs of a great many applications. Such an application reads a file entirely into memory, lets the user update the file, and then writes the updated version to disk again.  
  
 However, some applications operate on data very differently, and for these applications serialization through an archive is not suitable. Examples include database programs, programs that edit only parts of large files, programs that write text-only files, and programs that share data files.  
  
 In these cases, you can override the [Serialize](../vs140/cobject--serialize.md) function in a different way to mediate file actions through a [CFile](../vs140/cfile-class.md) object rather than a [CArchive](../vs140/carchive-class.md) object.  
  
 You can use the **Open**, **Read**, **Write**, **Close**, and `Seek` member functions of class `CFile` to open a file, move the file pointer (seek) to a specific point in the file, read a record (a specified number of bytes) at that point, let the user update the record, then seek to the same point again and write the record back to the file. The framework will open the file for you, and you can use the `GetFile` member function of class `CArchive` to obtain a pointer to the `CFile` object. For even more sophisticated and flexible use, you can override the [OnOpenDocument](../vs140/cdocument--onopendocument.md) and [OnSaveDocument](../vs140/cdocument--onsavedocument.md) member functions of class `CWinApp`. For more information, see class [CFile](../vs140/cfile-class.md) in the *MFC Reference*.  
  
 In this scenario, your `Serialize` override does nothing, unless, for example, you want to have it read and write a file header to keep it up to date when the document closes.  
  
## See Also  
 [Using Documents](../vs140/using-documents.md)