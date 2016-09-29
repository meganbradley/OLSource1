---
title: "IResourceManager::OSVersion Enumeration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrtrm/concurrency::IResourceManager::OSVersion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OSVersion enumeration"
ms.assetid: 6d545102-d2a2-46af-a8ae-4f4eafbdbaae
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::OSVersion Enumeration
An enumerated type that represents the operating system version.  
  
## Syntax  
  
```  
enum OSVersion;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`UmsThreadAwareOS`|Preserved for legacy reasons.|  
|`UnsupportedOS`|An operating system prior to Windows XP. The Concurrency Runtime is not supported on operating systems with a version earlier than Windows XP with Service Pack 3.|  
|`Vista`|The Windows Vista and Windows Server 2008 operating systems.|  
|`Win2k3`|The Windows 2003 Server operating system.|  
|`Win7OrLater`|The Windows 7 and Windows Server 2008 R2 operating systems.|  
|`Win8OrLater`|Any operating system with version Windows 8 or higher.|  
|`XP`|The Windows XP operating system.|  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)