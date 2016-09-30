---
title: "CDacl::RemoveAce"
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
  - "CDacl::RemoveAce"
  - "CDacl.RemoveAce"
  - "RemoveAce"
  - "atl.CDacl.RemoveAce"
  - "atl::CDacl::RemoveAce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAce method"
ms.assetid: 750b6f95-c269-4de6-b233-2058befed0c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDacl::RemoveAce
Removes a specific ACE (access-control entry) from the `CDacl` object.  
  
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
 [CDacl Class](../vs140/cdacl-class.md)   
 [CDacl::RemoveAllAces](../vs140/cdacl--removeallaces.md)