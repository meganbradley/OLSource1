---
title: "ATL Collection and Enumerator Classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - enumerators, ATL classes
  - collection classes, ATL
ms.assetid: 6818db73-7094-48d8-a0ca-18147beec362
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATL Collection and Enumerator Classes
ATL provides the following classes to help you implement collections and enumerators.  
  
|Class|Description|  
|-----------|-----------------|  
|[ICollectionOnSTLImpl](../vs140/icollectiononstlimpl-class.md)|Collection interface implementation|  
|[IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md)|Enumerator interface implementation (assumes data stored in an STL-compatible container)|  
|[CComEnumImpl](../vs140/ccomenumimpl-class.md)|Enumerator interface implementation (assumes data stored in an array)|  
|[CComEnumOnSTL](../vs140/ccomenumonstl-class.md)|Enumerator object implementation (uses `IEnumOnSTLImpl`)|  
|[CComEnum](../vs140/ccomenum-class.md)|Enumerator object implementation (uses `CComEnumImpl`)|  
|[_Copy](../vs140/atl-copy-policy-classes.md)|Copy policy class|  
|[_CopyInterface](../vs140/atl-copy-policy-classes.md)|Copy policy class|  
|[CAdapt](../vs140/cadapt-class.md)|Adapter class (hides **operator &** allowing `CComPtr`, `CComQIPtr`, and `CComBSTR` to be stored in STL containers)|  
  
## See Also  
 [Collections and Enumerators](../vs140/atl-collections-and-enumerators.md)