---
title: "CRegKey::SetGUIDValue"
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
  - "CRegKey::SetGUIDValue"
  - "ATL.CRegKey.SetGUIDValue"
  - "SetGUIDValue"
  - "CRegKey.SetGUIDValue"
  - "ATL::CRegKey::SetGUIDValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGUIDValue method"
ms.assetid: c9468079-1763-4dd3-b287-0bf6ffe5a40f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetGUIDValue
Call this method to set the GUID value of the registry key.  
  
## Syntax  
  
```  
  
      LONG SetGUIDValue(  
   LPCTSTR pszValueName,  
   REFGUID guidValue   
) throw( );  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 `guidValue`  
 Reference to the GUID to be stored with the specified value name.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 This method makes use of `CRegKey::SetStringValue` and converts the GUID into a string using [StringFromGUID2](http://msdn.microsoft.com/library/windows/desktop/ms683893).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::QueryGUIDValue](../vs140/cregkey--queryguidvalue.md)   
 [CRegKey::SetBinaryValue](../vs140/cregkey--setbinaryvalue.md)   
 [CRegKey::SetDWORDValue](../vs140/cregkey--setdwordvalue.md)   
 [CRegKey::SetQWORDValue](../vs140/cregkey--setqwordvalue.md)   
 [CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)   
 [CRegKey::SetMultiStringValue](../vs140/cregkey--setmultistringvalue.md)