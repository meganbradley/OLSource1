---
title: "COleClientItem::GetCachedExtent"
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
  - "COleClientItem::GetCachedExtent"
  - "COleClientItem.GetCachedExtent"
  - "GetCachedExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCachedExtent method"
  - "COleClientItem class, status"
ms.assetid: 90d57c37-f39a-4db2-9610-08ee843207b4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetCachedExtent
Call this function to retrieve the OLE item's size.  
  
## Syntax  
  
```  
  
      BOOL GetCachedExtent(  
   LPSIZE lpSize,  
   DVASPECT nDrawAspect = (DVASPECT  
)-1   
);  
```  
  
#### Parameters  
 `lpSize`  
 Pointer to a **SIZE** structure or a [CSize](../vs140/csize-class.md) object that will receive the size information.  
  
 `nDrawAspect`  
 Specifies the aspect of the OLE item whose bounds are to be retrieved. For possible values, see [SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md).  
  
## Return Value  
 Nonzero if successful; 0 if the OLE item is blank.  
  
## Remarks  
 This function provides the same information as [GetExtent](../vs140/coleclientitem--getextent.md). However, you can call `GetCachedExtent` to get extent information during the processing of other OLE handlers, such as [OnChange](../vs140/coleclientitem--onchange.md). The dimensions are in `MM_HIMETRIC` units.  
  
 This is possible because `GetCachedExtent` uses the [IViewObject2](http://msdn.microsoft.com/library/windows/desktop/ms691318) interface rather than use the [IOleObject](http://msdn.microsoft.com/library/windows/desktop/dd542709) interface to get the extent of this item. The **IViewObject2** COM object caches the extent information used in the previous call to [IViewObject::Draw](http://msdn.microsoft.com/library/windows/desktop/ms688655).  
  
 For more information, see [IViewObject2::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms684032) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetExtent](../vs140/coleclientitem--getextent.md)   
 [COleClientItem::SetExtent](../vs140/coleclientitem--setextent.md)   
 [COleServerItem::OnGetExtent](../vs140/coleserveritem--ongetextent.md)