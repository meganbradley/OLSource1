---
title: "CRegKey::SetBinaryValue"
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
  - "ATL.CRegKey.SetBinaryValue"
  - "CRegKey::SetBinaryValue"
  - "ATL::CRegKey::SetBinaryValue"
  - "SetBinaryValue"
  - "CRegKey.SetBinaryValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBinaryValue method"
ms.assetid: f6887e94-8c24-4509-9c5c-d208008dc732
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetBinaryValue
Call this method to set the binary value of the registry key.  
  
## Syntax  
  
```  
  
      LONG SetBinaryValue(  
   LPCTSTR pszValueName,  
   const void* pValue,  
   ULONG nBytes   
) throw( );  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 `pValue`  
 Pointer to a buffer containing the data to be stored with the specified value name.  
  
 `nBytes`  
 Specifies the size, in bytes, of the information pointed to by the `pValue` parameter.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::QueryBinaryValue](../vs140/cregkey--querybinaryvalue.md)   
 [CRegKey::SetDWORDValue](../vs140/cregkey--setdwordvalue.md)   
 [CRegKey::SetQWORDValue](../vs140/cregkey--setqwordvalue.md)   
 [CRegKey::SetGUIDValue](../vs140/cregkey--setguidvalue.md)   
 [CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)   
 [CRegKey::SetMultiStringValue](../vs140/cregkey--setmultistringvalue.md)