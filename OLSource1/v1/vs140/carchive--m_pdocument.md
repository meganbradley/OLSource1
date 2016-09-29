---
title: "CArchive::m_pDocument"
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
  - "CArchive.m_pDocument"
  - "m_pDocument"
  - "CArchive::m_pDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, data members"
  - "m_pDocument"
ms.assetid: 15cd0815-845f-4255-97e9-1efcae7a72a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::m_pDocument
Set to **NULL** by default, this pointer to a **CDocument** can be set to anything the user of the `CArchive` instance wants.  
  
## Syntax  
  
```  
  
CDocument* m_pDocument;  
  
```  
  
## Remarks  
 A common usage of this pointer is to convey additional information about the serialization process to all objects being serialized. This is achieved by initializing the pointer with the document (a **CDocument**-derived class) that is being serialized, in such a way that objects within the document can access the document if necessary. This pointer is also used by `COleClientItem` objects during serialization.  
  
 The framework sets `m_pDocument` to the document being serialized when a user issues a File Open or Save command. If you serialize an Object Linking and Embedding (OLE) container document for reasons other than File Open or Save, you must explicitly set `m_pDocument`. For example, you would do this when serializing a container document to the Clipboard.  
  
## Example  
 [!code[NVC_MFCSerialization#35](../vs140/codesnippet/CPP/carchive--m_pdocument_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument Class](../vs140/cdocument-class.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)