---
title: "CMFCFilterChunkValueImpl::SetDwordValue"
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
  - "afxwin/CMFCFilterChunkValueImpl::SetDwordValue"
  - "SetDwordValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDwordValue"
ms.assetid: 5a1a989b-b8a5-44d4-b827-1df9c6c3340c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFilterChunkValueImpl::SetDwordValue
Set the property by key to a DWORD.  
  
## Syntax  
  
```  
HRESULT SetDwordValue(  
   REFPROPERTYKEY pkey,  
   DWORD dwVal,  
   CHUNKSTATE chunkType = CHUNK_VALUE,  
   LCID locale = 0,  
   DWORD cwcLenSource = 0,  
   DWORD cwcStartSource = 0,  
   CHUNK_BREAKTYPE chunkBreakType = CHUNK_NO_BREAK  
);  
```  
  
#### Parameters  
 `pkey`  
 Specifies a property key.  
  
 `dwVal`  
 Specifies the chunk value to set.  
  
 `chunkType`  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 `locale`  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 `cwcLenSource`  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 `cwcStartSource`  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 `chunkBreakType`  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
## Return Value  
 S_OK if successful; otherwise an error code.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMFCFilterChunkValueImpl Class](../vs140/cmfcfilterchunkvalueimpl-class.md)