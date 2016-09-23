---
title: "COleClientItem::GetClassID"
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
  - GetClassID
  - COleClientItem::GetClassID
  - COleClientItem.GetClassID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetClassID method [C++]
  - COleClientItem class, status
ms.assetid: 7995f51e-0623-4585-8263-d2acc04c2e08
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::GetClassID
Returns the class ID of the item into the memory pointed to by `pClassID`.  
  
## Syntax  
  
```  
  
      void GetClassID(  
   CLSID* pClassID   
) const;  
```  
  
#### Parameters  
 `pClassID`  
 Pointer to an identifier of type [CLSID](http://msdn.microsoft.com/library/windows/desktop/ms691424) to retrieve the class ID. For information on **CLSID**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The class ID is a 128-bit number that uniquely identifies the application that edits the item.  
  
 For more information, see [IPersist::GetClassID](http://msdn.microsoft.com/library/windows/desktop/ms688664) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)