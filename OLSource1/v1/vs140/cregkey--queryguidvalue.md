---
title: "CRegKey::QueryGUIDValue"
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
  - "ATL::CRegKey::QueryGUIDValue"
  - "QueryGUIDValue"
  - "ATL.CRegKey.QueryGUIDValue"
  - "CRegKey::QueryGUIDValue"
  - "CRegKey.QueryGUIDValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryGUIDValue method"
ms.assetid: 688d9746-64d8-4303-bce5-fd3dbef2c703
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::QueryGUIDValue
Call this method to retrieve the GUID data for a specified value name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the GUID.  
  
## Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not a valid GUID, ERROR_INVALID_DATA is returned.  
  
## Remarks  
 This method makes use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and converts the string into a GUID using [CLSIDFromString](http://msdn.microsoft.com/library/windows/desktop/ms680589).  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetGUIDValue](../vs140/cregkey--setguidvalue.md)   
 [CRegKey::QueryBinaryValue](../vs140/cregkey--querybinaryvalue.md)   
 [CRegKey::QueryDWORDValue](../vs140/cregkey--querydwordvalue.md)   
 [CRegKey::QueryMultiStringValue](../vs140/cregkey--querymultistringvalue.md)   
 [CRegKey::QueryQWORDValue](../vs140/cregkey--queryqwordvalue.md)   
 [CRegKey::QueryStringValue](../vs140/cregkey--querystringvalue.md)