---
title: "IDataObjectImpl::GetData"
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
  - "IDataObjectImpl::GetData"
  - "IDataObjectImpl.GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetData method [ATL]"
ms.assetid: 092f55d5-efbd-45d9-a862-f37c5adcfd1e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDataObjectImpl::GetData
Transfers data from the data object to the client.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *pformatetcIn* parameter must specify a storage medium type of **TYMED_MFPICT**.  
  
 See [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../vs140/idataobjectimpl-class.md)   
 [IDataObjectImpl::GetDataHere](../vs140/idataobjectimpl--getdatahere.md)   
 [IDataObjectImpl::QueryGetData](../vs140/idataobjectimpl--querygetdata.md)   
 [IDataObjectImpl::SetData](../vs140/idataobjectimpl--setdata.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)   
 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812)   
 [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227)