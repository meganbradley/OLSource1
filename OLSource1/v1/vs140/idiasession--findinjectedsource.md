---
title: "IDiaSession::findInjectedSource"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::findInjectedSource method"
ms.assetid: 907531b6-1ef8-4153-986d-b72611a1632d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findInjectedSource
Retrieves a list of sources that has been placed into the symbol store by attribute providers or other components of the compilation process.  
  
## Syntax  
  
```cpp#  
HRESULT findInjectedSource (   
   LPCOLESTR                 srcFile,  
   IDiaEnumInjectedSources** ppResult  
);  
```  
  
#### Parameters  
 srcFile  
 [in] Name of the source file for which to search.  
  
 ppResult  
 [out] Returns an [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md) object that contains a list of all of the injected sources.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)   
 [IDiaSession](../vs140/idiasession.md)