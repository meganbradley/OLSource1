---
title: "CSharedFile::Detach"
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
  - "CSharedFile::Detach"
  - "CSharedFile.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: 23c0d60e-771a-4676-af38-0ec7eb2f266a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSharedFile::Detach
Call this function to close the memory file and detach it from the memory block.  
  
## Syntax  
  
```  
  
HGLOBAL Detach( );  
  
```  
  
## Return Value  
 The handle of the memory block that contains the contents of the memory file.  
  
## Remarks  
 You can reopen it by calling [SetHandle](../vs140/csharedfile--sethandle.md), using the handle returned by **Detach**.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CSharedFile Class](../vs140/csharedfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSharedFile::CSharedFile](../vs140/csharedfile--csharedfile.md)   
 [CSharedFile::SetHandle](../vs140/csharedfile--sethandle.md)