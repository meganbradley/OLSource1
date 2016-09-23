---
title: "COleServerItem::OnRenderGlobalData"
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
  - COleServerItem::OnRenderGlobalData
  - COleServerItem.OnRenderGlobalData
  - OnRenderGlobalData
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerItem class, overridables
  - OnRenderGlobalData method
ms.assetid: ca7f9381-7fba-47b7-b3b8-046bf30b3ec9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerItem::OnRenderGlobalData
Called by the framework to retrieve data in the specified format when the specified storage medium is global memory.  
  
## Syntax  
  
```  
  
      virtual BOOL OnRenderGlobalData(  
   LPFORMATETC lpFormatEtc,  
   HGLOBAL* phGlobal   
);  
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 `phGlobal`  
 Points to a handle to global memory in which the data is to be returned. If no memory has been allocated, this parameter can be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the `COleDataSource` object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 If `phGlobal` is **NULL**, then a new `HGLOBAL` should be allocated and returned in `phGlobal`. Otherwise, the `HGLOBAL` specified by `phGlobal` should be filled with the data. The amount of data placed in the `HGLOBAL` must not exceed the current size of the memory block. Also, the block cannot be reallocated to a larger size.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override [OnRenderData](../vs140/coleserveritem--onrenderdata.md). If your data is in a file, or is of variable size, override [OnRenderFileData](../vs140/coleserveritem--onrenderfiledata.md).  
  
 For more information, see [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnRenderData](../vs140/coleserveritem--onrenderdata.md)