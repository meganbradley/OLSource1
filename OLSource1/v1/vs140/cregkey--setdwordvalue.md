---
title: "CRegKey::SetDWORDValue"
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
  - "SetDWORDValue"
  - "ATL.CRegKey.SetDWORDValue"
  - "ATL::CRegKey::SetDWORDValue"
  - "CRegKey.SetDWORDValue"
  - "CRegKey::SetDWORDValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDWORDValue method"
ms.assetid: 750840b6-5487-451c-9d97-a5237a595f56
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetDWORDValue
Call this method to set the DWORD value of the registry key.  
  
## Syntax  
  
```  
  
      LONG SetDWORDValue(  
   LPCTSTR pszValueName,  
   DWORD dwValue   
) throw( );  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 `dwValue`  
 The DWORD data to be stored with the specified value name.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::QueryDWORDValue](../vs140/cregkey--querydwordvalue.md)   
 [CRegKey::SetQWORDValue](../vs140/cregkey--setqwordvalue.md)   
 [CRegKey::SetBinaryValue](../vs140/cregkey--setbinaryvalue.md)   
 [CRegKey::SetGUIDValue](../vs140/cregkey--setguidvalue.md)   
 [CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)   
 [CRegKey::SetMultiStringValue](../vs140/cregkey--setmultistringvalue.md)