---
title: "CTime::GetLocalTm"
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
  - "CTime.GetLocalTm"
  - "GetLocalTm"
  - "ATL::CTime::GetLocalTm"
  - "ATL.CTime.GetLocalTm"
  - "CTime::GetLocalTm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, conversion"
  - "GetLocalTm method"
ms.assetid: 30aed7e9-326d-48ec-bc85-9a3ba7ae5f11
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetLocalTm
Gets a **struct tm** containing a decomposition of the time contained in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the time data. If this pointer is **NULL**, an exception is thrown.  
  
## Return Value  
 A pointer to a filled-in **struct tm** as defined in the include file TIME.H. See [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md) for the structure layout.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns local time.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If you want to revert to the old behavior, in which <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> could be <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to indicate that an internal, statically allocated buffer should be used, then undefine <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#157](../vs140/codesnippet/CPP/ctime--getlocaltm_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)