---
title: "CTokenGroups::LookupSid"
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
  - CTokenGroups::LookupSid
  - ATL::CTokenGroups::LookupSid
  - LookupSid
  - CTokenGroups.LookupSid
  - ATL.CTokenGroups.LookupSid
dev_langs: 
  - C++
helpviewer_keywords: 
  - LookupSid method
ms.assetid: ff9e2352-985a-47b8-a8d9-becdbad0c347
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTokenGroups::LookupSid
Retrieves the attributes associated with a `CSid` object.  
  
## Syntax  
  
```  
  
      bool LookupSid(  
   const CSid & rSid,  
   DWORD * pdwAttributes = NULL  
) const throw( );  
```  
  
#### Parameters  
 `rSid`  
 The [CSid](../vs140/csid-class.md) object.  
  
 `pdwAttributes`  
 Pointer to a DWORD which will accept the `CSid` object's attribute. If omitted or NULL, the attribute will not be retrieved.  
  
## Return Value  
 Returns true if the `CSid` is found, false otherwise.  
  
## Remarks  
 Setting `pdwAttributes` to NULL provides a way of confirming the existence of the `CSid` without accessing the attribute. Note that this method should not be used to check access rights as incorrect results may occur under Windows 2000. Applications should instead use the [CAccessToken::CheckTokenMembership](../vs140/caccesstoken--checktokenmembership.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenGroups Class](../vs140/ctokengroups-class.md)   
 [CTokenGroups::GetSidsAndAttributes](../vs140/ctokengroups--getsidsandattributes.md)