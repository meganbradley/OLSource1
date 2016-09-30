---
title: "CRegKey::DeleteSubKey"
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
  - "CRegKey.DeleteSubKey"
  - "DeleteSubKey"
  - "CRegKey::DeleteSubKey"
  - "ATL.CRegKey.DeleteSubKey"
  - "ATL::CRegKey::DeleteSubKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteSubKey method"
ms.assetid: 58edbe7f-6b4a-4923-9cb5-93bfa5d2014e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::DeleteSubKey
Call this method to remove the specified key from the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the name of the key to delete. This name must be a subkey of [m_hKey](../vs140/cregkey--m_hkey.md).  
  
## Return Value  
 If successful, returns ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can only delete a key that has no subkeys. If the key has subkeys, call [RecurseDeleteKey](../vs140/cregkey--recursedeletekey.md) instead.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::DeleteValue](../vs140/cregkey--deletevalue.md)