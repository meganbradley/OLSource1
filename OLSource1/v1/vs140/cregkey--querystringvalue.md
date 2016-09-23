---
title: "CRegKey::QueryStringValue"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CRegKey.QueryStringValue
  - QueryStringValue
  - CRegKey.QueryStringValue
  - CRegKey::QueryStringValue
  - ATL::CRegKey::QueryStringValue
dev_langs: 
  - C++
helpviewer_keywords: 
  - QueryStringValue method
ms.assetid: bc80e493-c93b-48c6-9c4b-421d187f1c94
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRegKey::QueryStringValue
Call this method to retrieve the string data for a specified value name.  
  
## Syntax  
  
```  
  
      LONG QueryStringValue(  
   LPCTSTR pszValueName,  
   LPTSTR pszValue,  
   ULONG* pnChars   
) throw( );  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 `pszValue`  
 Pointer to a buffer that receives the string data.  
  
 `pnChars`  
 The size, in TCHARs, of the buffer pointed to by `pszValue`. When the method returns, `pnChars` contains the size, in TCHARs, of the string retrieved, including a terminating null character.  
  
## Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_SZ, ERROR_INVALID_DATA is returned. If the method returns ERROR_MORE_DATA, `pnChars` equals zero, not the required buffer size in bytes.  
  
## Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)   
 [CRegKey::QueryBinaryValue](../vs140/cregkey--querybinaryvalue.md)   
 [CRegKey::QueryDWORDValue](../vs140/cregkey--querydwordvalue.md)   
 [CRegKey::QueryGUIDValue](../vs140/cregkey--queryguidvalue.md)   
 [CRegKey::QueryMultiStringValue](../vs140/cregkey--querymultistringvalue.md)   
 [CRegKey::QueryQWORDValue](../vs140/cregkey--queryqwordvalue.md)