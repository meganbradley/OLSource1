---
title: "COleDataSource::DelaySetData"
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
  - COleDataSource.DelaySetData
  - COleDataSource::DelaySetData
  - DelaySetData
dev_langs: 
  - C++
helpviewer_keywords: 
  - DelaySetData method
  - COleDataSource class, operations
ms.assetid: 9e78c2f6-ca39-4b97-9242-d6b27dac64b2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDataSource::DelaySetData
Call this function to support changing the contents of the data source.  
  
## Syntax  
  
```  
  
      void DelaySetData(  
   CLIPFORMAT cfFormat,  
   LPFORMATETC lpFormatEtc = NULL   
);  
```  
  
#### Parameters  
 `cfFormat`  
 The Clipboard format in which the data is to be placed. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 `lpFormatEtc`  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be replaced. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by `cfFormat`. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
## Remarks  
 [OnSetData](../vs140/coledatasource--onsetdata.md) will be called by the framework when this happens. This is only used when the framework returns the data source from [COleServerItem::GetDataSource](../vs140/coleserveritem--getdatasource.md). If `DelaySetData` is not called, your `OnSetData` function will never be called. `DelaySetData` should be called for each Clipboard or **FORMATETC** format you support.  
  
 For more information, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::GetDataSource](../vs140/coleserveritem--getdatasource.md)   
 [COleDataSource::OnSetData](../vs140/coledatasource--onsetdata.md)