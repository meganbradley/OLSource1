---
title: "CRegKey::QueryValue"
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
  - "CRegKey::QueryValue"
  - "ATL::CRegKey::QueryValue"
  - "QueryValue"
  - "CRegKey.QueryValue"
  - "ATL.CRegKey.QueryValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryValue method"
ms.assetid: 79ad782e-9718-4fcc-8a5b-8d2daa8e852e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::QueryValue
Call this method to retrieve the data for the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.  
  
## Syntax  
  
```  
  
      LONG QueryValue(  
   LPCTSTR pszValueName,  
   DWORD* pdwType,  
   void* pData,  
   ULONG* pnBytes  
) throw( );  
ATL_DEPRECATED LONG QueryValue(  
   DWORD& dwValue,  
   LPCTSTR lpszValueName   
);  
ATL_DEPRECATED LONG QueryValue(  
   LPTSTR szValue,  
   LPCTSTR lpszValueName,  
   DWORD* pdwCount   
);  
```  
  
#### Parameters  
 `pszValueName`  
 Pointer to a null-terminated string containing the name of the value to query. If `pszValueName` is NULL or an empty string, "", the method retrieves the type and data for the key's unnamed or default value, if any.  
  
 `pdwType`  
 Pointer to a variable that receives a code indicating the type of data stored in the specified value. The `pdwType` parameter can be NULL if the type code is not required.  
  
 `pData`  
 Pointer to a buffer that receives the value's data. This parameter can be NULL if the data is not required.  
  
 `pnBytes`  
 Pointer to a variable that specifies the size, in bytes, of the buffer pointed to by the `pData` parameter. When the method returns, this variable contains the size of the data copied to *pData.*  
  
 `dwValue`  
 The value field's numerical data.  
  
 `lpszValueName`  
 Specifies the value field to be queried.  
  
 `szValue`  
 The value field's string data.  
  
 `pdwCount`  
 The size of the string data. Its value is initially set to the size of the `szValue` buffer.  
  
## Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 The two original versions of `QueryValue` are no longer supported and are marked as **ATL_DEPRECATED**. The compiler will issue a warning if these forms are used.  
  
 The remaining method calls RegQueryValueEx.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the RegQueryValueEx function used by this method does not explicitly handle strings which are `NULL` terminated. Both conditions should be checked for by the calling code.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetValue](../vs140/cregkey--setvalue.md)   
 [Registry Value Types](http://msdn.microsoft.com/library/windows/desktop/ms724884)