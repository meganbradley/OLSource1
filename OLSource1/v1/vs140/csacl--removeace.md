---
title: "CSacl::RemoveAce"
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
  - "RemoveAce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAce method"
ms.assetid: 23b4ce20-8667-45aa-aeaf-899844d918b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSacl::RemoveAce
Removes a specific ACE (access-control entry) from the **CSacl** object.  
  
## Syntax  
  
```  
  
      void RemoveAce(   
   UINT nIndex   
) throw( );  
```  
  
#### Parameters  
 `nIndex`  
 Index to the ACE entry to remove.  
  
## Remarks  
 This method is derived from [CAtlArray::RemoveAt](../vs140/catlarray--removeat.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSacl Class](../vs140/csacl-class.md)   
 [CSacl::RemoveAllAces](../vs140/csacl--removeallaces.md)