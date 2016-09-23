---
title: "CRegKey::EnumKey"
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
  - ATL::CRegKey::EnumKey
  - EnumKey
  - ATL.CRegKey.EnumKey
  - CRegKey.EnumKey
  - CRegKey::EnumKey
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnumKey method
ms.assetid: 8dc25ea5-db52-4a43-8fc8-f517215aacc5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRegKey::EnumKey
Call this method to enumerate the subkeys of the open registry key.  
  
## Syntax  
  
```  
  
      LONG EnumKey(  
   DWORD iIndex,  
   LPTSTR pszName,  
   LPDWORD pnNameLength,  
   FILETIME* pftLastWriteTime = NULL   
) throw( );  
```  
  
#### Parameters  
 `iIndex`  
 The subkey index. This parameter should be zero for the first call and then incremented for subsequent calls  
  
 `pszName`  
 Pointer to a buffer that receives the name of the subkey, including the terminating null character. Only the name of the subkey is copied to the buffer, not the full key hierarchy.  
  
 *pnNameLength*  
 Pointer to a variable that specifies the size, in TCHARs, of the buffer specified by the `pszName` parameter. This size should include the terminating null character. When the method returns, the variable pointed to by *pnNameLength* contains the number of characters stored in the buffer. The count returned does not include the terminating null character.  
  
 *pftLastWriteTime*  
 Pointer to a variable that receives the time the enumerated subkey was last written to.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 To enumerate the subkeys, call `CRegKey::EnumKey` with an index of zero. Increment the index value and repeat until the method returns ERROR_NO_MORE_ITEMS. For more information, see [RegEnumKeyEx](http://msdn.microsoft.com/library/windows/desktop/ms724862) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)