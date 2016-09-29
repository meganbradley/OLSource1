---
title: "IDataObjectImpl::QueryGetData"
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
  - "IDataObjectImpl.QueryGetData"
  - "QueryGetData"
  - "IDataObjectImpl::QueryGetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryGetData method"
ms.assetid: 391a6ed4-bd35-416d-a319-0733e1a6bc64
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDataObjectImpl::QueryGetData
Determines whether the data object supports a particular **FORMATETC** structure for transferring data.  
  
## Syntax  
  
```  
  
      HRESULT QueryGetData(  
   FORMATETC* pformatetc   
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IDataObject::QueryGetData](http://msdn.microsoft.com/library/windows/desktop/ms680637) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../VS_csharp/idataobjectimpl-class.md)   
 [IDataObjectImpl::GetData](../VS_csharp/idataobjectimpl--getdata.md)   
 [IDataObjectImpl::GetDataHere](../VS_csharp/idataobjectimpl--getdatahere.md)   
 [IDataObjectImpl::SetData](../VS_csharp/idataobjectimpl--setdata.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)