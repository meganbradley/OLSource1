---
title: "CMFCFilterChunkValueImpl::SetFileTimeValue"
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
  - "SetFileTimeValue"
  - "afxwin/CMFCFilterChunkValueImpl::SetFileTimeValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFileTimeValue"
ms.assetid: 6bb3921b-25a1-45b7-a9bf-92b2922ed14c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFilterChunkValueImpl::SetFileTimeValue
Set the property by key to a filetime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
## Return Value  
 S_OK if successful; otherwise an error code.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMFCFilterChunkValueImpl Class](../vs140/cmfcfilterchunkvalueimpl-class.md)