---
title: "CSettingsStore::Read"
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
  - CSettingsStore.Read
  - CSettingsStore::Read
  - Read
dev_langs: 
  - C++
helpviewer_keywords: 
  - Read method
ms.assetid: 19d589be-228c-434c-a848-be5a2572a53f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSettingsStore::Read
Reads a value from a key in the registry.  
  
## Syntax  
  
```  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   int& iVal   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   DWORD& dwVal   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CString& sVal   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CStringList& scStringList   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CStringArray& scArray   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CDWordArray& dwcArray   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CWordArray& wcArray   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CByteArray& bcArray   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   LPPOINT& lpPoint   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CRect& rect   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   BYTE** ppData,  
   UINT* pBytes   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CObList& list   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CObject& obj   
);  
virtual BOOL Read(  
   LPCTSTR pszKey,  
   CObject*& pObj   
);  
```  
  
#### Parameters  
 [in] `pszKey`  
 Pointer to a null-terminated string that contains the name of the value to read from the registry.  
  
 [out] `iVal`  
 Reference to an integer variable that receives the value read from the registry key.  
  
 [out] `dwVal`  
 Reference to a 32-bit double word variable that receives the value read from the registry key.  
  
 [out] `sVal`  
 Reference to a string variable that receives the value read from the registry key.  
  
 [out] `scStringList`  
 Reference to a string list variable that receives the value read from the registry key.  
  
 [out] `scArray`  
 Reference to a string array variable that receives the value read from the registry key.  
  
 [out] `dwcArray`  
 Reference to a 32-bit double word array variable that receives the value read from the registry key.  
  
 [out] `wcArray`  
 Reference to a 16-bit word array variable that receives the value read from the registry key.  
  
 [out] `bcArray`  
 Reference to a byte array variable that receives the value read from the registry key.  
  
 [out] `lpPoint`  
 Reference to a pointer to a `POINT` structure that receives the value read from the registry key.  
  
 [out] `rect`  
 Reference to a [CRect](../vs140/crect-class.md) variable that receives the value read from the registry key.  
  
 [out] `ppData`  
 Pointer to a pointer to data that receives the value read from the registry key.  
  
 [out] `pBytes`  
 Pointer to an unsigned integer variable. This variable receives the size of the buffer that `ppData` points to.  
  
 [out] `list`  
 Reference to a [CObList](../vs140/coblist-class.md) variable that receives the value read from the registry key.  
  
 [out] `obj`  
 Reference to a [CObject](../vs140/cobject-class.md) variable that receives the value read from the registry key.  
  
 [out] `pObj`  
 Reference to a pointer to a `CObject` variable that receives the value read from the registry key.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 `Read` checks for `pszKey` as a subkey of `m_hKey`.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)