---
title: "COleServerItem::GetLinkSourceData"
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
  - COleServerItem.GetLinkSourceData
  - GetLinkSourceData
  - COleServerItem::GetLinkSourceData
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerItem class, operations
  - GetLinkSourceData method
ms.assetid: 3888d18e-550f-44b7-9471-930d0374fe0a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerItem::GetLinkSourceData
Call this function to get the `CF_LINKSOURCE` data for an OLE item.  
  
## Syntax  
  
```  
  
      BOOL GetLinkSourceData(  
   LPSTGMEDIUM lpStgMedium   
);  
```  
  
#### Parameters  
 `lpStgMedium`  
 Pointer to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the `CF_LINKSOURCE` data for the OLE item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This format includes the CLSID describing the type of the OLE item and the information needed to locate the document containing the OLE item.  
  
 The result can then be added to a data source with [COleDataSource::CacheData](../vs140/coledatasource--cachedata.md). This function is called automatically by [OnGetClipboardData](../vs140/coleserveritem--ongetclipboarddata.md).  
  
 For more information, see [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::GetEmbedSourceData](../vs140/coleserveritem--getembedsourcedata.md)   
 [COleServerItem::GetObjectDescriptorData](../vs140/coleserveritem--getobjectdescriptordata.md)