---
title: "CreatorMap Structure"
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
  - module/Microsoft::WRL::Details::CreatorMap
  - implements/Microsoft::WRL::Details::CreatorMap
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreatorMap structure
ms.assetid: 94e40927-90c3-4107-bca3-3ad2dc4beda9
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CreatorMap Structure
Supports the [!INCLUDE[cppwrl](../vs140/includes/cppwrl_md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
struct CreatorMap;  
```  
  
## Remarks  
 Contains information about how to initialize, register, and unregister objects.  
  
 CreatorMap contains the following information:  
  
-   How to initialize, register, and unregister objects.  
  
-   How to compare activation data depending on a classic COM or [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] factory.  
  
-   Information about the factory cache and server name for an interface.  
  
## Members  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CreatorMap::activationId Data Member](../vs140/creatormap--activationid-data-member.md)|Represents an object ID that is identified either by a classic COM class ID or a [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] name.|  
|[CreatorMap::factoryCache Data Member](../vs140/creatormap--factorycache-data-member.md)|Stores the pointer to the factory cache for the CreatorMap.|  
|[CreatorMap::factoryCreator Data Member](../vs140/creatormap--factorycreator-data-member.md)|Creates a factory for the specified CreatorMap.|  
|[CreatorMap::serverName Data Member](../vs140/creatormap--servername-data-member.md)|Stores the server name for the CreatorMap.|  
  
## Inheritance Hierarchy  
 `CreatorMap`  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)