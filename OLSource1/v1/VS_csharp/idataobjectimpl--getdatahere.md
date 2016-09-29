---
title: "IDataObjectImpl::GetDataHere"
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
  - "GetDataHere"
  - "IDataObjectImpl.GetDataHere"
  - "IDataObjectImpl::GetDataHere"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDataHere method"
ms.assetid: 180f2eb1-ddc1-4344-a693-0cfa24c0cbdb
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDataObjectImpl::GetDataHere
Similar to `GetData`, except the client must allocate the **STGMEDIUM** structure.  
  
## Syntax  
  
```  
  
      HRESULT GetDataHere(  
   FORMATETC* pformatetc,  
   STGMEDIUM* pmedium   
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IDataObject::GetDataHere](http://msdn.microsoft.com/library/windows/desktop/ms687266) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../VS_csharp/idataobjectimpl-class.md)   
 [IDataObjectImpl::GetData](../VS_csharp/idataobjectimpl--getdata.md)   
 [IDataObjectImpl::QueryGetData](../VS_csharp/idataobjectimpl--querygetdata.md)   
 [IDataObjectImpl::SetData](../VS_csharp/idataobjectimpl--setdata.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)   
 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812)