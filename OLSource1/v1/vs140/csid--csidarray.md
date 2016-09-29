---
title: "CSid::CSidArray"
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
  - "ATL::CSid::CSidArray"
  - "CSid.CSidArray"
  - "CSidArray"
  - "ATL.CSid.CSidArray"
  - "CSid::CSidArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSidArray typedef"
ms.assetid: 478b2d5a-7bd9-4313-a281-3386810e83e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::CSidArray
An array of [CSid](../vs140/csid-class.md) objects.  
  
## Syntax  
  
```  
  
typedef CAtlArray<CSid> CSidArray;  
  
```  
  
## Remarks  
 This typedef specifies the array type that can be used to retrieve security identifiers from an ACL (access-control list). See [CAcl::GetAclEntries](../vs140/cacl--getaclentries.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)