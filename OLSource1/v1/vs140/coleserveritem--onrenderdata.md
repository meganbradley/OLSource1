---
title: "COleServerItem::OnRenderData"
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
  - "COleServerItem.OnRenderData"
  - "OnRenderData"
  - "COleServerItem::OnRenderData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderData method"
  - "COleServerItem class, overidables"
ms.assetid: e8581ce5-2e68-4fa3-a32c-09bbc0b406a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnRenderData
Called by the framework to retrieve data in the specified format.  
  
## Syntax  
  
```  
  
      virtual BOOL OnRenderData(  
   LPFORMATETC lpFormatEtc,  
   LPSTGMEDIUM lpStgMedium   
);  
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 `lpStgMedium`  
 Points to a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data is to be returned.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the `COleDataSource` object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) or [DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md) member function for delayed rendering. The default implementation of this function calls [OnRenderFileData](../vs140/coleserveritem--onrenderfiledata.md) or [OnRenderGlobalData](../vs140/coleserveritem--onrenderglobaldata.md), respectively, if the supplied storage medium is either a file or memory. If neither of these formats is supplied, the default implementation returns 0 and does nothing.  
  
 If `lpStgMedium`->*tymed* is **TYMED_NULL**, the **STGMEDIUM** should allocated and filled as specified by *lpFormatEtc->tymed*. If not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override `OnRenderGlobalData`. If your data is in a file, or is of variable size, override `OnRenderFileData`.  
  
 For more information, see [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431), [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812), [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177), and [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnRenderFileData](../vs140/coleserveritem--onrenderfiledata.md)