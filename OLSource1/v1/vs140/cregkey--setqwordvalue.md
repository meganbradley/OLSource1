---
title: "CRegKey::SetQWORDValue"
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
  - "CRegKey.SetQWORDValue"
  - "ATL::CRegKey::SetQWORDValue"
  - "SetQWORDValue"
  - "CRegKey::SetQWORDValue"
  - "ATL.CRegKey.SetQWORDValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetQWORDValue method"
ms.assetid: cde62b57-2c81-480a-b9d2-558667d598b2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetQWORDValue
Call this method to set the QWORD value of the registry key.  
  
## Syntax  
  
```  
  
      LONG SetQWORDValue(  
   LPCTSTR pszValueName,  
   ULONGLONG qwValue   
) throw( );  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 `qwValue`  
 The QWORD data to be stored with the specified value name.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::QueryQWORDValue](../vs140/cregkey--queryqwordvalue.md)   
 [CRegKey::SetDWORDValue](../vs140/cregkey--setdwordvalue.md)   
 [CRegKey::SetGUIDValue](../vs140/cregkey--setguidvalue.md)   
 [CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)   
 [CRegKey::SetMultiStringValue](../vs140/cregkey--setmultistringvalue.md)   
 [CRegKey::SetBinaryValue](../vs140/cregkey--setbinaryvalue.md)