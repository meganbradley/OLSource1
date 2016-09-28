---
title: "CTokenGroups::GetPTOKEN_GROUPS"
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
  - "ATL::CTokenGroups::GetPTOKEN_GROUPS"
  - "ATL.CTokenGroups.GetPTOKEN_GROUPS"
  - "CTokenGroups.GetPTOKEN_GROUPS"
  - "CTokenGroups::GetPTOKEN_GROUPS"
  - "GetPTOKEN_GROUPS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPTOKEN_GROUPS method"
ms.assetid: 70c0bb52-4962-4680-8822-368a2613a661
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenGroups::GetPTOKEN_GROUPS
Retrieves a pointer to the **TOKEN_GROUPS** structure.  
  
## Syntax  
  
```  
  
const TOKEN_GROUPS * GetPTOKEN_GROUPS( ) const throw(...);  
  
```  
  
## Return Value  
 Retrieves a pointer to the [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure belonging to the `CTokenGroups` access token object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenGroups Class](../vs140/ctokengroups-class.md)