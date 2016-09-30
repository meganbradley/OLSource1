---
title: "Retrieving a BLOB"
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
  - "retrieving BLOBs"
  - "BLOB (binary large object), retrieving"
  - "OLE DB, BLOBs (binary large objects)"
ms.assetid: 2893eb0a-5c05-4016-8914-1e40ccbaf0b3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Retrieving a BLOB
You can retrieve a binary large object (BLOB) in various ways. You can use **DBTYPE_BYTES** to retrieve the BLOB as a sequence of bytes or use an interface like <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For more information, see [BLOBS and OLE Objects](https://msdn.microsoft.com/en-us/library/ms711511.aspx) in the *OLE DB Programmer's Reference*.  
  
 The following code shows how to retrieve a BLOB using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The macro [BLOB_ENTRY](../vs140/blob_entry.md) allows you to specify the interface and the flags used for the interface. After opening the table, the code calls **Read** repeatedly on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to read bytes from the BLOB. The code calls **Release** to dispose of the interface pointer before calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to obtain the next record.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information about macros that handle BLOB data, see "Column Map Macros" in [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md).  
  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)   
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)