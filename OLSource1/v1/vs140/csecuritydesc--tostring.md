---
title: "CSecurityDesc::ToString"
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
  - "CSecurityDesc::ToString"
  - "ATL.CSecurityDesc.ToString"
  - "ToString"
  - "CSecurityDesc.ToString"
  - "ATL::CSecurityDesc::ToString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ToString method"
ms.assetid: b9be62c8-de96-49b2-8e70-ede0864302c8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::ToString
Converts a security descriptor to a string format.  
  
## Syntax  
  
```  
  
      bool ToString(  
   CString * pstr,  
   SECURITY_INFORMATION si = OWNER_SECURITY_INFORMATION |   
      GROUP_SECURITY_INFORMATION | DACL_SECURITY_INFORMATION |   
      SACL_SECURITY_INFORMATION   
) const throw(...);  
```  
  
#### Parameters  
 `pstr`  
 Pointer to a null-terminated string which will receive the [string-format security descriptor](http://msdn.microsoft.com/library/windows/desktop/aa379570).  
  
 `si`  
 Specifies a combination of SECURITY_INFORMATION bit flags to indicate the components of the security descriptor to include in the output string.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 Once the security descriptor is in string format, it can more easily be stored or transmitted. Use the `CSecurityDesc::FromString` method to convert the string back into a security descriptor.  
  
 The `si` parameter can contain the following SECURITY_INFORMATION flags:  
  
|Value|Meaning|  
|-----------|-------------|  
|OWNER_SECURITY_INFORMATION|Include the owner.|  
|GROUP_SECURITY_INFORMATION|Include the primary group.|  
|DACL_SECURITY_INFORMATION|Include the DACL.|  
|SACL_SECURITY_INFORMATION|Include the SACL.|  
  
 If the DACL is NULL and the SE_DACL_PRESENT control bit is set in the input security descriptor, the method fails.  
  
 If the DACL is NULL and the SE_DACL_PRESENT control bit is not set in the input security descriptor, the resulting security descriptor string does not have a D: component. See [Security Descriptor String Format](http://msdn.microsoft.com/library/windows/desktop/aa379570) for more details.  
  
 This method is only available with Windows 2000 and later, as it calls [ConvertStringSecurityDescriptorToSecurityDescriptor](http://msdn.microsoft.com/library/windows/desktop/aa376401).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561)   
 [CSecurityDesc::FromString](../vs140/csecuritydesc--fromstring.md)