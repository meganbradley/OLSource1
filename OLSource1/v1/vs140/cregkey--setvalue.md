---
title: "CRegKey::SetValue"
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
  - "CRegKey.SetValue"
  - "ATL.CRegKey.SetValue"
  - "SetValue"
  - "CRegKey::SetValue"
  - "ATL::CRegKey::SetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registry, writing to"
  - "SetValue method"
ms.assetid: 7db96d87-3aa2-48c6-ba57-47dbbef16887
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetValue
Call this method to store data in the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.  
  
## Syntax  
  
```  
  
      LONG SetValue(  
   LPCTSTR pszValueName,  
   DWORD dwType,  
   const void* pValue,  
   ULONG nBytes   
) throw( );  
static LONG WINAPI SetValue(  
   HKEY hKeyParent,  
   LPCTSTR lpszKeyName,  
   LPCTSTR lpszValue,  
   LPCTSTR lpszValueName = NULL);  
ATL_DEPRECATED LONG SetValue(  
   DWORD dwValue,  
   LPCTSTR lpszValueName   
);  
ATL_DEPRECATED LONG SetValue(  
   LPCTSTR lpszValue,  
   LPCTSTR lpszValueName = NULL,  
   bool bMulti = false,  
   int nValueLen = -1  
);  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present in the key, the method adds it to the key. If `pszValueName` is NULL or an empty string, "", the method sets the type and data for the key's unnamed or default value.  
  
 `dwType`  
 Specifies a code indicating the type of data pointed to by the `pValue` parameter.  
  
 `pValue`  
 Pointer to a buffer containing the data to be stored with the specified value name.  
  
 `nBytes`  
 Specifies the size, in bytes, of the information pointed to by the `pValue` parameter. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, `nBytes` must include the size of the terminating null character.  
  
 `hKeyParent`  
 The handle of an open key.  
  
 `lpszKeyName`  
 Specifies the name of a key to be created or opened. This name must be a subkey of `hKeyParent`.  
  
 `lpszValue`  
 Specifies the data to be stored. This parameter must be non-NULL.  
  
 `lpszValueName`  
 Specifies the value field to be set. If a value field with this name does not already exist in the key, it is added.  
  
 `dwValue`  
 Specifies the data to be stored.  
  
 `bMulti`  
 If false, indicates the string is of type REG_SZ. If true, indicates the string is a multistring of type REG_MULTI_SZ.  
  
 `nValueLen`  
 If `bMulti` is true, `nValueLen` is the length of the *lpszValue* string in characters. If `bMulti` is false, a value of -1 indicates that the method will calculate the length automatically.  
  
## Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 The two original versions of `SetValue` are marked as **ATL_DEPRECATED** and should no longer be used. The compiler will issue a warning if these forms are used.  
  
 The third method calls [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetKeyValue](../vs140/cregkey--setkeyvalue.md)   
 [CRegKey::QueryValue](../vs140/cregkey--queryvalue.md)   
 [Registry Value Types](http://msdn.microsoft.com/library/windows/desktop/ms724884)