---
title: "CRegKey::GetKeySecurity"
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
  - "ATL.CRegKey.GetKeySecurity"
  - "ATL::CRegKey::GetKeySecurity"
  - "GetKeySecurity"
  - "CRegKey.GetKeySecurity"
  - "CRegKey::GetKeySecurity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKeySecurity method"
ms.assetid: 6aa2e6fe-c679-4682-ad40-d782899a776d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::GetKeySecurity
Call this method to retrieve a copy of the security descriptor protecting the open registry key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) value that indicates the requested security information.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives a copy of the requested security descriptor.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size, in bytes, of the buffer pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code is defined in WINERROR.H.  
  
## Remarks  
 For more information, see [RegGetKeySecurity](http://msdn.microsoft.com/library/windows/desktop/aa379313).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetKeySecurity](../vs140/cregkey--setkeysecurity.md)