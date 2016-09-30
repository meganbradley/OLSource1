---
title: "CArchive::CArchive"
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
  - "CArchive.CArchive"
  - "CArchive::CArchive"
  - "bNoFlushOnDelete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data from archive [C++]"
  - "CArchive method"
  - "CArchive class, constructor"
  - "CArchive class, archive flags"
  - "bNoFlushOnDelete method"
ms.assetid: d21b525f-a538-4b0d-ace7-c5985e72c5df
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::CArchive
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and specifies whether it will be used for loading or storing objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that is the ultimate source or destination of the persistent data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A flag that specifies whether objects will be loaded from or stored to the archive. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter must have one of the following values:  
  
-   **CArchive::load** Loads data from the archive. Requires only <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> read permission.  
  
-   **CArchive::store** Saves data to the archive. Requires <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> write permission.  
  
-   **CArchive::bNoFlushOnDelete** Prevents the archive from automatically calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the archive destructor is called. If you set this flag, you are responsible for explicitly calling **Close** before the destructor is called. If you do not, your data will be corrupted.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An integer that specifies the size of the internal file buffer, in bytes. Note that the default buffer size is 4,096 bytes. If you routinely archive large objects, you will improve performance if you use a larger buffer size that is a multiple of the file buffer size.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An optional pointer to a user-supplied buffer of size <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If you do not specify this parameter, the archive allocates a buffer from the local heap and frees it when the object is destroyed. The archive does not free a user-supplied buffer.  
  
## Remarks  
 You cannot change this specification after you have created the archive.  
  
 You may not use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operations to alter the state of the file until you have closed the archive. Any such operation will damage the integrity of the archive. You may access the position of the file pointer at any time during serialization by obtaining the archive's file object from the [GetFile](../vs140/carchive--getfile.md) member function and then using the [CFile::GetPosition](../vs140/cfile--getposition.md) function. You should call [CArchive::Flush](../vs140/carchive--flush.md) before obtaining the position of the file pointer.  
  
## Example  
 [!code[NVC_MFCSerialization#12](../vs140/codesnippet/CPP/carchive--carchive_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Close](../vs140/carchive--close.md)   
 [CArchive::Flush](../vs140/carchive--flush.md)   
 [CFile::Close](../vs140/cfile--close.md)