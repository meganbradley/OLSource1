---
title: "CSid::EqualPrefix"
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
  - "EqualPrefix"
  - "CSid::EqualPrefix"
  - "ATL::CSid::EqualPrefix"
  - "CSid.EqualPrefix"
  - "ATL.CSid.EqualPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EqualPrefix method"
ms.assetid: cb4439dd-f905-4d40-b67f-bd49c709a3da
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::EqualPrefix
Tests `SID` (security identifier) prefixes for equality.  
  
## Syntax  
  
```  
  
      bool EqualPrefix(  
   const SID & rhs   
) const throw();  
bool EqualPrefix(  
   const CSid & rhs   
) const throw();  
```  
  
#### Parameters  
 `rhs`  
 The `SID` (security identifier) structure or `CSid` object to compare.  
  
## Return Value  
 Returns **true** on success, **false** on failure.  
  
## Remarks  
 See [EqualPrefixSid](http://msdn.microsoft.com/library/windows/desktop/aa446621) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more details.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)