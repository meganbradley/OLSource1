---
title: "CSettingsStore::Write"
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
  - CSettingsStore::Write
  - Write
  - CSettingsStore.Write
dev_langs: 
  - C++
helpviewer_keywords: 
  - Write method
ms.assetid: b0493fc2-3e17-4832-bf9b-a3fa7072d46a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSettingsStore::Write
Writes a value to the registry under the open key.  
  
## Syntax  
  
```  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   int iVal   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   DWORD dwVal   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   LPCTSTR pszVal   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CStringList& scStringList   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CByteArray& bcArray   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CStringArray& scArray   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CDWordArray& dwcArray   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CWordArray& wcArray   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   const CRect& rect   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   LPPOINT& lpPoint   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   LPBYTE pData,  
   UINT nBytes   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CObList& list   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CObject& obj   
);  
virtual BOOL Write(  
   LPCTSTR pszKey,  
   CObject* pObj   
);  
```  
  
#### Parameters  
 [in] `pszKey`  
 Pointer to a string that contains the name of the value to set.  
  
 [in] `iVal`  
 Reference to an integer variable that contains the data to store.  
  
 [in] `dwVal`  
 Reference to a 32-bit double word variable that contains the data to store.  
  
 [in] `pszVal`  
 Pointer to a null-terminated string variable that contains the data to store.  
  
 [in] `scStringList`  
 Reference to a [CStringList](../vs140/cstringlist-class.md) variable that contains the data to store.  
  
 [in] `bcArray`  
 Reference to a byte array variable that contains the data to store.  
  
 [in] `scArray`  
 Reference to a string array variable that contains the data to store.  
  
 [in] `dwcArray`  
 Reference to a 32-bit double word array variable that contains the data to store.  
  
 [in] `wcArray`  
 Reference to a 16-bit word array variable that contains the data to store.  
  
 [in] `rect`  
 Reference to a [CRect](../vs140/crect-class.md) variable that contains the data to store.  
  
 [in] `lpPoint`  
 Reference to a pointer to a `POINT` variable that contains the data to store.  
  
 [in] `pData`  
 Pointer to a buffer that contains the data to store.  
  
 [in] `nBytes`  
 Specifies the size, in bytes, of the data to which the `pData` parameter points.  
  
 [in] `list`  
 Reference to a [CObList](../vs140/coblist-class.md) variable that contains the data to store.  
  
 [in] `obj`  
 Reference to a [CObject](../vs140/cobject-class.md) variable that contains the data to store.  
  
 [in] `pObj`  
 Pointer to a pointer to a `CObject` variable that contains the data to store.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 In order to write to the registry, you must set `bReadOnly` to a nonzero value when you create a [CSettingsStore](../vs140/csettingsstore-class.md) object. For more information, see [CSettingsStore::CSettingsStore](../vs140/csettingsstore--csettingsstore.md).  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CSettingsStore::CSettingsStore](../vs140/csettingsstore--csettingsstore.md)