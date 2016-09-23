---
title: "CEnumerator::Find"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CEnumerator::Find
  - ATL::CEnumerator::Find
  - ATL.CEnumerator.Find
  - CEnumerator.Find
dev_langs: 
  - C++
helpviewer_keywords: 
  - Find method
ms.assetid: 69a153af-d6c3-40fd-9018-27c7d2f344c6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEnumerator::Find
Looks for a specified name among available providers.  
  
## Syntax  
  
```  
  
      bool Find(   
   TCHAR* szSearchName    
) throw( );  
```  
  
#### Parameters  
 *szSearchName*  
 [in] The name to search for.  
  
## Return Value  
 **true** if the name was found. Otherwise, **false**.  
  
## Remarks  
 This name maps to the **SOURCES_NAME** member of the [ISourcesRowset](https://msdn.microsoft.com/en-us/library/ms715969.aspx) interface.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CEnumerator Class](../vs140/cenumerator-class.md)