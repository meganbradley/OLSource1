---
title: "CRegKey::QueryQWORDValue"
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
  - "CRegKey::QueryQWORDValue"
  - "QueryQWORDValue"
  - "CRegKey.QueryQWORDValue"
  - "ATL::CRegKey::QueryQWORDValue"
  - "ATL.CRegKey.QueryQWORDValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryQWORDValue method"
ms.assetid: 0eae03d1-2424-4cdf-afab-d99434b0219a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::QueryQWORDValue
Call this method to retrieve the QWORD data for a specified value name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the QWORD.  
  
## Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_QWORD, ERROR_INVALID_DATA is returned.  
  
## Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetQWORDValue](../vs140/cregkey--setqwordvalue.md)   
 [CRegKey::QueryBinaryValue](../vs140/cregkey--querybinaryvalue.md)   
 [CRegKey::QueryDWORDValue](../vs140/cregkey--querydwordvalue.md)   
 [CRegKey::QueryGUIDValue](../vs140/cregkey--queryguidvalue.md)   
 [CRegKey::QueryMultiStringValue](../vs140/cregkey--querymultistringvalue.md)   
 [CRegKey::QueryStringValue](../vs140/cregkey--querystringvalue.md)