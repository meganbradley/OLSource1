---
title: "IDataObjectImpl::SetData"
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
  - "SetData"
  - "IDataObjectImpl::SetData"
  - "IDataObjectImpl.SetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetData method"
ms.assetid: a525dfff-1f7b-43f7-9d99-0c5e06d73192
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDataObjectImpl::SetData
Transfers data from the client to the data object.  
  
## Syntax  
  
```  
  
      HRESULT SetData(  
   FORMATETC* pformatetc,  
   STGMEDIUM* pmedium,  
   BOOL fRelease   
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IDataObject::SetData](http://msdn.microsoft.com/library/windows/desktop/ms686626) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../vs140/idataobjectimpl-class.md)   
 [IDataObjectImpl::GetData](../vs140/idataobjectimpl--getdata.md)   
 [IDataObjectImpl::GetDataHere](../vs140/idataobjectimpl--getdatahere.md)   
 [IDataObjectImpl::QueryGetData](../vs140/idataobjectimpl--querygetdata.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)   
 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812)