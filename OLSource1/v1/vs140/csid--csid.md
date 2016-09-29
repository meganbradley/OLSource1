---
title: "CSid::CSid"
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
  - "ATL.CSid.CSid"
  - "CSid::CSid"
  - "ATL::CSid::CSid"
  - "CSid.CSid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSid constructor"
  - "CSid class, constructor"
ms.assetid: d5cbd33a-5705-4d84-bae5-f7f7e914e907
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::CSid
The constructor.  
  
## Syntax  
  
```  
  
      CSid( ) throw( );   
CSid(  
   const SID & rhs   
) throw(...);  
CSid(  
   const CSid & rhs   
) throw(...);  
CSid(  
   const SID_IDENTIFIER_AUTHORITY & IdentifierAuthority,  
   BYTE nSubAuthorityCount,  
   ...   
) throw(...);  
explicit CSid(  
   LPCTSTR pszAccountName,  
   LPCTSTR pszSystem = NULL   
) throw(...);  
explicit CSid(  
   const SID * pSid,  
   LPCTSTR pszSystem = NULL   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 An existing `CSid` object or `SID` (security identifier) structure.  
  
 *IdentifierAuthority*  
 The authority.  
  
 *nSubAuthorityCount*  
 The subauthority count.  
  
 `pszAccountName`  
 The account name.  
  
 `pszSystem`  
 The system name. This string can be the name of a remote computer. If this string is NULL, the local system is used instead.  
  
 `pSid`  
 A pointer to a `SID` structure.  
  
## Remarks  
 The constructor initializes the `CSid` object, setting an internal data member to *SidTypeInvalid*, or by copying the settings from an existing `CSid`, `SID`, or existing account.  
  
 If initialization fails, the constructor will throw a [CAtlException Class](../vs140/catlexception-class.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)