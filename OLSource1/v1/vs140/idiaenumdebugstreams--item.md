---
title: "IDiaEnumDebugStreams::Item"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumDebugStreams::Item method"
ms.assetid: 6b388fe1-eabc-4720-9d59-dc09b0ceaeac
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreams::Item
Retrieves a debug stream by means of an index or name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 index  
 [in] Index or name of the debug stream to be retrieved. If an integer variant is used, it must be in the range 0 to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-1, where <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is as returned by the [IDiaEnumDebugStreams::get_Count](../vs140/idiaenumdebugstreams--get_count.md) method.  
  
 stream  
 [out] Returns an [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md) object representing the specified debug stream.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md)