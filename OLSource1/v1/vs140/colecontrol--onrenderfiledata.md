---
title: "COleControl::OnRenderFileData"
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
  - COleControl.OnRenderFileData
  - COleControl::OnRenderFileData
  - OnRenderFileData
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnRenderFileData method
ms.assetid: 651b67c2-dfca-4ff1-bd47-2cbaba570626
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::OnRenderFileData
Called by the framework to retrieve data in the specified format when the storage medium is a file.  
  
## Syntax  
  
```  
  
      virtual BOOL OnRenderFileData(  
   LPFORMATETC lpFormatEtc,  
   CFile* pFile   
);  
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 `pFile`  
 Points to a [CFile](../vs140/cfile-class.md) object in which the data is to be rendered.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the control object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 Override this function to provide your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override `OnRenderData`. If your data is in a file, or is of variable size, override `OnRenderFileData`.  
  
 For more information, see the **FORMATETC** structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnRenderData](../vs140/colecontrol--onrenderdata.md)   
 [COleControl::OnRenderGlobalData](../vs140/colecontrol--onrenderglobaldata.md)