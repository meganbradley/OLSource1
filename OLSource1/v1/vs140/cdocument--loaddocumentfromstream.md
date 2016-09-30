---
title: "CDocument::LoadDocumentFromStream"
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
  - "LoadDocumentFromStream"
  - "afxwin/CDocument::LoadDocumentFromStream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadDocumentFromStream"
ms.assetid: fadee1dc-ca1f-4874-8950-5e3d9728d1ba
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::LoadDocumentFromStream
Called to load document data from a stream.  
  
## Syntax  
  
```  
virtual HRESULT LoadDocumentFromStream(  
   IStream* pStream,  
   DWORD dwGrfMode  
);  
```  
  
#### Parameters  
 `pStream`  
 A pointer to a stream. This stream is supplied by the Shell.  
  
 `dwGrfMode`  
 Access mode to the stream.  
  
## Return Value  
 S_OK if the load operation succeeds, otherwise HRESULT with an error code.  
  
## Remarks  
 You can override this method in a derived class to customize how to load data from the stream.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)