---
title: "CRegKey::SetKeyValue"
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
  - "SetKeyValue"
  - "CRegKey::SetKeyValue"
  - "CRegKey.SetKeyValue"
  - "ATL.CRegKey.SetKeyValue"
  - "ATL::CRegKey::SetKeyValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetKeyValue method"
ms.assetid: 71dc9fb9-96ba-4725-918a-71087de10cba
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetKeyValue
Call this method to store data in a specified value field of a specified key.  
  
## Syntax  
  
```  
  
      LONG SetKeyValue(  
   LPCTSTR lpszKeyName,  
   LPCTSTR lpszValue,  
   LPCTSTR lpszValueName = NULL   
) throw( );  
```  
  
#### Parameters  
 `lpszKeyName`  
 Specifies the name of the key to be created or opened. This name must be a subkey of [m_hKey](../vs140/cregkey--m_hkey.md).  
  
 `lpszValue`  
 Specifies the data to be stored. This parameter must be non-NULL.  
  
 `lpszValueName`  
 Specifies the value field to be set. If a value field with this name does not already exist in the key, it is added.  
  
## Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 Call this method to create or open the `lpszKeyName` key and store the `lpszValue` data in the `lpszValueName` value field.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetValue](../vs140/cregkey--setvalue.md)