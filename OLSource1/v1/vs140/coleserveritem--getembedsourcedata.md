---
title: "COleServerItem::GetEmbedSourceData"
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
  - "GetEmbedSourceData"
  - "COleServerItem::GetEmbedSourceData"
  - "COleServerItem.GetEmbedSourceData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, operations"
  - "GetEmbedSourceData method"
ms.assetid: 9ccee506-30f0-4b08-a9a4-7c7ca6bc3981
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::GetEmbedSourceData
Call this function to get the **CF_EMBEDSOURCE** data for an OLE item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the **CF_EMBEDSOURCE** data for the OLE item.  
  
## Remarks  
 This format includes the item's native data. You must have implemented the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function for this function to work properly.  
  
 The result can then be added to a data source by using [COleDataSource::CacheData](../vs140/coledatasource--cachedata.md). This function is called automatically by [COleServerItem::OnGetClipboardData](../vs140/coleserveritem--ongetclipboarddata.md).  
  
 For more information, see [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::GetLinkSourceData](../vs140/coleserveritem--getlinksourcedata.md)   
 [COleServerItem::GetObjectDescriptorData](../vs140/coleserveritem--getobjectdescriptordata.md)   
 [COleDataSource::CacheData](../vs140/coledatasource--cachedata.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)