---
title: "COleDataSource::OnRenderData"
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
  - "COleDataSource::OnRenderData"
  - "OnRenderData"
  - "COleDataSource.OnRenderData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderData method"
  - "COleDataSource class, operations"
ms.assetid: 3b82e777-bcc4-4145-a4e0-125b65a6b3ba
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::OnRenderData
Called by the framework to retrieve data in the specified format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data is to be returned.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object using the [DelayRenderData](../vs140/coledatasource--delayrenderdata.md) or [DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md) member function for delayed rendering. The default implementation of this function will call [OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md) or [OnRenderGlobalData](../vs140/coledatasource--onrenderglobaldata.md) if the supplied storage medium is either a file or memory, respectively. If neither of these formats are supplied, then the default implementation will return 0 and do nothing. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>->*tymed* is **TYMED_NULL**, the **STGMEDIUM** should be allocated and filled as specified by *lpFormatEtc->tymed*. If it is not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For more information, see the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures, the [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227) enumeration type, and [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleDataSource::DelayRenderFileData](../vs140/coledatasource--delayrenderfiledata.md)   
 [COleDataSource::OnRenderFileData](../vs140/coledatasource--onrenderfiledata.md)   
 [COleDataSource::OnRenderGlobalData](../vs140/coledatasource--onrenderglobaldata.md)   
 [COleDataSource::OnSetData](../vs140/coledatasource--onsetdata.md)