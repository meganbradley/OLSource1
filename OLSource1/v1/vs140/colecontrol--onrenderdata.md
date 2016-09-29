---
title: "COleControl::OnRenderData"
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
  - "OnRenderData"
  - "COleControl::OnRenderData"
  - "COleControl.OnRenderData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderData method"
ms.assetid: 6317b550-deff-4c35-9c76-d48b8f550e80
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnRenderData
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
 The specified format is one previously placed in the control object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) or [DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md) member functions for delayed rendering. The default implementation of this function calls `OnRenderFileData` or `OnRenderGlobalData`, respectively, if the supplied storage medium is either a file or memory. If the requested format is `CF_METAFILEPICT` or the persistent property set format, the default implementation renders the appropriate data and returns nonzero. Otherwise, it returns 0 and does nothing.  
  
 If *lpStgMedium->tymed* is **TYMED_NULL**, the **STGMEDIUM** should be allocated and filled as specified by *lpFormatEtc->tymed*. If not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override `OnRenderGlobalData`. If your data is in a file, or is of variable size, override `OnRenderFileData`.  
  
 For more information, see the **FORMATETC** and **STGMEDIUM** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnRenderFileData](../vs140/colecontrol--onrenderfiledata.md)   
 [COleControl::OnRenderGlobalData](../vs140/colecontrol--onrenderglobaldata.md)