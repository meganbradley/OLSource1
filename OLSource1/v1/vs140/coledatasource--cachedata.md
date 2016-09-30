---
title: "COleDataSource::CacheData"
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
  - "CacheData"
  - "COleDataSource.CacheData"
  - "COleDataSource::CacheData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CacheData method"
  - "COleDataSource class, operations"
ms.assetid: c8ee2117-390f-47d7-b002-83625797cb67
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::CacheData
Call this function to specify a format in which data is offered during data transfer operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure containing the data in the format specified.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
## Remarks  
 You must supply the data, because this function provides it by using immediate rendering. The data is cached until needed.  
  
 Supply the data using a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure. You can also use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function if the amount of data you are supplying is small enough to be transferred efficiently using an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 After the call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> the **ptd** member of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the contents of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are owned by the data object, not by the caller.  
  
 To use delayed rendering, call the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) or [DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::CacheGlobalData](../vs140/coledatasource--cacheglobaldata.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)   
 [COleDataSource::DoDragDrop](../vs140/coledatasource--dodragdrop.md)